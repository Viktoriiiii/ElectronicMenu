using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronMenu.Forms
{
    public class Customer
    {
        static int custId = 0;

        public int Nomer { get; }

        private double eWallet;
        Random rnd = new Random();

        public Customer()
        {
            custId++;
            Nomer = custId;
        }

        public void setWallet()
        {
            eWallet = rnd.Next(500, 5000);            
        }
        public void setWallet(double ew)
        {
            eWallet = ew;
        }

        public double getWallet()
        {
            return eWallet;
        }
    }
}
