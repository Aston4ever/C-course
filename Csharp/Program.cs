using System.Drawing;
using static System.Console;

namespace Csharp;

class Programm 
{ //Class and methods Names PascalNaming
    static void Main( string[] args ) {
     //create an object
     Human aston = new Human("Aston", "Star", "brown", 12);
     Human mike = new Human("Mike", "Miller", "Blue");
     Human noOne = new Human();
     Human Emily = new Human("Emili");
     Human Melony = new Human("Melony", "Cook");
     aston.IntroduceMyself();
     mike.IntroduceMyself();
     noOne.IntroduceMyself();
     Emily.IntroduceMyself();
     Melony.IntroduceMyself();
     Console.WriteLine( "---------------------------------------------------" );
     Properties box = new Properties(4,5,8);
     box.Width = 10;
     box.Volume = 4;
     Console.WriteLine( box.FronSurface );
     Console.WriteLine( box.Height );
     box.DisplayInfo();
     ReadKey();
    }
}
