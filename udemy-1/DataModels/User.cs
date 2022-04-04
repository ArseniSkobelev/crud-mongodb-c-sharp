namespace udemy_1.DataModels
{
    public class User
    {
        public User(string name, int age, string password)
        {
            this.name = name;
            this.age = age;
            this.password = password;
        }

        public string name { get; set; }
        public int age { get; set; }
        public string password { get; set; }
    }
}
