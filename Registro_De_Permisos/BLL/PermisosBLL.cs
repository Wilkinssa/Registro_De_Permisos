using System;
using System.Collections.Generic;
using System.Text;
using Registro_De_Permisos.DAL;
using Registro_De_Permisos.Entidades;
using Registro_De_Permisos.BLL;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Registro_De_Permisos.BLL
{
    class PermisosBLL
    {
        private static bool Insertar(Permiso permiso)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Permiso.Add(permiso);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Permiso permiso)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(permiso).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Permiso.Any(e=> e.permisoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }


        public static bool ExisteDescripcion(string descripcion)
        {

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Permiso.Any(e => e.descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Guardar(Permiso permiso)
        {

            if (!Existe(permiso.permisoId))
                return Insertar(permiso);
            else
                return Modificar(permiso);

        }

        public static bool ExisteDescripcion(string descripcion, int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Permiso.Any(e => e.descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if (encontrado)
            {
                Permiso permiso = Buscar(id);

                if (permiso == null)
                    return true;

                if (permiso.descripcion == descripcion)
                    encontrado = false;
            }

            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var permiso = contexto.Permiso.Find(id);

                if (permiso != null)
                {
                    contexto.Permiso.Remove(permiso);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static List<Permiso> GetList(Expression<Func<Permiso, bool>> criterio)
        {
            List<Permiso> Lista = new List<Permiso>();
            Contexto contexto = new Contexto();

            try
            {

                Lista = contexto.Permiso.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        public static List<Permiso> GetRoles()
        {
            List<Permiso> lista = new List<Permiso>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Permiso.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }


        public static Permiso Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Permiso permiso;

            try
            {
                permiso = contexto.Permiso.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return permiso;
        }

    }
}
