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
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        EmpleadoBSS bss = new EmpleadoBSS();
        PersonaBSS bssuser = new PersonaBSS();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssuser.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado u = new Empleado();
            u.IdPersona = IdPersonaSeleccionada;
            u.Puesto = textBox2.Text;
            u.Salario = Convert.ToDecimal(textBox3.Text);
            u.FechaContratacion = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario");
        }
    }
}
