using AppCore.IServices;
using Domain.Entities;
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
    public partial class Form3 : Form
    {
        IEmpleadoServices empServices;
        
        public Form3(IEmpleadoServices empServices)
        {
            this.empServices = empServices;

            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            Empleado activo = new Empleado()
            {
                Cedula = txtdireccion.Text,
                Nombres = txtnom.Text,
                Apellidos = txtapellidos.Text,
                Direccion = txtapellidos.Text,
                Telefono = txttelefono.Text,
                Email = txtemail.Text
            };
            empServices.Add(activo);
            Form3 data
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
