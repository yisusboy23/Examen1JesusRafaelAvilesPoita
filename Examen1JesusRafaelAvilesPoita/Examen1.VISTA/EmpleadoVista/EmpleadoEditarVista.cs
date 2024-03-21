using Examen1.BSS;
using Examen1.MODELOS;
using Examen1.VISTA.PersonaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1.VISTA.EmpleadoVista
{
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado u = new Empleado();
        EmpleadoBSS bss = new EmpleadoBSS();
        PersonaBSS bssuser = new PersonaBSS();
        public static int IdPersonaSeleccionada = 0;
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            u = bss.ObtenerEmpleadoIdBss(idx);
            textBox1.Text = u.IdPersona.ToString();
            textBox2.Text = u.Puesto;
            textBox3.Text = u.Salario.ToString();
            dateTimePicker1.Value = u.FechaContratacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.IdPersona = IdPersonaSeleccionada;
            u.Puesto = textBox2.Text;
            u.Salario = Convert.ToDecimal(textBox3.Text);
            u.FechaContratacion = dateTimePicker1.Value;

            bss.EditarEmpleadoBss(u);
            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssuser.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }
    }
}
