using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Implementacion_PPAI.Clases.No_Persistente
{
    public partial class PantallaInformeProductosMasPedidos : Form
    {
        public static readonly int Descendente = 0;
        public static readonly int Ascendente = 1;

        private GestorInformeProductosMasPedidos _gestor;
        private List<String>  _categoriasDeCartaSeleccionadas;
        private List<String> _subcategoriasDeCartaSeleccionadas;


        public PantallaInformeProductosMasPedidos()
        {
            this._gestor = new GestorInformeProductosMasPedidos(this);
            _categoriasDeCartaSeleccionadas = new List<String>();
            _subcategoriasDeCartaSeleccionadas = new List<String>();

            InitializeComponent();
        }

        private void PantallaInformeProductosMasPedidos_Load(object sender, EventArgs e)
        {
            DeshabilitarPaneles();
            pckFechaDesde.Value = DateTime.Parse("01/01/2020");
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.HabilitarPantalla();
            _gestor.NuevoInformeProducto();
        }

        public void SolicitarSeleccionPeriodo()
        {
            pckFechaDesde.Enabled = true;
            pckFechaHasta.Enabled = true;
            btnSeleccionarPeriodo.Enabled = true;
        }


        public void TomarSeleccionPeriodo_Click(object sender, EventArgs e)
        {
            _gestor.TomarPeriodo(pckFechaDesde.Value, pckFechaHasta.Value);
        }

        public void EmitirErrorPeriodo()
        {
            lblErrorPeriodo.Visible = true;
            lblErrorPeriodo.Enabled = true;
        }

        public void MostrarCategoriasDeCartaParaSeleccionar(List<String> categorias)
        {
            lblErrorPeriodo.Visible = false;
            lblErrorPeriodo.Enabled = false;
            pckFechaDesde.Enabled = false;
            pckFechaHasta.Enabled = false;
            btnSeleccionarPeriodo.Enabled = false;

            listaSubCategorias.Items.Clear();
            listaCategorias.Items.Clear();

            for (int i = 0; i < categorias.Count; i++)
            {
                listaCategorias.Items.Add(categorias[i]);
                listaCategorias.SetItemCheckState(i,CheckState.Checked);
            }
        }


        public void MostrarSubCategoriasDeCartaParaSeleccionar(List<String> subcategorias)
        {
            listaSubCategorias.Items.Clear();   
            for (int i = 0; i < subcategorias.Count; i++)
            {
                listaSubCategorias.Items.Add(subcategorias[i].Split('|')[1]);
                listaSubCategorias.SetItemCheckState(listaSubCategorias.Items.IndexOf(subcategorias[i].Split('|')[1]), CheckState.Checked);
            }
        }


        public void SolicitarSeleccionOpcionParaOrdenar()
        {
            pnlSeleccionOpcion.Enabled = true;
            btnSeleccionarOpcion.Enabled = true;
        }


        private void btnSeleccionarOpcion_Click(object sender, EventArgs e)
        {
            if (opcionAscendente.Checked)
            {
                _gestor.TomarOpcionParaOrdenar(Ascendente);
            }
            else
            {
                _gestor.TomarOpcionParaOrdenar(Descendente);
            }
            
        }

        public void SolicitarConfirmacion()
        {
            if (MessageBox.Show("¿Seguro que desea confirmar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                _gestor.TomarConfirmacion();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void DeshabilitarPaneles()
        {
            pckFechaDesde.Enabled = false;
            pckFechaHasta.Enabled = false;
            btnSeleccionarPeriodo.Enabled = false;

            pnlSeleccionOpcion.Enabled = false;
            btnSeleccionarOpcion.Enabled = false;

            pnlSeleccionVisualizacion.Enabled = false;
            btnSeleccionarVisualizacion.Enabled = false;
        }

        private void HabilitarPantalla()
        {
            listaCategorias.Items.Clear();
            listaSubCategorias.Items.Clear();
            opcionAscendente.Checked = false;
            opcionDescendente.Checked = false;
            opcionExcel.Checked = false;
            opcionPDF.Checked = false;
            opcionPantalla.Checked = false;
        }

        public void SolicitarSeleccionFormasVisualizacion()
        {
            pnlSeleccionVisualizacion.Enabled = true;
            btnSeleccionarVisualizacion.Enabled = true;
        }

        private void btnSeleccionarVisualizacion_Click(object sender, EventArgs e)
        {
            if (opcionPantalla.Checked)
            {
                _gestor.TomarFormaVisualizacion(opcionPantalla.Text.ToLower());
            }

            if(opcionPDF.Checked)
            {
                _gestor.TomarFormaVisualizacion(opcionPDF.Text.ToLower());
            }

            if (opcionExcel.Checked)
            {
                _gestor.TomarFormaVisualizacion(opcionExcel.Text.ToLower());
            }
        }

    }
}
