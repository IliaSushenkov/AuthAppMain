namespace WpfApp1
{
    public class User
    {
        public int id { get; set; }

        private string login, pass, email;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public User(string login, string pass, string email)
        {
            this.login = login;
            this.email = email;
            this.pass = pass;
        }

        public User() { }
    }
}
