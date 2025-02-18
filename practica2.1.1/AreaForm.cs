using Practica2._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2._1._1
{
    public partial class AreaForm : Form
    {
        DAOArea area = new DAOArea();
        Area n = new Area();
        bool edit = false;

        public AreaForm()
        {
            InitializeComponent();
        }

        public void rellenar(int a)
        {
            n = area.ObtenerArea(a);
            txtId.Text = "ID: " + n.Id;
            txtBoxNombre.Text = n.Nombre;
            txtBoxUbicacion.Text = n.Ubicacion;
            btnEliminar.Enabled = true;
            edit = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta área?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                area.EliminarArea(n);
                MessageBox.Show("Área eliminada exitosamente.");
                Dispose();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            n.Nombre = txtBoxNombre.Text;
            n.Ubicacion = txtBoxUbicacion.Text;

            if (edit)
            {
                area.ModificarArea(n);
            }
            else
            {
                area.AgregarArea(n);
            }
            Dispose();
        }
    }
}
