using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Climbox.Dominio;

namespace Climbox.Repositorio.Repos
{
    public class Pagos : RepositorioBase<Climbox.Dominio.Pagos>
    {
        /// <summary>
        /// Guarda los pagos de los usuarios
        /// </summary>
        /// <param name="pago"></param>
        /// <returns></returns>
        public bool InsertPagos(Climbox.Dominio.Pagos pago)
        {
            bool respuesta = false;
            try
            {
                Save(pago);
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
        /// Modifica los pagos de los usuarios
        /// </summary>
        /// <param name="pagos"></param>
        /// <returns></returns>
        public bool UpdatPagos(Climbox.Dominio.Pagos pagos)
        {
            bool respuesta = false;
            try
            {
                Update(pagos);
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
        /// Consulta el pago del usuario
        /// </summary>
        /// <param name="cedulaCliente"></param>
        /// <returns></returns>
        public List<Climbox.Dominio.Pagos> FindByPagoUsuario(string cedulaCliente)
        {
            var id_Usuario = Contexto.Usuarios.FirstOrDefault(x => x.Identificacion == cedulaCliente).Id;
            var query = Contexto.Pagos.Where(x => x.IdUsuario == id_Usuario);
            return query.ToList();
        }

        /// <summary>
        /// Devuelve el ultimo valor de la tabla pagos para cada usuario.
        /// </summary>
        /// <returns></returns>
        public Climbox.Dominio.Pagos FindbyMaxIdPago()
        {
            var query = Contexto.Pagos.OrderByDescending(t => t.Id).FirstOrDefault();
            return query;
        }

        public Climbox.Dominio.Pagos FindByIdPago(int idpago)
        {
            var query = Contexto.Pagos.FirstOrDefault(x => x.Id == idpago);
            return query;
        }

        public Climbox.Dominio.Pagos FindById(int id)
        {
            var query = Contexto.Pagos.FirstOrDefault(x => x.Id == id);
            return query;
        }
    }
}
