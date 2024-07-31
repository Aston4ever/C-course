namespace Csharp;

class Programm {
    static void Main( string[] args ) {
        int a = 20;
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
        int strNum = String.GetHashCode(str);
        str = "MayBe".ToLower();
        Console.WriteLine( strNum );
        Console.WriteLine( str );
        //Finish lesson 20 
        Console.ReadLine();
    }
}
