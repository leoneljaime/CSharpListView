using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Objetos;
using static WindowsFormsApp1.Objetos.Enumeracoes;

namespace WindowsFormsApp1.BO
{
    internal class ClientesBO
    {
        #region + Privados
        private IList<Cliente> clientes;
        #endregion - Privados

        #region + Construtores
        public ClientesBO()
        {
            CarregaClientesMemoria();
        }

        private void CarregaClientesMemoria()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente((clientes.Count+1),"Leonel Jaime ", "Rio Verde", "GO", "64999881234", "leonel@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Marcelo", "Cidade", "UF", "6432511234", "marcelo@gmail.com", "Bill Gates"));
            clientes.Add(new Cliente((clientes.Count+1),"Maria Jose ", "Rio Verde", "GO", "6436131233", "maria.jose@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Elon Musk", "Rio Verde", "GO", "6436131234", "starlink@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Wolverine", "Rio Verde", "GO", "6436131234", "logan@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Batman", "Rio Verde", "GO", "6436131234", "batman@gmail.com", "Bill Gates"));
            clientes.Add(new Cliente((clientes.Count+1),"Charles Xavier", "Rio Verde", "GO", "6436131234", "chales.xavier@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Tony Stark", "Fortaleza", "CE", "6436131234", "homem_d_ferro@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Hulk", "Belo Horizonte", "MG", "6436131234", "hulk@gmail.com", "Bill Gates"));
            clientes.Add(new Cliente((clientes.Count+1),"Larry Lieber", "Rio Verde", "GO", "6436131234", "larry@gmail.com", "Steve Jobs"));
            clientes.Add(new Cliente((clientes.Count+1),"Chaves", "São Paulo", "SP", "6436131234", "chaves@gmail.com", "Bill Gates"));
            clientes.Add(new Cliente((clientes.Count+1),"Chiquinha", "São Paulo", "SP", "6436131234", "chiquinha@gmail.com", "Steve Jobs"));
        }
        #endregion - Construtores

        #region + Metodos

        public IList<Cliente> BuscaPor(TipoPesquisa tipo, string pesquisa)
        {
            var consulta = clientes;

            if (!pesquisa.ENulaVazia())
            {
                switch (tipo)
                {
                    case TipoPesquisa.Codigo: consulta = clientes.Where(x => x.Codigo == pesquisa.ToInt32()).ToList(); break;
                    case TipoPesquisa.Cidade: consulta = clientes.Where(x => x.Cidade.ToLower().Contains(pesquisa.ToLower())).ToList(); break;
                    case TipoPesquisa.Cliente: consulta = clientes.Where(x => x.Nome.ToLower().Contains(pesquisa.ToLower())).ToList(); break;
                    case TipoPesquisa.Vendedor: consulta = clientes.Where(x => x.Vendedor.ToLower().Contains(pesquisa.ToLower())).ToList(); break;
                }
            }
            return consulta;
        }

        #endregion - Metodos
    }
}
