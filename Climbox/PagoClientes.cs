using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Climbox.Dominio;
using Climbox.Repositorio.Repos;
using System.Text.RegularExpressions;
using System.IO;
using Climbox.Paramentros;
using System.Net.Mail;
using System.Net.Mime;

namespace Climbox
{
    public partial class PagoClientes : Form
    {
        private readonly Climbox.Repositorio.Repos.Pagos repoPago = new Repositorio.Repos.Pagos();
        private readonly Climbox.Repositorio.Repos.Email repoemail = new Climbox.Repositorio.Repos.Email();
        private readonly Climbox.Repositorio.Repos.Usuario repousuar = new Climbox.Repositorio.Repos.Usuario();
        private readonly Climbox.Repositorio.Repos.PagoUsuario respoVwPa = new Climbox.Repositorio.Repos.PagoUsuario();
        
        StreamReader reader = new StreamReader(Parametros.RutaPlantillaCorreo);
        string content = string.Empty;

        public PagoClientes()
        {
            InitializeComponent();
        }

        private void PagoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'climboxDataSet1.TipoFormaPago' Puede moverla o quitarla según sea necesario.
          

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (InsertPagos())
            {
                var IdMaxPago = repoPago.FindbyMaxIdPago();               
                if(EnviarCorreo(IdMaxPago))
                MessageBox.Show("Se guardo el pago con éxito y se envío el correo al cliente");
            }
                
            else
                MessageBox.Show("Por favor validar que los datos esten correctos para que se guarde el pago");
        }

        public bool InsertPagos()
        {
            try
            {
                var cedula = ConsultarCliente(txtIdentificacion.Text);
                var pago = new Dominio.Pagos
                {
                   Cantidad = Convert.ToInt32(txtCantidad.Text),
                   Descripción = txtDescripcion.Text,
                   FechaPago = dtpFechaPago.Value,
                   Valor = Convert.ToDecimal(txtValor.Text),
                   IdUsuario = cedula.Id,
                   IdTipoFormaPago = Convert.ToInt32(cmbTipoPago.SelectedValue),
                   IdTipoServicio = 1,
                   IdImpuestos = null
                   
                };
                return repoPago.InsertPagos(pago);               
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                throw;
            }          
        }


        public bool EnviarCorreo(Climbox.Dominio.Pagos pag)
        {
            bool respuesta = false;
            var pago = respoVwPa.FindByPagoUsuario(pag.Id);
            try
            {
                string readFile = reader.ReadToEnd();
                content = readFile;
                string ruta = Parametros.RutaPlantillaCorreo;
                string adjunto = ruta + content;
                content = content.Replace("[Numero]", pago.id.ToString());
                content = content.Replace("[Nombre]", string.Format("{0} {1}", pago.Nombre, pago.Apellido));
                content = content.Replace("[CC]", pago.Identificacion);
                content = content.Replace("[Concepto]", pago.Descripción);
                content = content.Replace("[Valor]", pago.Valor.ToString());
                content = content.Replace("[Total]", pago.Valor.ToString());
                content = content.Replace("[Cantidad]", pago.Cantidad.ToString());
                content = content.Replace("[Fecha]", pago.FechaPago.ToString());
                content = content.Replace("[Logo]", Parametros.Logo);
                Email.EnviarCorreo(Paramentros.Parametros.RemitenteCorreoPorDefecto, pago.Email, "Comprobante de pago", content, Parametros.Usuario, Parametros.Password);
                respuesta = true;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return respuesta;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtValor.Text = string.Empty;
            dtgPagos.DataSource = null;
        }

        private void btnConsultarPa_Click(object sender, EventArgs e)
        {
            ConsultarPagos();
        }

        public void ConsultarPagos()
        {
            var query = repoPago.FindByPagoUsuario(txtIdentificacion.Text);

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("Identificación", typeof(string));
            dt.Columns.Add("FechaPago", typeof(DateTime));
            dt.Columns.Add("ValorPago", typeof(string));
            dt.Columns.Add("DescripciónPago", typeof(string));
          
            DataRow dr = dt.NewRow();
            foreach (var item in query)
            {
                dt.Rows.Add(dr["Usuario"] = string.Format("{0} {1}", item.Usuarios.Nombre, item.Usuarios.Apellido), dr["Identificación"] = item.Usuarios.Identificacion, dr["FechaPago"] = item.FechaPago,
                            dr["ValorPago"] = item.Valor, dr["DescripciónPago"] = item.Descripción);
            }
            dtgPagos.DataSource = dt;
        }

        public Usuarios ConsultarCliente(string cedula)
        {
            var query = repousuar.FindByClienteIdenti(cedula);
            return query;
        }
    }
}
