using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebApplication1.Data;

namespace WebApplication1.Entities
{
    public class OperacionesDB
    {
        public static void Insertar<T>(T elemento) where T : class
        {
            var ctx = new TaskDbContext();
            ctx.Add<T>(elemento);
            ctx.SaveChanges();
        }

        public static void InsertarSinGuardar<T>(T elemento, TaskDbContext ctx) where T : class
        {
            ctx.Add<T>(elemento);
        }

        public static List<T> ObtenerTodo<T>() where T : class
        {
            var ctx = new TaskDbContext();
            return ctx.Set<T>().ToList<T>();
        }

        public static List<T> ObtenerTodoInclude<T, I>(Expression<Func<T, I>> expresion) where T : class where I : class
        {
            var ctx = new TaskDbContext();
            return ctx.Set<T>().Include<T, I>(expresion).ToList();
        }

        public static List<T> ObtenerPorExpresion<T>(Expression<Func<T, bool>> expresion) where T : class
        {
            var ctx = new TaskDbContext();
            return ctx.Set<T>().Where(expresion).ToList();
        }
        
        public static T ObtenerPorId<T>(int id) where T : class
        {
            var ctx = new TaskDbContext();
            var elemento = ctx.Set<T>().Find(id);
            return elemento ?? (T)Activator.CreateInstance(typeof(T));
        }

        public static void Actualizar<T>(T elemento) where T : class
        {
            var ctx = new TaskDbContext();
            ctx.Set<T>().Attach(elemento);
            ctx.Set<T>().Update(elemento);
            ctx.SaveChanges();
        }

        public static void Borrar<T>(int id) where T : class
        {
            var ctx = new TaskDbContext();
            T elementoABorrar = ObtenerPorId<T>(id);
            if(!elementoABorrar.Equals((T)Activator.CreateInstance(typeof(T))))
            {
                ctx.Set<T>().Remove(elementoABorrar);
                ctx.SaveChanges();
            }
        }

        public static void InsertarDatosIniciales()
        {
            // El codigo comentado se debe a que por tema de dependencia fui ejecutando de a partes tambien
            // por eso hay varios saveChanges.
            //var ctx = new TaskDbContext();
            //OperacionesDB.InsertarSinGuardar<Usuario>(new Usuario { Clave = "12345", User = "Santos" }, ctx);
            //OperacionesDB.InsertarSinGuardar<Usuario>(new Usuario { Clave = "45678", User = "TaTeTi" }, ctx);
            //OperacionesDB.InsertarSinGuardar<Usuario>(new Usuario { Clave = "34633", User = "Master" }, ctx);
            //ctx.SaveChanges();
            //Recurso recurso1 = new Recurso { UsuarioId = 1, Nombre = "Federico Santos"};
            //Recurso recurso2 = new Recurso { UsuarioId = 3, Nombre = "Raul Soria" };
            //Recurso recurso3 = new Recurso { Nombre = "Notebook" };
            //Recurso recurso4 = new Recurso { Nombre = "Sala de Reuniones 2" };

            //OperacionesDB.InsertarSinGuardar<Recurso>(recurso1, ctx);
            //OperacionesDB.InsertarSinGuardar<Recurso>(recurso2, ctx);
            //OperacionesDB.InsertarSinGuardar<Recurso>(recurso3, ctx);
            //OperacionesDB.InsertarSinGuardar<Recurso>(recurso4, ctx);
            //ctx.SaveChanges();
            //OperacionesDB.InsertarSinGuardar<Tarea>(new Tarea { Titulo = "Entrega del parcial", Estimacion = 2, ResponsableId = 1, Vencimiento = new DateTime(2020, 10, 11, 21, 30, 0) }, ctx);
            //OperacionesDB.InsertarSinGuardar<Tarea>(new Tarea { Titulo = "Reunion de Avance", Estimacion = 2, ResponsableId = 2, Vencimiento = new DateTime(2020, 10, 11, 21, 30, 0) }, ctx);
            //ctx.SaveChanges();
            //OperacionesDB.InsertarSinGuardar<Detalle>(new Detalle { TareaId = 2, Tiempo = "11:30", Fecha = new DateTime(2020, 10, 11), RecursoId= 3 }, ctx);
            //OperacionesDB.InsertarSinGuardar<Detalle>(new Detalle { TareaId = 2, Tiempo = "11:30", Fecha = new DateTime(2020, 10, 11), RecursoId = 2 }, ctx);

            //ctx.SaveChanges();
        }
    }
}
