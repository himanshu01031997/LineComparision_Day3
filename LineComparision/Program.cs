namespace LineComparision
{
    public static class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("welcome to line comparision Problem");
            Comparision comparision = new Comparision();
            comparision.value(3, 5, 8, 7);
            comparision.calculate();
        }
    }
}