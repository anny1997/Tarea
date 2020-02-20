using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Notas
{
   
        public class AlumnosBL
        {
            public BindingList<Alumno> ListaAlumnos { get; set; }

            public AlumnosBL()
            {
                ListaAlumnos = new BindingList<Alumno>();

                var alumno1 = new Alumno();
                alumno1.Id = 1;
                alumno1.Nombre = "Jose Paz";
                alumno1.NumeroIdentidad = "0501-1998-68549";
                alumno1.Curso = "2 Curos";
                alumno1.AnioCursado = 2;
              

                ListaAlumnos.Add(alumno1);

                var alumno2 = new Alumno();
                alumno2.Id = 2;
                alumno2.Nombre = "Alejandra Alvarez";
                alumno2.NumeroIdentidad = "0501-1994-67849";
                alumno2.Curso = "3 Curos";
                alumno2.AnioCursado = 3;
      
                ListaAlumnos.Add(alumno2);

                var alumno3 = new Alumno();
                alumno3.Id = 3;
                alumno3.Nombre = "Arturo Pleitez";
                alumno3.NumeroIdentidad = "0501-1997-07486";
                alumno3.Curso = "1 Curso";
                alumno3.AnioCursado = 1;
               

                ListaAlumnos.Add(alumno3);

                var alumno4 = new Alumno();
                alumno4.Id = 4;
                alumno4.Nombre = "Sintia lopez";
                alumno4.NumeroIdentidad = "0501-1994-05886";
                alumno4.Curso = "2 Curso";
                alumno4.AnioCursado = 2;


                ListaAlumnos.Add(alumno4);


        }

            public BindingList<Alumno> ObtenerAlumnos()
            {
                return ListaAlumnos;
            }
        }
        public class Alumno
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string NumeroIdentidad { get; set; }
            public string Curso { get; set; }
            public int AnioCursado { get; set; }
            public bool Activo { get; set; }
        }
}
