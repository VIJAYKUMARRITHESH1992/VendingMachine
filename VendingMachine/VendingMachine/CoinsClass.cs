using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CoinsClass : ICoinsInterface
    {

        public CoinsEntity AddCoins(string coinName)
        {
            CoinsEntity objres = new CoinsEntity();
            if (coinName == "nickels")
            {
                objres.CoinValue = Convert.ToDecimal(0.05);
                objres.CoinName = coinName;
                objres.ReturnType = true;
                return objres;
            }
            else if (coinName == "dimes")
            {
                objres.CoinValue = Convert.ToDecimal(0.1);
                objres.CoinName = coinName;
                objres.ReturnType = true;
                return objres;
            }
            else if (coinName == "quarters")
            {
                objres.CoinValue = Convert.ToDecimal(0.25);
                objres.CoinName = coinName;
                objres.ReturnType = true;
                return objres;
            }
            else
            {
                objres.CoinValue = Convert.ToDecimal(0.01);
                objres.CoinName = coinName;
                objres.ReturnType = false;
                return objres;
            }   
        }
    }
}
