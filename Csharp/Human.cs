namespace Csharp;

public class Human {
    
    private string firstName;
    private string lastName;
    private string eyeColor;
    private int age;

    //cunstructor
    public Human(string firstName, string lastName, string eyeColor, int age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
        this.age = age;
    }
    public void IntroduceMyself() {
        Console.WriteLine($"Hello, {firstName} {lastName}! I have {eyeColor} eyes and i am {age}");
    }
}
