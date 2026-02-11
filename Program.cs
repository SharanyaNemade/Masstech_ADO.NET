using System;

namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpRepo repo = new EmpRepo();

            int choice;

            while (true)
            {
                Console.WriteLine("Enter Choice: \n1:Add Emp\n2:Fetch Emp\n3:Exit");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    repo.AddEmp();
                }
                else if (choice == 2)
                {
                    repo.FetchEmp();
                }
                else
                {
                    break;
                }
            }

        }
    }
}
