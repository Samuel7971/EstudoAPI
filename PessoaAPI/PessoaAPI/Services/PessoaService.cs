using PessoaAPI.Model;
using PessoaAPI.Reposiroty;
using System.Collections.Generic;
using System.Linq;

namespace PessoaAPI.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public List<PessoaModel> GetAll()
        {
            var pessoas = _pessoaRepository.GetPessoa();
            pessoas.ForEach(pessoa =>
            {
                pessoa.Nome = pessoa.Nome.CaixaAltaPrimeiraLetra();
            });
            return pessoas;
        }

        public PessoaModel GetById(int id)
        {
            var pessoas = _pessoaRepository.GetPessoa();
            var pessoaId = (from p in pessoas where p.Id == id select p).FirstOrDefault();
           // var pe = pessoas.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
            return pessoaId;
        }
    }
}
