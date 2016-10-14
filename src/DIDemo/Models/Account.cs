namespace DIDemo.Models
{
    public class Account
    {
        public Account(string _email, string _password)
        {
            email = _email;
            password = _password;
        }
        public string email { get; set; }
        public string password { get; set; }
    }
}