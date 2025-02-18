using Practica2._1;

namespace practica2._1._1
{
    public partial class Inicio : Form
    {
        bool pestaña;
        DAOArea area = new DAOArea();
        DAOInventario inventario = new DAOInventario();
        int idCatch = 0;

        public Inicio()
        {
            InitializeComponent();
            dataGridView1.DataSource = inventario.ObtenerInventario();
            dataGridView1.Refresh();
            pestaña = true;
            btnInven.Enabled = false;
            btnArea.Enabled = true;
        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            pestaña = true;
            btnInven.Enabled = false;
            btnArea.Enabled = true;
            idCatch = 0;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            dataGridView1.DataSource = inventario.ObtenerInventario(); 
            dataGridView1.Refresh();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            pestaña = false;
            idCatch = 0;
            btnArea.Enabled = false;
            btnInven.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            dataGridView1.DataSource = area.ObtenerAreas();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idCatch = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                Console.WriteLine("ID seleccionada: " + idCatch);
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AreaForm n1 = new AreaForm();
            InventarioForm n2 = new InventarioForm();
            if (idCatch > 0)
            {

                if (pestaña == false)
                {
                    n1.rellenar(idCatch);
                    n1.Show();
                }
                else
                {
                    n2.rellenar(idCatch);
                    n2.Show();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AreaForm n1 = new AreaForm();
            InventarioForm n2 = new InventarioForm();
            if (pestaña == false)
            {
                n1.Show();
            }
            else
            {
                n2.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pestaña == false)
            {
                area.EliminarArea(idCatch);
                dataGridView1.DataSource = area.ObtenerAreas();
                dataGridView1.Refresh();
            }
            else
            {
                inventario.EliminarInventario(idCatch);
                dataGridView1.DataSource = inventario.ObtenerInventario();
                dataGridView1.Refresh();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (pestaña == false)
            {
                dataGridView1.DataSource = area.ObtenerAreas();
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = inventario.ObtenerInventario();
                dataGridView1.Refresh();
            }
        }
    }
}
