namespace PessoaAPI.Services
{
    public static class ExtensionMethods
    {
        public static string CaixaAltaPrimeiraLetra(this string palavra)
        {
            var novaPalavra = string.Empty;
            if (palavra.Length > 0)
            {
                string[] palavras = palavra.Split(' ');
                foreach (var item in palavras)
                {
                    char[] caracteres = item.ToCharArray();
                    caracteres[0] = char.ToUpper(caracteres[0]);
                    novaPalavra += $"{new string(caracteres)} ";
                }
            }
            return novaPalavra;
        }
    }
}
