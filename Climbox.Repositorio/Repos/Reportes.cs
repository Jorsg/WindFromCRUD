using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Climbox.Dominio;

namespace Climbox.Repositorio.Repos
{
    public class Reportes : RepositorioBase<Vw_Movimientos>
    {
        public IEnumerable<Vw_Movimientos> MovimientosMes(DateTime fecha)
        {
            DateTime fechaM = fecha.Date;
            var query = Contexto.Vw_Movimientos.Where(x => x.FechaPago >= fechaM);
            return query.ToList();
        }

        public IEnumerable<Vw_Movimientos> MovimientosAnual()
        {
            var query = Contexto.Vw_Movimientos;
            return query.ToList();
        }
    }
}
