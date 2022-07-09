using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vallet = Convert.ToDecimal(10.00);
            string userinput = "";
            string selectedproduct = "";
            Console.WriteLine("nickels");
            Console.WriteLine("dimes");
            Console.WriteLine("quarters");
            Console.WriteLine("pennies");
            Console.ReadLine();
            Console.WriteLine("Select coin");
            userinput = Console.ReadLine();
            userinput = userinput.ToString();
            Console.WriteLine(userinput);
            ICoinsInterface objCoins = new CoinsClass();
            CoinsEntity objres = new CoinsEntity();
            objres = objCoins.AddCoins(userinput);
            if(objres.ReturnType == true)
            {
                vallet += Convert.ToDecimal(objres.CoinValue);
                Console.WriteLine("CoinValue " + objres.CoinValue + " ");
            }
            else
            {
                Console.WriteLine(objres.ReturnType);
            }
            Console.ReadLine();
            Console.WriteLine("Select Product");
            selectedproduct = Console.ReadLine();
            selectedproduct = selectedproduct.ToString();
            Console.WriteLine(selectedproduct);
            IProductsInterface objcan = new Candy();
            IProductsInterface objchip = new Candy();
            IProductsInterface objcola = new Candy();
            switch (selectedproduct)
            {
                case "cola": Console.WriteLine(objcola.SelectProduct(selectedproduct, vallet));break;
                case "chips": Console.WriteLine(objchip.SelectProduct(selectedproduct, vallet)); break;
                case "candy": Console.WriteLine(objcan.SelectProduct(selectedproduct, vallet)); break;
            }

            }
        }
}
