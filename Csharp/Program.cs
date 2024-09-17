using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using static System.Console;

namespace Csharp;

class Programm 
{ //Class and methods Names PascalNaming
    static void Main( string[] args ) {
        int[][] jaggedArr = new int[2][];
        jaggedArr[0] = new int[3];
        jaggedArr[1] = new int[2];

        ArrayList arrList = new ArrayList();
        arrList.Add( "Hello" );
        arrList.Add( 233 );
        arrList.Add( 1.45 );
        int a = arrList.Count;
        
        List<string> strList = new List<string>(); 

        int[] arrOfHappiness = [5, 3, 4, 3, 5];
        ArrIncreaser(arrOfHappiness);
        int counter = 0;

        foreach ( var element in arrOfHappiness ) {
            counter++;
            Console.WriteLine( $"elemet {counter} = {element}" );
        }
        //HASHTABLES
        Hashtable studentsTable = new Hashtable();
        Student stud1 = new Student( 1, "Aston", 98 );
        Student stud2 = new Student( 2, "Kolya", 78 );
        Student stud3 = new Student( 3, "Masha", 45 );
        //хранение данных в хэш таблице
        studentsTable.Add(stud1.Id, stud1);
        studentsTable.Add(stud2.Id, stud2);
        studentsTable.Add(stud3.Id, stud3);
        //Как извлечь инфо из хэштаблицы c известным ID
        Student storeStudent1 = (Student)studentsTable[stud1.Id]; // необходимо сделать каст до класса студент, что бы записать данные из хэш таблицы, так как в ней Value - Object
        // Извлечение всех данных из Хэш таблицы    
        foreach ( DictionaryEntry entry in studentsTable ) {    //entry - key\Value
            Student temp = (Student)entry.Value; //entry.Value - Value. Тоесть сам объект, который находится под этим индексом
            Console.WriteLine( temp.Id ); //А теперь когда мы превратили объект в класс студент то можем через точку получить его значения
            Console.WriteLine( temp.studentName );
            Console.WriteLine( temp.GPA );
        }
        //Сокращенная запись, сразу получаем класс студент (из пары кей вэлью берем сразу Вэльюс)
        foreach ( Student student in studentsTable.Values ) { 
            
        }

        Hashtable studentsHashtable = new Hashtable();
        Student[] students = new Student[5];
        students[0] = new Student( 1, "Martha", 99 );
        students[1] = new Student( 1, "Pery", 98 );
        students[2] = new Student( 11, "Cox", 56 );
        students[3] = new Student( 11, "Gill", 77 );
        students[4] = new Student( 23, "Tim", 38 );

        foreach ( Student student in students ) {
            if ( !studentsHashtable.ContainsKey( student.Id ) ) {
                WriteLine("It's working");
                studentsHashtable.Add(student.Id, student);
            }
        }

        foreach ( Student student in studentsHashtable.Values ) {
            WriteLine( $"Student's ID is {student.Id}, name is {student.studentName}, GPA is {student.GPA}" );
        }
        
        
        ParamMethod("Hello", "234", "Hello", "Hello", "dfg", "Hello", "beegg", "beep", "342" );
        
        int[] grades = new int[5];
        grades[2] = 5;
        int[] gradesMath = [];
        int[] gradesRus = new[] { 15, 634, 54, 72, 12 };
        WriteLine( "Grades at index 2 is {0} and the length is {1}", grades[2], grades.Length );

        int min = MinV2(3,7,-1,-2,56,67,3,-5,3,-7,767,3,23,-354353);
        Console.WriteLine( min );
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

    static void ArrIncreaser( int[] defArr ) {
        for ( int i = 0; i < defArr.Length; i++ ) {
            defArr[i] += 2;
        }
    }

    static void ParamMethod( params string[] paramArray ) {
        for ( int i = 0; i < paramArray.Length; i++ ) {
            Console.WriteLine( $"The element {i} of array is {paramArray[i]}" );
        }
    }

    public static int MinV2( params int[] numbers ) {
        int min = int.MaxValue; // максимальное значение

        foreach ( var elem in numbers ) {
            if ( elem < min ) {
                min = elem;
            }
        }
        return min;
    }
}

public class Student {
    public int Id { get; set; }
    public string? studentName { get; set; }
    public float GPA { get; set; }

    public Student(int Id, string studentName, float GPA) {
        this.Id = Id;
        this.studentName = studentName;
        this.GPA = GPA;
    }
}
