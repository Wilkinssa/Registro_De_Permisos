using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_De_Permisos.Entidades;
using Registro_De_Permisos.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Registro_De_Permisos.BLL
{
    class RolesBLL
    {
        public static bool Guardar(Roles rol)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Roles.Add(rol) != null)
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

        public static bool Modificar(Roles rol)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM RolesDetalle Where rolesId = {rol.rolesId}");

                foreach (var anterior in rol.RolesDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(rol).State = EntityState.Added;
                paso = (contexto.SaveChanges() > 0);
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Roles.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
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

        public static Roles Buscar(int id)
        {
            Roles orden = new Roles();
            Contexto contexto = new Contexto();

            try
            {
                orden = contexto.Roles.Include(o => o.RolesDetalle).Where(p => p.rolesId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return orden;
        }

        public static List<Roles> GetList(Expression<Func<Roles, bool>> orden)
        {
            List<Roles> lista = new List<Roles>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Roles.Where(orden).ToList();
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
        public static List<Roles> GetRoles()
        {
            List<Roles> lista = new List<Roles>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Roles.ToList();
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
    }
}
