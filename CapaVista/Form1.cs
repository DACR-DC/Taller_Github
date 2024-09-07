using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        ControladorGH cn = new CapaControlador.ControladorGH();
        string emp = "empleados";

        public Form1()
        {
            InitializeComponent();
            cbestado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            cbestado.Items.Add(new KeyValuePair<string, int>("Inactivo", 0));
            cbestado.DisplayMember = "Key";
            cbestado.ValueMember = "Value";
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv1.Rows[e.RowIndex];

            txtnombre.Text = row.Cells["nombre_completo"].Value.ToString();
            txtpuesto.Text = row.Cells["puesto"].Value.ToString();
            txtdepto.Text = row.Cells["departamento"].Value.ToString();
            cbestado.SelectedItem = row.Cells["estado"].Value.ToString();
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgv1.DataSource = dt;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbestado.SelectedItem != null)
                {
                    string nombre_completo = txtnombre.Text;
                    string puesto = txtpuesto.Text;
                    string departamento = txtdepto.Text;

                    var kvp = (KeyValuePair<string, int>)cbestado.SelectedItem;
                    int estado = kvp.Value;

                    cn.GuardarEmpleado(nombre_completo, puesto, departamento, estado);

                    MessageBox.Show("Empleado guardado exitosamente");
                    actualizardatagriew();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un estado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el empleado: {ex.Message}");
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            cn.EliminarEmpleado(nombre);
            MessageBox.Show("Empleado eliminado exitosamente");
            actualizardatagriew();
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbestado.SelectedItem != null)
                {
                    string nombre_completo = txtnombre.Text;
                    string puesto = txtpuesto.Text;
                    string departamento = txtdepto.Text;

                    var kvp = (KeyValuePair<string, int>)cbestado.SelectedItem;
                    int estado = kvp.Value;

                    cn.ActualizarEmpleado(nombre_completo, puesto, departamento, estado);

                    MessageBox.Show("Empleado guardado exitosamente");
                    actualizardatagriew();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un estado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el empleado: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
