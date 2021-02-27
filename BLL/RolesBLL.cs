using Microsoft.EntityFrameworkCore;
using Proyecto_Registro.DAL;
using Proyecto_Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Registro.BLL
{
    class RolesBLL
    {
        public static bool Guardar(Roles roles)
        {
            if (!Existe(roles.RolID))
                return Insertar(roles);
            else
                return Modificar(roles);
        }

        private static bool Insertar(Roles roles)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Roles.Add(roles);
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

        public static bool Modificar(Roles roles)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete From RollDetalle where RolID = {roles.RolID}");
                foreach(var antes in roles.Detalles)
                {
                    contexto.Entry(antes).State = EntityState.Added;
                }
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var roles= contexto.Roles.Find(id);
                if (roles != null)
                {
                    contexto.Entry(roles).State = EntityState.Deleted;
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

        public static Roles Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Roles roles;
            try
            {
                roles = contexto.Roles.Include(e => e.Detalles).Where(p => p.RolID == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return roles;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Roles.Any(e => e.RolID == id);
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

        private static List<Roles> GetList(Expression<Func<Roles, bool>> criterio)
        {
            List<Roles> lista = new List<Roles>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Roles.Where(criterio).ToList();
            }
            catch(Exception)
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


        public static bool ExisteDescripcion(string promobre, int id)
        {

            Contexto contexto = new Contexto();
            bool encontado = false;

            try
            {
                encontado = contexto.Roles.Any(e => e.Descripcion == promobre);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if (encontado)
            {
                Roles rol = Buscar(id);
               
                if(rol == null)
                {
                    return true;
                }
                if (rol.Descripcion == promobre)
                    encontado = false;
            }
            return encontado;
        }
    }
}
