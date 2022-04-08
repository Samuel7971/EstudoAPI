using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Reposiroty
{
    public interface IPessoaRepository
    {
        List<PessoaModel> GetPessoa();
    }
}
