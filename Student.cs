namespace ClassesTesting;

class Student : User,IUserInterface
{
    int age;
    string  gender;


    public Student(string firstName, string lastName, string? middleName, int age, string gender)
         : base(firstName, lastName, middleName)
    {

        this.age = age;
        this.gender = gender;
    }

    public override void PrintUserDetails()
    {
        string nameInitial = GetInitial();
        string fullName = $"{LastName.ToUpper()} {FirstName} {nameInitial}";
        

        string studentDetails = $"""
        ======STUDENT INFORMATION======
        Fullname: {fullName}
        Age:{age}
        Gender: {gender}
        """;
        Console.WriteLine(studentDetails);
    }

}