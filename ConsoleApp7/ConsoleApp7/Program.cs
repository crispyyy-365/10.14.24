namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new("Huseyn", "Abbasov", "TK-99", 66);

            student1.GetInfo();
            student1.CheckGraduation();
            student1.GetDiplomDegree();

        }
    }
}
