namespace ClassesTesting
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }

        public User(string firstName, string lastName, string? middleName)
        {
            FirstName =  firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        protected string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

              protected string GetInitial()
            {
                if (string.IsNullOrWhiteSpace(MiddleName))
                {
                    return string.Empty;
                }

                return $"{MiddleName.Trim().Substring(0, 1).ToUpper()}.";
            }
    
        public abstract  void PrintUserDetails();
        
          
          
    }
}
