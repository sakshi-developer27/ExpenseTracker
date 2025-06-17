namespace ExpenseTracker.Constants
{
    public static class ResponseMessage
    {
        public const string NameRequired = "Name is required.";
        public const string NameTooLong = "Name must not exceed 100 characters.";
        public const string EmailRequired = "Email is required.";
        public const string InvalidEmailFormat = "Please enter a valid email address.";
        public const string EmailTooLong = "Email must not exceed 100 characters.";
        public const string PasswordRequired = "Password is required.";
        public const string InvalidPasswordFormat =
            "Password must be at least 8 characters long and include at least one letter, one number, and one special character.";
    }
}
