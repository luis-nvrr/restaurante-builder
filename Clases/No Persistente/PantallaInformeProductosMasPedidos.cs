using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Implementacion_PPAI.Clases.No_Persistente
{
    public partial class PantallaInformeProductosMasPedidos : Form
    {
        // opciones de ordenamiento
        private static readonly int Descendente = 0;
        private static readonly int Ascendente = 1;

        // formas de visualizacion
        private static readonly int Pantalla = 0;
        private static readonly int PDF = 1;
        private static readonly int Excel = 2;

        private GestorInformeProductosMasPedidos _gestor;


        public PantallaInformeProductosMasPedidos()
        {
            InitializeComponent();
        }

        private void PantallaInformeProductosMasPedidos_Load(object sender, EventArgs e)
        {
            DeshabilitarPaneles();
            pckFechaDesde.Value = DateTime.Parse("01/01/2020");
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this._gestor = new GestorInformeProductosMasPedidos(this);
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
            lblCorrecto.Visible = false;
            lblCorrecto.Enabled = false;
            listaCategorias.Items.Clear();
            listaSubCategorias.Items.Clear();
        }

        public void MostrarValidacionCorrecta()
        {
            lblErrorPeriodo.Visible = false;
            lblErrorPeriodo.Enabled = false;
            lblCorrecto.Visible = true;
            lblCorrecto.Enabled = true;

        }

        public void MostrarCategoriasDeCartaParaSeleccionar(List<String> categorias)
        {
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
            if (MessageBox.Show("¿Seguro que desea confirmar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _gestor.TomarConfirmacion();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            lblErrorPeriodo.Visible = false;
            lblCorrecto.Visible = false;
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
                _gestor.TomarFormaVisualizacion(Pantalla);
            }

            if(opcionPDF.Checked)
            {
                _gestor.TomarFormaVisualizacion(PDF);
            }

            if (opcionExcel.Checked)
            {
                _gestor.TomarFormaVisualizacion(Excel);
            }
        }


        public void EmitirErrorVisualizacion()
        {
            MessageBox.Show("Opción no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
