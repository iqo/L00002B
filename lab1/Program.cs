using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0002BInl1
{
    class register
    {
        int price;
        int moneypaid;
        int totmoneyback;
        int tousandbill;
        int fivehundredbill;
        int twohundredbill;
        int hundredbill; 
        int fiftybill;
        int twentybill;
        int tencoin;
        int fivecoin;
        int twocoin;
        int onecoin;

    public void moneyInput(){
        Console.WriteLine("enter price: ");
        price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter money paid:  ");
        moneypaid = Convert.ToInt32(Console.ReadLine());
        totmoneyback = price - moneypaid;
        if (moneypaid < price)
        {
            Console.WriteLine("you need to pay more money: ");

        }
        else 
        {
            Console.WriteLine("money back: " + -1*totmoneyback);
            change();
        }


    }

    public void change(){
        tousandbill = ((totmoneyback * -1) / 1000);
        fivehundredbill = ((totmoneyback * -1) % 1000) / 500;
        twohundredbill = ((totmoneyback * -1) % 500) / 200;
        hundredbill = ((((totmoneyback * -1) % 500) / 100) - 2*(((totmoneyback * -1) % 500) / 200));
        fiftybill = ((totmoneyback * -1) % 100) / 50;
        twentybill = ((totmoneyback * -1) % 50 ) / 20;
        tencoin = ((((totmoneyback * -1) % 50) / 10) - 2*(((totmoneyback * -1) % 50) / 20));
        fivecoin = ((totmoneyback * -1) % 10) / 5;
        twocoin = ((totmoneyback * -1) % 5) / 2;
        onecoin = (((totmoneyback * -1) % 5) - 2*(((totmoneyback * -1) % 5)/2));
        if (tousandbill >= 1)
        {
            if (tousandbill > 1)
            {
                Console.WriteLine(tousandbill + " tusenlappar");
            }
            else
            {
                Console.WriteLine(tousandbill +" tusenlapp");
            }
        }
        if (fivehundredbill >= 1)
        {
            if (fivehundredbill > 1)
            {
                Console.WriteLine(fivehundredbill +" femhundralappar");
            }
            else
            {
                Console.WriteLine(fivehundredbill +" femhundralapp");
            }
        }
        if (twohundredbill >= 1)
        {
            if (twohundredbill > 1)
            {
                Console.WriteLine(twohundredbill +" tvåhundralappar");
            }
            else
            {
                Console.WriteLine(twohundredbill +" tvåhundralapp");
            }
        }
        if (hundredbill >= 1)
        {
            if (hundredbill > 1)
            {
                Console.WriteLine(hundredbill +" hundralappar");
            }
            else
            {
                Console.WriteLine(hundredbill +" hundralapp");
            }
        }
        if (fiftybill >= 1)
        {
            if (fiftybill > 1)
            {
                Console.WriteLine(fiftybill +" femtiolappar");
            }
            else
            {
                Console.WriteLine(fiftybill +" femtiolapp");
            }   
        }
        if (twentybill >= 1)
        {
            if (twentybill > 1)
            {
                Console.WriteLine(twentybill +" tjugolappar");
            }
            else
            {
                Console.WriteLine(twentybill +" tjugolapp");
            }
        }
        if (tencoin >= 1)
        {
            if (tencoin > 1)
            {
                Console.WriteLine(tencoin +" tiokronor");
            }
            else
            {
                Console.WriteLine(tencoin +" tiokrona");
            }
        }
        if (fivecoin >= 1)
        {
            if (fivecoin > 1)
            {
                Console.WriteLine(fivecoin +" femkronor");
            }
            else
            {
                Console.WriteLine(fivecoin + " femkrona");
            }
        }
        if (twocoin >= 1)
        {
            if (twocoin > 1)
            {
                Console.WriteLine(twocoin + " tvåkronor");
            }
            else
            {
                Console.WriteLine(twocoin + " tvåkrona");
            }
        }
        if (onecoin >= 1)
        {
            if (onecoin > 1)
            {
                Console.WriteLine(onecoin +" enkronor");
            }
            else
            {
                Console.WriteLine(onecoin +" enkrona");
            }
        }
    }
}




    class Program
    {
        static void Main(string[] args)
        {
            register reg = new register();
            reg.moneyInput();
        }
    }
}
