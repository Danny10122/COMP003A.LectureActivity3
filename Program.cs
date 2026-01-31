namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Section A
            Console.WriteLine("SECTION A - Academic Term Identification");
            Console.Write("Current Month: ");
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

            //Section B
            Console.WriteLine("\nSECTION B - Campus Access Check");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Are you currently enrolled? (yes/no): ");
            string input1 = Console.ReadLine();
            bool isEnrolled = true;
            
            Console.Write("Do you have a valid student ID? (yes/no): ");
            string input2 = Console.ReadLine();
            bool hasStudentId = true;

            if (age >= 18)
            {
                if (isEnrolled || hasStudentId)
                {
                    Console.WriteLine("Campus Access Granted");
                }
            }
            else if(age <= 17)
            {
                Console.WriteLine("Campus Access Denied");
            }

            //Section C
            Console.WriteLine("\nSECTION C - Semester Code Lookup");
            Console.Write("Enter a semester code (SP, SU, FA): ");
            string semesterCode = Console.ReadLine();

            switch (semesterCode)
            {
                case "SP":
                    Console.WriteLine("Spring");
                    break;
                case "SU":
                    Console.WriteLine("Summer");
                    break;
                case "FA":
                    Console.WriteLine("Fall");
                    break;
                default:
                    Console.WriteLine("Invalid semester code");
                    break;

            }
        }
    }
}
