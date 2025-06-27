using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthEvidenceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.ReadLine();
			}
        }

        private static void DoTask()
        {
            Console.WriteLine("7 ways to implement Task & Async\n");
            Console.WriteLine();
            Task.Factory.StartNew(() => { Console.WriteLine("1. Task using Factory Method\n"); } );
            Console.WriteLine();
            Task actionTask = new Task(new Action(TaskUsingAction));
            actionTask.Wait(1000);
            actionTask.Start();
            Console.WriteLine();
            Task delegateTask = new Task(delegate { TaskUsingDelegate(); });
            delegateTask.Wait(1000);
            delegateTask.Start();
            Console.WriteLine();
            Task lambdaNamed = new Task(() => TaskLambdaNamed());
            lambdaNamed.Wait(1000);
            lambdaNamed.Start();
            Console.WriteLine();
            Task lambdaAnnonimous = new Task(() => { LambdaAnnonymous(); });
            lambdaAnnonimous.Wait(1000);
            lambdaAnnonimous.Start();
            Console.WriteLine();
            CreateAsyncTask();
            Console.WriteLine();
            Console.WriteLine("Enter first number");
            int no1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int no2 = Convert.ToInt16(Console.ReadLine());
            CalculateNUmbers(no1, no2);
        }

        private async static void CalculateNUmbers(int no1, int no2)
        {
            int result =await Task.FromResult(Sum(no1, no2));
            await Task.Delay(1000);
            Console.WriteLine($"7. Result of Sum {no1}+{no2} = {result}");
        }

        private static int Sum(int no1, int no2)
        {
           return no1 + no2;
        }

        private async static void CreateAsyncTask()
        {
          await  Task.Run(() => CreateAsyncWithAwait());
        }

        private static void CreateAsyncWithAwait()
        {
            Console.WriteLine("6. Task async and await.");
        }

        private static void LambdaAnnonymous()
        {
            Console.WriteLine("5. Task using Lambda Annonimous method\n.");
        }

        private static void TaskLambdaNamed()
        {
            Console.WriteLine("4. Task using Lambda named method.");
        }

        private static void TaskUsingDelegate()
        {
            Console.WriteLine("3. Task using delegate.");
        }

        private static void TaskUsingAction()
        {
            Console.WriteLine("2. Task using Action.");
        }
    }
}
