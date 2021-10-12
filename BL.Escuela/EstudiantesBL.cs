using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class EstudiantesBL
    {
        public BindingList<Estudiantes> ListaEstudiantes { get; set; } //**

        public EstudiantesBL()
        {
            ListaEstudiantes = new BindingList<Estudiantes>();

            var estuden1 = new Estudiantes();
            estuden1.numeroCuenta = 2021001;
            estuden1.Nombre = "María";
            estuden1.Apellido = "Montes";
            estuden1.Edad = 15;
            estuden1.Telefono = 94024574;
            estuden1.Correo = "maria21@gmail.com";
            estuden1.Grado = "octavo";
            estuden1.Clases = "Matemáticas";
            estuden1.estMatriculado = true;
            ListaEstudiantes.Add(estuden1);

            var estuden2 = new Estudiantes();
            estuden2.numeroCuenta = 2021002;
            estuden2.Nombre = "Pedro";
            estuden2.Apellido = "Reyes";
            estuden2.Edad = 15;
            estuden2.Telefono = 89143675;
            estuden2.Correo = "pedro.n14@gmail.com";
            estuden2.Grado = "Sexto";
            estuden2.Clases = "Español";
            estuden2.estMatriculado = true;
            ListaEstudiantes.Add(estuden2);

            var estuden3 = new Estudiantes();
            estuden3.numeroCuenta = 2021003;
            estuden3.Nombre = "Nahomy";
            estuden3.Apellido = "Zelaya";
            estuden3.Edad = 15;
            estuden3.Telefono = 998884236;
            estuden3.Correo = "pelo.negro12@gmail.com";
            estuden3.Grado = "octavo";
            estuden3.Clases = "Inglés";
            estuden3.estMatriculado = true;
            ListaEstudiantes.Add(estuden3);

        }

        public BindingList<Estudiantes> ObtenerEstudiantes()
        {
            return ListaEstudiantes;
        }

    } // Fin class EstudiantesBL.

    public class Estudiantes //CLASE
    {
        public int numeroCuenta { get; set; } //Propiedad
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Grado { get; set; }
        public string Clases { get; set; }
        public bool estMatriculado { get; set; }
    }
}
