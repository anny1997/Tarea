using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroNotas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAlumnos = new FormAlumnos();
            formAlumnos.MdiParent = this;
            formAlumnos.Show();  
        }

        private void MateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClases = new FormMaterias ();
            formClases.MdiParent = this;
            formClases.Show();
        }

        private void registrarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRegristrarNotas = new FormRegistrarNotas ();
            formRegristrarNotas.MdiParent = this;
            formRegristrarNotas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login(); 
        }

        private void reporteDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteDeAlumnos = new FormReporteAlu();
            formReporteDeAlumnos.MdiParent = this;
            formReporteDeAlumnos.Show();
        }

        private void reporteDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteDeMaterias = new FormReporteMat();
            formReporteDeMaterias.MdiParent = this;
            formReporteDeMaterias.Show();
        }

        private void reporteDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteDeNotas = new FormReporteNotas();
            formReporteDeNotas.MdiParent = this;
            formReporteDeNotas.Show();
        }
    }
}
