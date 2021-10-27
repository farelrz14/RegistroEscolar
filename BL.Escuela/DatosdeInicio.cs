using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioMaster = new Usuario();
            usuarioMaster.Nombre = "master";
            usuarioMaster.Contrasena = "123";

            contexto.Usuarios.Add(usuarioMaster);

            // var usuarioEstu = new Usuario();
            // usuarioEstu.Nombre = "estu";
            // usuarioEstu.Contrasena = "456";

            //contexto.Usuarios.Add(usuarioEstu);

            var grado1 = new Grado();
            grado1.Descripcion = "Primero";
            contexto.Grados.Add(grado1);

            var grado2 = new Grado();
            grado2.Descripcion = "Segundo";
            contexto.Grados.Add(grado2);

            var grado3 = new Grado();
            grado3.Descripcion = "Tercero";
            contexto.Grados.Add(grado3);

            var grado4 = new Grado();
            grado4.Descripcion = "Cuarto";
            contexto.Grados.Add(grado4);

            var grado5 = new Grado();
            grado5.Descripcion = "Quinto";
            contexto.Grados.Add(grado5);

            var grado6 = new Grado();
            grado6.Descripcion = "Sexto";
            contexto.Grados.Add(grado6);

            base.Seed(contexto);
        }
    }
}
