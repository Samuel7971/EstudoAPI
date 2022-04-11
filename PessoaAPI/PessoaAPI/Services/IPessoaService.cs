using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Services
{
    public interface IPessoaService
    {
        List<PessoaModel> GetAll();
        PessoaModel GetById(int id);
    }
}
