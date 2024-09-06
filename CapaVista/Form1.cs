using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv1.Rows[e.RowIndex];

            txtnombre.Text = row.Cells["nombre_completo"].Value.ToString();
            txtpuesto.Text = row.Cells["puesto"].Value.ToString();
            txtdepto.Text = row.Cells["departamento"].Value.ToString();
            cbestado.SelectedItem = row.Cells["estado"].Value.ToString();
        }
    }
}
