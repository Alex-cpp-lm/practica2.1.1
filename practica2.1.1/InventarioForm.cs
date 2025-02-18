using Practica2._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2._1._1
{
    public partial class InventarioForm : Form
    {
        DAOInventario inventario = new DAOInventario();
        Inventario a = new Inventario();
        bool edit = false;

        public InventarioForm()
        {
            InitializeComponent();
        }

        public void rellenar(int id)
        {
            a = inventario.ObtenerInventarioPorId(id);
            btnEliminar.Enabled = true;
            edit = true;
            txtId.Text = "ID: "+a.Id;
            txtNombreCorto.Text = a.NombreCorto;
            txtColor.Text = a.Descripcion;
            txtFechaAdquisicion.Text = a.FechaAdquisicion + "";
            txtDescripcion.Text = a.Descripcion;
            txtSerie.Text = a.Serie;
            cmbBoxTipoAdqui.Text = a.TipoAdquisicion;
            cmbBoxArea.Text = a.AreaId.ToString();
            txtObservaciones.Text = a.Observaciones;
            txtColor.Text = a.Color;
            rellenarAreas();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreCorto.Text != "" && txtColor.Text != "" && txtDescripcion.Text != "" &&
                txtSerie.Text != "" && txtObservaciones.Text != "" && cmbBoxTipoAdqui.Text != "" & cmbBoxArea.Text != "")
            {
                string[] t = (cmbBoxArea.Text).Split('-');
                a.NombreCorto = txtNombreCorto.Text;
                a.Descripcion = txtColor.Text;
                a.FechaAdquisicion = txtFechaAdquisicion.Text;
                a.Descripcion = txtDescripcion.Text;
                a.Serie = txtSerie.Text;
                a.TipoAdquisicion = cmbBoxTipoAdqui.Text;
                a.Observaciones = txtObservaciones.Text;
                a.Color = txtColor.Text;
                a.AreaId = int.Parse(t[0]);

                if (edit)
                {
                    inventario.ModificarInventario(a);
                }
                else
                {
                    inventario.AgregarInventario(a);
                }

                this.Dispose();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void rellenarAreas()
        {
            DAOArea area = new DAOArea();
            List<string> lista = area.ObtenerIDAreas();
            foreach (var item in lista)
            {
                cmbBoxArea.Items.Add(item);

            }
            cmbBoxArea.BeginUpdate();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este inventario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                inventario.EliminarInventario(a);
                MessageBox.Show("Inventario eliminado exitosamente.");
                this.Dispose();
            }
        }
       
    }
}
