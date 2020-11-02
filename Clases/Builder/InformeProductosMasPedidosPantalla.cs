using System;
using System.Drawing;
using System.Windows.Forms;

namespace Implementacion_PPAI.Clases.Builder
{
    public partial class InformeProductosMasPedidosPantalla : Form
    {
        int _indice = -1;
        public InformeProductosMasPedidosPantalla()
        {
            InitializeComponent();
        }

        private void InformeProductosMasPedidosPantalla_Load(object sender, EventArgs e)
        {
        }

        public void SetEncabezado(String fechaDesde, String fechaHasta)
        {
            lblFechaDesde.Text += fechaDesde;
            lblFechaHasta.Text += fechaHasta;
        }

        public void AgregarCategoria(String categoria, String total)
        {
            grdCuerpo.Rows[_indice].Cells[0].Value = categoria;
            grdCuerpo.Rows[_indice].Cells[3].Value = total;
            grdCuerpo.Rows[_indice].DefaultCellStyle.BackColor = Color.FromArgb(38, 45, 77);

        }

        public void AgregarFila()
        {
            grdCuerpo.Rows.Add();
            _indice++;
        }

        public void AgregarSubcategoria(String subcategoria, String total)
        {
            grdCuerpo.Rows[_indice].Cells[1].Value = subcategoria;
            grdCuerpo.Rows[_indice].Cells[3].Value = total;
            grdCuerpo.Rows[_indice].DefaultCellStyle.BackColor = Color.FromArgb(48, 61, 116);
        }

        public void AgregarProducto(String producto, String total)
        {
            grdCuerpo.Rows[_indice].Cells[2].Value = producto;
            grdCuerpo.Rows[_indice].Cells[3].Value = total;
            grdCuerpo.Rows[_indice].DefaultCellStyle.BackColor = Color.FromArgb(53,72,154);
        }

        public void SetPie(String usuario, String fechaHora)
        {
            this.lblUsuario.Text += usuario;
            this.lblFechaHora.Text += fechaHora;
        }

        public void VisualizarProducto()
        {
            this.ShowDialog();
        }

        private void grdCuerpo_SelectionChanged(object sender, EventArgs e)
        {
            grdCuerpo.ClearSelection();
        }
    }
}
