using System.Drawing;
using static System.Console;

namespace Csharp;

class Programm 
{ //Class and methods Names PascalNaming
    const double PI = 3.14159;
    const int weeks = 52, months = 12;
    const string DB = "09.05.1989";
    
    static void Main( string[] args ) 
    { 
     WriteLine("What's the temperature like now?");
     string? tempInput = ReadLine();
     int tempTryParse;
     if ( int.TryParse(tempInput, out tempTryParse) ) {
      
     } else {
      tempTryParse = 0;
     }
     if ( tempTryParse < 20 ) {
       WriteLine("Take the coat");
     }else if ( tempTryParse == 20 ) {
       WriteLine("What a good weather");
     } else if ( tempTryParse > 20 ) {
       WriteLine("So hot!");
     } else {
       WriteLine("What?");
     }
     
     
     /*try {
      
     int a = 5;
     int b = 0;
     int result =  a / b;
     } catch ( DivideByZeroException e ) {
      WriteLine(e.Message);
     }*/
     
     /*
      WriteLine("Please enter a number: ");
     string numStr = ReadLine();

     try {
      int num = int.Parse( numStr );
     } catch ( ArgumentNullException ) {
      WriteLine( "NUll was entered" );
     } finally {
      WriteLine("That was called anyway");
     }
     */
     /*
      Write("Input num1: ");
     string input1 = ReadLine();
     Write("Input num2: ");
     string input2 = ReadLine();

     int x = int.Parse( input1 );
     int y = int.Parse( input2 );

     WriteLine($"The sum of {x} and {y} is {x + y}");
     ReadKey();
     */
     /*
      int result = AddMethod(3,5);
     WriteLine(result);
     WriteLine(AddMethod(5,7));
     AddMethod( AddMethod( 5, 6 ), AddMethod( 6, 3 ) ); //МЕтод внутри метода, метод как параметр
     WriteLine(Multiplay(4,7));
      */
     /*ConsoleMethod();
     string? text = ReadLine();
     ConsoleSpecific(text);*/
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
     int resultt = number1 + number2;
     Console.WriteLine( resultt );
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
     /*
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
     */
    }
    
    /*
     static int AddMethod(int x, int y) {
     return x + y;
    }
    static int Multiplay(int x, int y) {
     return x * y;
    }
    */
    /*
     static void ConsoleMethod() {
     WriteLine("Hello from method");
     ReadKey();
    }

    static void ConsoleSpecific(string myText) {
      Clear();
      WriteLine(myText);
    }
    */
}
