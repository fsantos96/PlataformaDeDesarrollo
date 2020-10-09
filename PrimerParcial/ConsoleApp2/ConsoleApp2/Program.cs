using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static int idUltimoUsuario = 0;
        static void Main(string[] args)
        {
            //OperacionesDB.insertarDatosIniciales();
            MostrarTodasLasTareas();
            EliminacionDeUsuario();
            SeCambiaElResponsableDeUnaTarea();
        }

        static void MostrarTodasLasTareas()
        {
            IEnumerable<Tarea> listaTareas = OperacionesDB.ObtenerTodo<Tarea>();
            foreach(var tarea in listaTareas)
            {
                Console.WriteLine("Titulo " + tarea.Titulo);
                Console.WriteLine("Estimacion " + tarea.Estimacion);
                Console.WriteLine("Vencimiento " + tarea.Vencimiento);

                var responsable = OperacionesDB.ObtenerPorId<Recurso>(tarea.ResponsableId);
                Console.WriteLine("Responsable " + responsable.Nombre);

                List<Detalle> detalleActual = OperacionesDB.ObtenerPorExpresion<Detalle>(p=> p.TareaId == tarea.Id);
           
                if(detalleActual != null && detalleActual.Count > 0)
                {
                    Console.WriteLine("Detalles");
                    Console.WriteLine("Fecha " + detalleActual[0].Fecha);
                    Console.WriteLine("Duracion " + detalleActual[0].Tiempo);
                    List<Recurso> recursos = OperacionesDB.ObtenerPorExpresion<Recurso>(p => p.DetalleId == detalleActual[0].Id);
                    if(recursos != null && recursos.Count > 0)
                    {
                        Console.WriteLine("Recursos");
                        foreach (var recurso in recursos)
                        {
                            Console.WriteLine(recurso.Nombre);
                        }
                    }
                }
                Console.WriteLine("");
            }
        }

        static void MostrarTodosLosUsuarios()
        {
            List<Usuario> listaUsuario = OperacionesDB.ObtenerTodo<Usuario>();
            idUltimoUsuario = listaUsuario[listaUsuario.Count - 1].Id;
            foreach (var usuario in listaUsuario)
            {
                Console.WriteLine("Usuario " + usuario.Id);
                Console.WriteLine("Nombre " + usuario.User);
                Console.WriteLine("");
            }
        }

        static void EliminacionDeUsuario()
        {
            OperacionesDB.Insertar<Usuario>(new Usuario { User = "UsuarioQueSeEliminara", Clave = "123er" });
            MostrarTodosLosUsuarios();

            OperacionesDB.Borrar<Usuario>(idUltimoUsuario);
            MostrarTodosLosUsuarios();
        }

        static void SeCambiaElResponsableDeUnaTarea()
        {
            Tarea tareaConCambios = new Tarea { Titulo = "Entrega del parcial2", Estimacion = 2, ResponsableId = 1, Vencimiento = new DateTime(2020, 10, 11, 21, 30, 0) };
            MostrarTodasLasTareas();

            OperacionesDB.Actualizar<Tarea>(tareaConCambios, 1);
            MostrarTodasLasTareas();
        }
    }
}
