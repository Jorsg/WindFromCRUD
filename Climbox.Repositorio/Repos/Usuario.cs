using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Climbox.Dominio;

namespace Climbox.Repositorio.Repos 
{
    public class Usuario : RepositorioBase<Usuarios>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public bool InsertUsuarios(Usuarios usuarios)
        {
            bool respuesta = false;
            try
            {
                Save(usuarios);
                respuesta = true;
            }
            catch (Exception ex)
            {
                var error = ex.StackTrace;
                throw;
            }
            return respuesta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public bool UpdatClientes(Usuarios usuarios)
        {
            bool respuesta = false;
            try
            {
                Update(usuarios);
                respuesta = true;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                throw;
            }
            return respuesta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Usuarios> GetTodosUsuarios()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public List<Usuarios> FindByClientesIdenfiticacion(string cedula)
        {
            var query = Contexto.Usuarios.Where(x => x.Identificacion == cedula);
            return query.ToList();
        }

        public List<Usuarios> FindByClientes(string nombre, string apellido)
        {
            var query = Contexto.Usuarios.Where(x => x.Nombre == nombre && x.Apellido == apellido);
            return query.ToList();
        }

        public Usuarios FindByClienteIdenti(string cedula)
        {
            var query = Contexto.Usuarios.FirstOrDefault();
            return query;
        }




    }
}
