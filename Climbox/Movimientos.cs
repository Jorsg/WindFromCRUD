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

namespace Climbox
{
    public partial class Movimientos : Form
    {
        private readonly Reportes repoMovi = new Reportes();
        public Movimientos()
        {
            InitializeComponent();
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            MostarMoviminetosMes();
        }

        public void MostarMoviminetosMes()
        {
            var query = repoMovi.MovimientosMes(dtpFecha.Value);
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Nombre_Completo", typeof(string));           
            dt.Columns.Add("Identificacion", typeof(string));
            dt.Columns.Add("Valor", typeof(decimal));
            dt.Columns.Add("Mensualidad", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("FechaPago", typeof(DateTime));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("TipoPago", typeof(string));
            dt.Columns.Add("Servicio", typeof(string));

            DataRow dr = dt.NewRow();
            foreach (var item in query)
            {
                dt.Rows.Add(dr["Nombre_Completo"] = string.Format("{0} {1}", item.Nombre, item.Apellido),
                            dr["Identificacion"] = item.Identificacion, dr["Valor"] = item.Valor, dr["Mensualidad"] = item.Mensualidad, dr["Cantidad"] = item.Cantidad, 
                            dr["FechaPago"] = item.FechaPago, dr["Email"] = item.Email, dr["TipoPago"] = item.TipoPago, dr["Servicio"] = item.Servicio);
            }
            dtgDatos.DataSource = dt;
        }

        public void MostrarTodoMovimiento()
        {
            var query = repoMovi.MovimientosAnual();
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Identificacion", typeof(string));
            dt.Columns.Add("valor", typeof(decimal));
            dt.Columns.Add("Mensualidad", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("TipoPago", typeof(string));
            dt.Columns.Add("Servicio", typeof(string));

            DataRow dr = dt.NewRow();
            foreach (var item in query)
            {
                dt.Rows.Add(dr["Nombre_Completo"] = string.Format("{0} {1}", item.Nombre, item.Apellido),
                            dr["Identificacion"] = item.Identificacion, dr["Valor"] = item.Valor, dr["Mensualidad"] = item.Mensualidad, dr["Cantidad"] = item.Cantidad,
                            dr["FechaPago"] = item.FechaPago, dr["Email"] = item.Email, dr["TipoPago"] = item.TipoPago, dr["Servicio"] = item.Servicio);
            }
            dtgDatos.DataSource = dt;
        }

        private void CopiarGrilla()
        {
            dtgDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dtgDatos.MultiSelect = true;
            dtgDatos.SelectAll();
            DataObject dataObj = dtgDatos.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            dtgDatos.MultiSelect = false;
            dtgDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
        }

        private void ExportarAExcel()
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            CopiarGrilla();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            MessageBox.Show("Exportación finalizada con éxito");
        }

        private void btnAnual_Click(object sender, EventArgs e)
        {
            MostrarTodoMovimiento();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel();
        }
    }
}
