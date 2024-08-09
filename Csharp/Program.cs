using System.Drawing;
using static System.Console;

namespace Csharp;

class Programm 
{ //Class and methods Names PascalNaming
    static void Main( string[] args ) {
        int[] grades = new int[5];
        grades[2] = 5;
        int[] gradesMath = [];
        int[] gradesRus = new[] { 15, 634, 54, 72, 12 };
        WriteLine( "Grades at index 2 is {0} and the length is {1}", grades[2], grades.Length );

        string[] friendsNames = new string[5];

        // for ( int i = 0; i < friendsNames.Length; i++ ) {
        //     Write("Enter your friend's name: ");
        //     string? name = Console.ReadLine();
        //     friendsNames[i] = name;
        // }

        foreach ( var name in friendsNames ) {
            Console.WriteLine( "My friend {0}", name );
        }

        int[,] mArr = new int[,] {
            {1,5,8},
            {5,23,6},
            {56,23,88}
        };
        WriteLine(mArr[2,2]);
        int dimensions = mArr.Rank;
        Console.WriteLine( dimensions );

        foreach ( var item in mArr ) {
            WriteLine($" Item {item}");
        }

        for ( int i = 0; i < mArr.GetLength(0); i++ ) {
            for ( int j = 0; j < mArr.GetLength(1); j++ ) {
                if ( mArr[i,j] % 2 == 0 ) {
                    Write( mArr[i, j] + " " );
                }
            }
        }
        Console.WriteLine( " " );
        for ( int i = 0; i < mArr.GetLength(0); i++ ) {
            for ( int j =  mArr.GetLength(1); j == 0; j-- ) {
                if ( i == j ) {
                    Write( mArr[i, j] + " " );
                }
            }
        }
        
        //Lesson 89 finished
     /*
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
     */
     ReadKey();
    }
}
