namespace MyLib
{
    public class User
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public User() : this("Anonim", 0) { }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public void Move()
        {
            Console.WriteLine("User move");
        }
    }
}