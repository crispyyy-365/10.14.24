namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student ("Huseyn", "Abbasov", "TK-99", 66);

            student1.GetInfo(student1.Name,student1.Surname,student1.Group,student1.Point);

            student1.CheckGraduation(student1.IsGraduated);

            student1.GetDiplomDegree(student1.Point);
        }
    }
}
