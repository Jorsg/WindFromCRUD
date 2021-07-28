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

namespace Climbox
{
    public partial class Registro : Form
    {
        private readonly PagoClientes pago = new PagoClientes();
        private readonly Movimientos movi = new Movimientos();
        private readonly Repositorio.Repos.Usuario repoUsuario = new Repositorio.Repos.Usuario();
        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'climboxDataSet.TipoUsuario' Puede moverla o quitarla según sea necesario.
            //this.tipoUsuarioTableAdapter.Fill(this.climboxDataSet.TipoUsuario);

        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pago.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCliente(txtIdentificacion.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (InsertCliente())
            {
                MessageBox.Show("El Usuario se guardo correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema en los datos, por favor revise cada campo para que sea guardado el usuario");
            }
        }

        public void ConsultarCliente(string cedula)        {
           
            var query = repoUsuario.FindByClientesIdenfiticacion(cedula);
            if (query.Any())
            {
                txtNombre.Text = query.FirstOrDefault().Nombre;
                txtApellido.Text = query.FirstOrDefault().Apellido;
                txtEmail.Text = query.FirstOrDefault().Email;
                txtEps.Text = query.FirstOrDefault().Eps;
                txtIdentificacion.Text = query.FirstOrDefault().Identificacion;
                txtNombreContac.Text = query.FirstOrDefault().PersonaContactoEmerge;
                txtOcupacion.Text = query.FirstOrDefault().Profesion;
                txtTelefEmergencia.Text = query.FirstOrDefault().TelefonPersoEmergenc;
                txtTelefono.Text = query.FirstOrDefault().Telefono;
                dtpFecha.Text = query.FirstOrDefault().FechaCumpleanos.ToString();
            }
        }

        public bool InsertCliente()
        {
            try
            {
                var client = new Usuarios
                {
                    Activo = true,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Eps = txtEps.Text,
                    FechaCreacion = DateTime.Now,
                    FechaCumpleanos = dtpFecha.Value,
                    FechaModificacion = DateTime.Now,
                    Identificacion = txtIdentificacion.Text,
                    IdTipoUsuario = Convert.ToInt32(cbmTipoUsuario.SelectedIndex),
                    Nombre = txtNombre.Text,
                    Sexo = cmbSexo.Text,
                    Profesion = txtOcupacion.Text,
                    Telefono = txtTelefono.Text,
                    UsuarioCrea = "admin",
                    UsuarioModifica = "admin",
                    PersonaContactoEmerge = txtNombreContac.Text,
                    TelefonPersoEmergenc = txtTelefEmergencia.Text,
                      
                };
                return repoUsuario.InsertUsuarios(client);
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                throw;
            }           
        }

       

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            var expresion = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if (Regex.IsMatch(txtEmail.Text, expresion))
            {

            }
            else
            {
                errorProvider1.SetError(this.txtEmail,"Por favor escriba correctamente su Email");
                return;
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre, "Ingresa el Nombre. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtIdentificacion_Validated(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtIdentificacion, "Ingresa la Identificación. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellido, "Ingresa el Apellido. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTelefono, "Ingresa el Teléfono. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEps_Validated(object sender, EventArgs e)
        {
            if (txtEps.Text.Trim() == "")
            {
                errorProvider1.SetError(txtEps, "Ingresa la EPS. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cbmTipoUsuario_Validated(object sender, EventArgs e)
        {
            if (cbmTipoUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(cbmTipoUsuario, "Selecciona el tipo de usuario. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
       


        private void txtNombreContac_Validated(object sender, EventArgs e)
        {
            if (txtNombreContac.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreContac, "Ingresa el Nombre Contacto, caso de emergencia. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTelefEmergencia_Validated(object sender, EventArgs e)
        {
            if (txtTelefEmergencia.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTelefEmergencia, "Ingresa el Teléfono en caso de emergencia. Campo Obligatorio para el registro");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombreContac.Text = string.Empty;
            txtOcupacion.Text = string.Empty;
            txtTelefEmergencia.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEps.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombreContac.Text = string.Empty;            
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movi.Show();
        }

       
    }
}
