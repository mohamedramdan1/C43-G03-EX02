using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(1, "C#");
            sub.CreateExam();
            Console.Clear();

            char Char;
            do
            {
                Console.WriteLine("Do you want to  Start Exam (Y | N)");

            } while (!(char.TryParse(Console.ReadLine(), out Char) && (Char == 'y' || Char == 'n')));

            if (Char == 'y')
            {
                Console.Clear();
                Stopwatch sw = new  Stopwatch();
                sw.Start();
                sub?.Exam?.ShowExam();
                sw.Stop();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");

            }
            Console.WriteLine("Thank you Best wishes");

        }
    }
}
 