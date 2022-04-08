using System.Collections.Generic;
using SistemaCobranca.Domain;

namespace SistemaCobranca.Data
{
    public class CobrancaRepository
    {
        List<Cobranca> listaDeCobranca = new List<Cobranca>();

        public List<Cobranca> GetAll()
        {
            return listaDeCobranca;
        }
    }
}