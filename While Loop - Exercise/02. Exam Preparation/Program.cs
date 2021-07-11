using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryGrades = int.Parse(Console.ReadLine());

            int numOfUnsatisfactoryGrades = 0;
            int numOfSolvedExercise = 0;
            double sumOfAllGrades = 0.0;
            string lastTask = "";
            bool isValid = true;

            while (numOfUnsatisfactoryGrades < unsatisfactoryGrades)
            {
                string tasks = Console.ReadLine();
                if (tasks == "Enough")
                {
                    isValid = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numOfUnsatisfactoryGrades++;
                }
                sumOfAllGrades += grade;
                numOfSolvedExercise++;
                lastTask = tasks;
            }
            if (isValid)
            {
                Console.WriteLine($"You need a break, {numOfUnsatisfactoryGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumOfAllGrades / numOfSolvedExercise:F2}");
                Console.WriteLine($"Number of problems: {numOfSolvedExercise}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
