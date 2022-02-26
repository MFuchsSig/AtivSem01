using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AtivSem01
{
    class Cadastro
    {
        public interface IOperacoesBD
        {
            public void Inserir();
            public void Alterar();
            public void Deletar();
            public void Pesquisar();
        }

        public abstract class Cadastros : IOperacoesBD
        {
            protected string Conexao { get; set; }

            public void Alterar()
            {
              
            }

            public void Deletar()
            {
               
            }

            public void Inserir()
            {
                
            }

            public void Pesquisar()
            {
               
            }
        }
    }
}
