using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    internal class Convert_Price
    {
        static void Main(string[] args)
        {
            IMovable bugattiVeyron = new BugattiVeyron(); 
            IMovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Console.WriteLine("The converted price of 268 USD is "+bugattiVeyronAdapter.GetUSD()+" Euro.");
            //IMovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl();
            //Console.WriteLine(bugattiVeyronAdapter.GetUSD());

        }
    }
    public interface IMovable
    {
        double GetUSD();
    }
    public class BugattiVeyron : IMovable
    {
        public  double GetUSD()
        {
            return 268;
        }
    }
    public interface IMovableAdapter
    { 
        double GetUSD();
    }
    public class MovableAdapterImpl : IMovableAdapter
    {
        private IMovable luxuryCars; // standard constructors
        public MovableAdapterImpl(IMovable luxuryCars1)
        {
            luxuryCars= luxuryCars1;
        }
        public  double GetUSD()
        {
            return ConvertUSDtoEURO(luxuryCars.GetUSD());
        }
        private static double ConvertUSDtoEURO(double usd)
        {
            return usd*0.88;
        }
    }
}
