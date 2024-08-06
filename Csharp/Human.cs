namespace Csharp;

public class Human {
    
    private string firstName;
    private string lastName;
    private string eyeColor;
    private int age;

    public Human() {
        
    }
    //cunstructor
    public Human(string firstName) {
        this.firstName = firstName;
    }
    public Human(string firstName, string lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public Human(string firstName, string lastName, string eyeColor) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
    }
    public Human(string firstName, string lastName, string eyeColor, int age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
        this.age = age;
    }
    public void IntroduceMyself() {
        if ( age != 0 && firstName != null && lastName != null && eyeColor != null ) {
            Console.WriteLine($"Hello, {firstName} {lastName}! I have {eyeColor} eyes and i am {age}");
        } else if (age == 0 && firstName != null && lastName != null && eyeColor != null ){
            Console.WriteLine($"Hello, {firstName} {lastName}!I have {eyeColor} eyes!");
        } else if (age == 0 && firstName != null && lastName != null && eyeColor == null) {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }else if ( age == 0 && firstName != null && lastName == null && eyeColor == null) {
            Console.WriteLine($"Hello, {firstName}!");
        } else if ( age == 0 && firstName == null && lastName == null && eyeColor == null) {
            Console.WriteLine( "Object created, That's all!" );
        }
    }
}
