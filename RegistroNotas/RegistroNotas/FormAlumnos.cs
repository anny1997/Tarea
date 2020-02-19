using BL.Notas;
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
    public partial class FormAlumnos : Form
    {
        AlumnosBL _alumnos;

        public FormAlumnos()
        {
            InitializeComponent();

            _alumnos = new AlumnosBL();
            listaAlumnosBindingSource.DataSource = _alumnos.ObtenerAlumnos();
        }
    }
}
