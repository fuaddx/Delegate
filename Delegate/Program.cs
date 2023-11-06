using Delegate.Models;
using System.Drawing;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> list = new List<Exam>();

            do
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Surnamez:");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter score");
                byte point = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Subject: ");
                string subject = Console.ReadLine();
                Console.WriteLine("Enter Start Date of Exam (Hours/Minutes):");
                DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
                Console.WriteLine("Enter End Date of Exam (Hours/Minutes):");
                DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
                list.Add(new Exam
                {
                    Student = new Student { Name = name, Surname = surname, Age = age },
                    Point = point,
                    Subject = subject,
                    StartTime = startDate,
                    EndTime = endDate
                });

                // show exam more than 50 score
                var score = list.FindAll(exam => exam.Point > 50);

                // show 1 week ago exams
                var oneWeekAgo = DateTime.Now - TimeSpan.FromDays(7);
                var recentWeekExams = list.FindAll(exam => exam.EndTime.Date >= oneWeekAgo.Date);

                // show exam more than 1 hours
                var durationExams = list.FindAll(exam => exam.Duration > 1);


                Console.WriteLine("Exams points more than 50");
                foreach (var exam in score)
                {
                       Console.WriteLine(exam.ToString());
                }
                Console.WriteLine(" Exams in  Last one week");
                foreach (var exam in recentWeekExams)
                {
                    Console.WriteLine(exam.ToString());
                }
                Console.WriteLine("Exams more  than 1 hour");
                foreach (var exam in durationExams)
                {
                    Console.WriteLine(exam.ToString());
                }
            } while (true);
            
        }
    }
}