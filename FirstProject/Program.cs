public class Program
{
    public class People
    {
        public string Name { get; set; }
        public People(string name) {
            this.Name = name;
        }
        public override string ToString()
        {
            return "Hello! THis is " + Name;
        }
    }
    public static void Main(string[] args)
    {
        int total = 3;
        People[] peoples = new People[total];
        for(int i=0; i<total; i++)
        {
            peoples[i] = new People(Console.ReadLine());
        }
        for(int i=0; i<total;i++)
        {
            Console.WriteLine(peoples[i].ToString());
        }
    }
}