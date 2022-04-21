using System;
using System.Collections.Generic;
using SistemaCobranca.Domain;

namespace SistemaCobranca.Data
{
    public class CobrancaRepository
    {
         private List<Cobranca> listaDeCobranca = new List<Cobranca>();

        public List<Cobranca> GetAll()
        {
            return listaDeCobranca;
        }

        public void Save(Cobranca cobranca)
        {
            listaDeCobranca.Add(cobranca);
        }

        public Cobranca GetById(int idCobranca)
        {
            return listaDeCobranca.Find(p => p.Id == idCobranca);
        }

        public void Update(Cobranca cobranca)
        {
            var cobrancaEditado = GetById(cobranca.Id);

            cobrancaEditado.DataPgto = DateTime.Now;
        }

        public void Delete(Cobranca cobranca)
        {
            listaDeCobranca.Remove(cobranca);
        }
    }
}