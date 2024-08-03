using System.Drawing;
using static System.Console;

namespace Csharp;

class Programm { //Class and methods Names PascalNaming
    static void Main( string[] args ) {
        /*
         int a = 20; // 
        int a3 = 10;
        long a2 = 1000000;
        float b = 21.2f;
        double c = 21.34;
        decimal d = 34.211m;
        bool f = true;
        f = false;
        Console.WriteLine( a + a3 );
        Console.WriteLine( f );
        double num1 = 4.5;
        double num2 = 3.45;
        double dDiv = num1 / num2;
        Console.WriteLine( dDiv );
        float num12 = 4.5f;
        float num22 = 3.45f;
        float dDiv2 = num12 / num22;
        Console.WriteLine( dDiv2 );
        string str = "Aston";
        str = String.Empty;
        int strNum = String.GetHashCode( str );
        str = "MayBe".ToLower();
        Console.WriteLine( strNum );
        Console.WriteLine( str );
        //Finish lesson 20 
        int ascii = Console.Read();
        ConsoleColor foreground = Console.ForegroundColor;
        ConsoleColor background = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine( ascii );
        Console.BackgroundColor = background;
        Console.ForegroundColor = foreground;
        */
        
        /*
         double myDouble = 13.843; 
        int myInt;
        //cast double to int
        myInt = (int)myDouble; //explicit conversion. Отрезает часть, не округляет
        
        // implicit conversion
        int num2 = 1213214;  //Downcast Можно переводить безопасно маленькие числа в большие
        long num1 = num2;
        
        // typeCoversion
        string myStr = myDouble.ToString();


        string myStr1 = "15s";
        string myStr2 = "14";
        int number1 = int.Parse(myStr1);
        int number2 = int.Parse(myStr2);
        int result = number1 + number2;
        Console.WriteLine( result );
        */
        
        /*
         int age = 35;
        string name = "Aston";
        WriteLine($"Hello, my name is {name} and I am {age}");
        WriteLine($@"My ///@@$$$@#@!$)
_(&&)
_+/n");
*/

        /*
         string hello = "       Hello, my name is Aston and i like spaces          ";
        hello = hello.Trim();
        string newHello = hello.Substring( 2, 3 );
        newHello = newHello.ToUpper();
        */
        Write( "Enter your name: " );
        string? line = ReadLine();
        Clear();
        WriteLine( "--------You names' different variants" );
        WriteLine( line.ToUpper() );
        WriteLine(line.ToLower());
        WriteLine(line.Trim());
        WriteLine(line.Substring(2,4));
        ReadKey();
        Clear();

        WriteLine( "Enter number: " );
        string? num1 = ReadLine();

        int num2 = int.Parse(num1);
        WriteLine(num2);
        WriteLine( num2.GetTypeCode() );
        ReadKey();
    }
}