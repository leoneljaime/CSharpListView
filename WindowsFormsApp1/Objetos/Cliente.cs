using WindowsFormsApp1.BO;

namespace WindowsFormsApp1.Objetos
{
    internal class Cliente
    {
        #region + Construtores
        public Cliente(int codigo, string nome, string cidade, string uF, string telefone, string email, string vendedor)
        {
            Codigo = codigo;
            Nome = nome;
            Cidade = cidade;
            UF = uF;
            Telefone = telefone.ColocarMascaraTelefone_DDD();
            Email = email.ToTrimOrEmpty().ToLower();
            Vendedor = vendedor;
        }
        #endregion - Construtores

        #region + Propriedades

        public int Codigo { get; set; }
        public string  Nome { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Vendedor { get; set; }


        #endregion - Propriedades
    }
}
