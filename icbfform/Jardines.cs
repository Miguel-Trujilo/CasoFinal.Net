using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icbfform
{
    public partial class Jardines : Form
    {
        public Jardines()
        {
            InitializeComponent();
        }

        private void Jardines_Load(object sender, EventArgs e)
        {
            modelo.jardinDAO jardinDAO = new modelo.jardinDAO();
            modelo.estadoDAO estadoDAO = new modelo.estadoDAO();
            dgvJardines.DataSource = jardinDAO.consultarTodos();
            cmbEstado.DataSource = estadoDAO.consultarTodos();
            cmbEstado.ValueMember = "id_estado";
            cmbEstado.DisplayMember = "estado";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.Jardines jardin = new modelo.Jardines();
            modelo.jardinDAO jardinDAO = new modelo.jardinDAO();
            modelo.estadoJardin estado = new modelo.estadoJardin();
            estado.id_estado = int.Parse(cmbEstado.SelectedValue.ToString());
            estado.estado = cmbEstado.Text;
            jardin.nombre = txtNombre.Text;
            jardin.direccion = txtDireccion.Text;
            jardin.id_estado = int.Parse(cmbEstado.SelectedValue.ToString());
            jardinDAO.registrar(jardin);
        }
    }
}
