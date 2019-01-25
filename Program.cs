using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
// Declare and use a bool, int, double, char, string, and decimal type.

var quantity  = 0.0;
//bool choice ;
string[] books ={"Java","NS","Webapps"} ;
double javaCost = 350.99;
double NScost = 390.50;
double Webappscost = 295;
string bk;
double cost = 0.0;
double discount = 20;
char exit;
var name = "";
bool choice = false;


// Implement at least one loop

 Console.WriteLine("Enter your Name");
 name = Console.ReadLine();

  Console.WriteLine("Do you want purchase book true or false");
   choice= Convert.ToBoolean(Console.ReadLine());
   if (choice == true){


do{
Console.WriteLine("\n Enter book name ");

bk = Console.ReadLine();

Console.WriteLine("\n Enter Quantity no greater than 5");
quantity = Convert.ToDouble(Console.ReadLine());

 

    double totalCost(double quan, double bookcost){

        cost =  (quan * bookcost);
        return cost;
    }
    double disc(double bkcost){
        double offer= (bkcost*discount)/100;
         return offer;
    }
    
    switch (quantity)
    {
        case 1:
        case 2:
         case 3:
       if(bk == "java"){
        Console.WriteLine($" cost of total books : {totalCost( quantity, javaCost)}");
    }
    else if (bk == "NS"){
          Console.WriteLine($" cost of total books : {totalCost(quantity, NScost)}");

    }
    else {
         Console.WriteLine($" cost of total books : {totalCost(quantity, Webappscost)}");
    }

    break;
    case 4:
    case 5:
       if(bk == "java"){
        double totaljava = totalCost( quantity, javaCost);
            double amountjava = (totaljava - disc(totaljava));
            Console.WriteLine($"Actual cost of books are: {totaljava}");
        Console.WriteLine($"  After discount cost of total books : {amountjava}");
    }
    else  if(bk == "NS"){
        double totalNS = totalCost( quantity, NScost);
            double amountNS = (totalNS - disc(totalNS));
             Console.WriteLine($"Actual cost of books are: {totalNS}");
        Console.WriteLine($" cost of total books : {amountNS}");
    }
    else{
        double totalweb = totalCost( quantity, Webappscost);
            double amountweb = (totalweb - disc(totalweb));
             Console.WriteLine($"Actual cost of books are: {totalweb}");
        Console.WriteLine($" cost of total books : {amountweb}");
    }
     break;

        }



Console.WriteLine("Please enter q for exiting");
exit = Convert.ToChar(Console.ReadLine());

}while (exit != 'q');

   
        
    }
        }
    }
}
