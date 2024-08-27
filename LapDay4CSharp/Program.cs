namespace LapDay4CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Point Sort Array
            Console.WriteLine("\n\nPoint Sort Array");
            Point3D[] points = new Point3D[]
                {
                new Point3D(),
                new Point3D(60),
                new Point3D(40,50),
                new Point3D(10,20,30)
                };

            Array.Sort(points);

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"{points[i].GetType().Name} {points[i]}");
            }
            #endregion


            #region IPayable =>  Employee , Trainee
            Console.WriteLine("\n\nIPayable");
            Employee employee = new Employee(1020, 5000m, "Mohamed", 27);
            Trainee trainee = new Trainee(1020, "11ABS", "Mohamed", 27, 1000);

            IPayable[] payables = new IPayable[2]
            {
                employee,
                trainee,
            };


            for (int i = 0; i < payables.Length; i++)
            {
                payables[i].ShowPayment();
            } 
            #endregion


            #region ICloneable
            Console.WriteLine("\n\nICloneable");

            Trainee clone = (Trainee)trainee.Clone();

            Console.WriteLine($"Trainee Clone {clone}");
            #endregion


            #region CompareTo Sort String Is Employees

            Console.WriteLine($"\n\nCompareTo Sort String Is Employees");
            Employee[] employees = new Employee[]
                {
                new Employee(10 , 5000,"Mohamed" , 27),
                new Employee(11 , 6000,"Ahmed" , 28),
                new Employee(12 , 7000,"Emad" , 29),
                };

            Array.Sort(employees);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
            #endregion


            #region Custom Comparer
            Console.WriteLine($"\n\nCustom Comparer");
            Trainee[] Trainees = new Trainee[]
                {
                new Trainee(18 , "11Abc","Mohamed" , 27 , 5000),
                new Trainee(11 , "22CD","Ahmed" , 28 , 2000),
                new Trainee(12 , "33FG","Emad" , 29 , 3000),
                };


            Array.Sort(Trainees, new CustomComparerOnClassTrainee()); // Sort the array using the custom comparer

            foreach (Trainee Trainee in Trainees)
            {
                Console.WriteLine(Trainee);
            }
            #endregion


            //PhoneBook phoneBook = new PhoneBook();
            //phoneBook[123] = "Ali";
            //phoneBook["Hosam"] = 456;

            //int phone = phoneBook["Ali"];
            //string name = phoneBook[123];

            //Console.WriteLine($"Phone number for Ali: {phone}");
            //Console.WriteLine($"Name for phone number 123: {name}");
        }
    }
}
