namespace WpfApp1
{
    public class Client
    {
        public int id { get; set; }

        private string fullname, age, city, salary, email;

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Client(string fullname, string age, string city, string salary, string email)
        {
            this.fullname = fullname;
            this.age = age;
            this.city = city;
            this.salary = salary;
            this.email = email;
        }

        public Client() { }
    }
}
