namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECTION A - Academic Term Identification");
            int currentMonth = int.Parse(Console.ReadLine());

            if (currentMonth >= 1 && currentMonth <= 5)
            {
                Console.WriteLine("Spring Term");
            }
            else if (currentMonth >= 6 && currentMonth <= 7)
            {
                Console.WriteLine("Summer term");
            }
            else
            {
                Console.WriteLine("Fall Term");
            }

            Console.WriteLine("\nSECTION B - Campus Access Check");

            Console.WriteLine("SECTION C - Semester Code Lookup");

        }
    }
}
