namespace ClassesTesting
{
    class Teacher : User,IUserInterface
    {
        string PhoneNumber{ get; set; }
        string  Email{ get; set; }
        public Teacher(string firstName, string lastName, string? middleName, string phoneNumber, string email)
        : base(firstName, lastName, middleName)
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override void PrintUserDetails()
        {
            string teacherInitial = GetInitial();
            string teacherFullName = $"{LastName.ToUpper()} {FirstName} {teacherInitial}";

            string teacherDetails = $"""
        ======TEACHER INFORMATION=====
        Fullname: {teacherFullName}
        PhoneNumber: {PhoneNumber}
        Email Address: {Email}
        """;
            Console.WriteLine(teacherDetails);
        }

    }
}