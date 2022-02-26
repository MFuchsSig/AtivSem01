using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    class Funcoes
    {
        public Funcoes(string[] args)
        {
            try
            {
                int[,] tabela = { { 111, 2, 3, 4, 5 } };
                int maior = 0;
                for (int l = 0; l < tabela.GetLength(0); l++)
                {
                    for (int c = 0; c < tabela.GetLength(1); c++)
                    {
                        if (maior < tabela[l, c]) maior = tabela[l, c];
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
