using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millisoft_BankKartininYoxlanmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Indi kart nomresi ve sifre isteyeciyik. Onun ilk 4 reqemini gotureceyik.4098 basliyirsa Kapital Bankin karti
            // Eger bank karti Uygun deyilse 2 faiz tutulsun

            //Kod ve parolu burdanca daxil etdik
            Bank emel1 = new Bank("0002982110","1234567",50);
        }
    }


    public class Bank
    {
      string bankNomresi = "";
      private string bankPassword="";
      public float money=0,balans=300;
      static public int present=2;

        public Bank(string no,string bnkpassword,float money)
        {
            this.bankNomresi = no;  
            this.bankPassword = bnkpassword;
            this.money=money;
            cardCheck();
            
        }

        public void cardCheck()
        {
            Console.WriteLine("1-Kapital Bank");
            Console.WriteLine("2-AccessBank");
            Console.WriteLine("3-MuğanBank");
            Console.WriteLine("4-TuranBank");
            Console.WriteLine("5-Ziraat Bank");
            Console.WriteLine("Bankınızı seçin");
            string no=Console.ReadLine();

            if (no=="1")
            {
                
                Console.WriteLine("Welcome to Kapital bank");
                emeliyyat(bankNomresi.Substring(0, 4), "0001",money);          
                balans -= money;
                Console.WriteLine("Balans= " + balans);

            }

            else if (no=="2")
            {
                Console.WriteLine("Welcome to AccessBank");
                emeliyyat(bankNomresi.Substring(0, 4), "0002",money);
                balans -= money;
                Console.WriteLine("Balans= " + balans);

            }

            else if (no == "3")
            {
                Console.WriteLine("Welcome to MuğanBank");
                emeliyyat(bankNomresi.Substring(0, 4), "0003", money);
                balans -= money;
                Console.WriteLine("Balans= " + balans);

            }

            else if (no == "4")
            {
                Console.WriteLine("Welcome to TuranBank",money);
                emeliyyat(bankNomresi.Substring(0, 4), "0003", money);
                balans -= money;
                Console.WriteLine("Balans= " + balans);
            }
            else if (no == "5")
            {
                Console.WriteLine("Welcome to Ziraat Bank");
                emeliyyat(bankNomresi.Substring(0, 4), "0003", money);
                balans -= money;
                Console.WriteLine("Balans= "+balans);
            }

            else
            {
                Console.WriteLine("Something's worning");
            }
        }

        void emeliyyat(string a,string b,float pul)
        {
            if (a==b)
            {
                Console.WriteLine("Komissiya 0");
                Console.WriteLine(pul);
            }

            else
            {
                pul -= (pul * present) / 100;
                Console.WriteLine( pul);
            }
        }


    }
}
