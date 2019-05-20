using System;

namespace EmployeeIndexer
{
    class Employee
    {
        private string lastName;
        private string firstName;
        private string cityOfBirth;

        // 对索引器进行定义
        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        lastName = value;
                        break;
                    case 1:
                        firstName = value;
                        break;
                    case 2:
                        cityOfBirth = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                switch (index)
                {
                    case 0: return lastName;
                    case 1: return firstName;
                    case 2: return cityOfBirth;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
    class EmployeeIndexer
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1[0] = "Gates";
            emp1[1] = "Bill";
            emp1[2] = "1988/12/21";

            Console.WriteLine("{0} {1} was born in {2}", emp1[1], emp1[0], emp1[2]);

            Console.ReadLine();
        }
    }
}
