using AppCore.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class Form2 : Form
    {
        IEmpleadoServices empServices;
        private int idSeleccionado;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empServices.Read();
        }
    }
}
