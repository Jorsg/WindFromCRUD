using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Climbox.Dominio;

namespace Climbox.Repositorio.Repos
{
    public class PagoUsuario : RepositorioBase<Vw_PagoUsuario>
    {
        public Vw_PagoUsuario FindByPagoUsuario(int id)
        {
            var query = Contexto.Vw_PagoUsuario.FirstOrDefault(x => x.id == id);
            return query;
        }
    }
}
