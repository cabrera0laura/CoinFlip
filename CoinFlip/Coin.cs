using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Coin
    {

        //ModificadorDeAcesso Tipo Nome
        private string ladoSorteado;

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public Coin()
        {
        }

        public string Flip()
        {
            // duas formas: 1 -
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                LadoSorteado = "cara";
            }
            else
            {
                LadoSorteado = "coroa";
            }
            //2 -   LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";

            return (LadoSorteado);
        }
        
    }
}
