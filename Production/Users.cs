namespace Production
{
    class Users
    {
        public string Login { get; }
        public string Password { get; }
        public Users(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public bool CheckUser()
        {
            return DBAuth.ValidUser(Login, Password);
        }
    }
}
