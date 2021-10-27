using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class MaestrosBL
    {
        Contexto _contexto;

        BindingList<Maestro> ListaMaestros { get; set; }

        public MaestrosBL()
        {
            _contexto = new Contexto();
            ListaMaestros = new BindingList<Maestro>();
        }

        public BindingList<Maestro> ObtenerMaestros()
        {
            _contexto.Maestros.Load();
            ListaMaestros = _contexto.Maestros.Local.ToBindingList();

            return ListaMaestros;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarMaestro(Maestro maestro)
        {
            var resultado = Validar(maestro);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarMaestro()
        {
            var nuevoMaestro = new Maestro();
            _contexto.Maestros.Add(nuevoMaestro);
        }

        public bool EliminarMaestro(int id)
        {
            foreach (var maestro in ListaMaestros.ToList())
            {
                if (maestro.Id == id)
                {
                    ListaMaestros.Remove(maestro);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Maestro maestro)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (maestro == null)
            {
                resultado.Mensaje = "Agregue un Catedratico valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(maestro.Catedratico) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del Catedratico";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

         public class Maestro
        {
            public int Id { get; set; }
            public string Catedratico { get; set; }
            public bool Activo { get; set; }

            public Maestro()
            {
                Activo = true;
            }
        }
    }

