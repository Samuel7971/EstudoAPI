using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Services
{
    public interface IPessoaService
    {
        List<PessoaModel> GetPessoa();
        PessoaModel GetById(int id);
    }
}
