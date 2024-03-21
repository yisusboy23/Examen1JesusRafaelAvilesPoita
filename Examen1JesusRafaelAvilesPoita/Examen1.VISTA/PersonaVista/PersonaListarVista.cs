using Examen1.BSS;
using Examen1.VISTA.EmpleadoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1.VISTA.PersonaVista
{
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBSS bss = new PersonaBSS();
        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
