using System;
using System.Threading.Tasks;

namespace StudentDashboardAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("===== Student Dashboard System =====");

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks (%): ");
            int marks = int.Parse(Console.ReadLine());

            Console.Write("Enter Attendance (%): ");
            int attendance = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLoading data... Please wait...\n");

            try
            {
                var studentTask = GetStudentDetailsAsync(name);
                var marksTask = GetMarksAsync(marks);
                var attendanceTask = GetAttendanceAsync(attendance);

                await Task.WhenAll(studentTask, marksTask, attendanceTask);

                Console.WriteLine("\n===== Dashboard Result =====");
                Console.WriteLine(studentTask.Result);
                Console.WriteLine(marksTask.Result);
                Console.WriteLine(attendanceTask.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        }

        static async Task<string> GetStudentDetailsAsync(string name)
        {
            await Task.Delay(2000);
            return $"Student Name: {name}";
        }

        static async Task<string> GetMarksAsync(int marks)
        {
            await Task.Delay(2000);
            return $"Marks: {marks}%";
        }

        static async Task<string> GetAttendanceAsync(int attendance)
        {
            await Task.Delay(2000);
            return $"Attendance: {attendance}%";
        }
    }
}