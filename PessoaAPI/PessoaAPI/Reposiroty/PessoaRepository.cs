using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Reposiroty
{
    public class PessoaRepository : IPessoaRepository
    {
        public List<PessoaModel> GetPessoa()
        {
            return new List<PessoaModel>()
            {
                new PessoaModel()
                {
                    Id = 1,
                    Nome ="Samuel",
                    Telefone = "11999999999",
                },
                new PessoaModel()
                {
                    Id = 2,
                    Nome ="Helena",
                    Telefone = "11999998888",
                }
            };
        }
    }
}
