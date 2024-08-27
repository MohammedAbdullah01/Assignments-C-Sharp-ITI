namespace LapDay2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question => 1
            //Employee employee = new Employee("Mohamed", 5000, Role.Admin);

            //employee.AssignRole(Role.Accountant);

            //employee.Display();


            //Console.WriteLine(employee.Role);
            //Console.WriteLine(employee.HasRole(Role.Stock)); // false 
            //Console.WriteLine(employee.HasRole(Role.Admin)); // true
            //Console.WriteLine(employee.HasRole(Role.Accountant)); // true  
            #endregion


            #region Question => 2 

            //Point3D point1 = new Point3D { X = 15 , Y = 10 , Z = 20};
            //Point3D point2 = new Point3D { X = 15, Y = 10, Z = 20 };

            //if(point1 == point2)
            //{
            //    Console.WriteLine($"point1 == point2");
            //}

            //point1.Display();
            //point2.Display();

            //point1.ChangeCoordinates(10, 10, 10);

            //point1.Display();

            //if (point1 != point2)
            //{
            //    Console.WriteLine($"point1 Not Equal point2");
            //}
            #endregion


            #region Question => 3 

            //Console.WriteLine("Enter Please String:");
            //string input = Console.ReadLine() ?? "";

            //EnterString(input);

            //Console.WriteLine($"Change string : \n {input}"); // The value does not change because she is sent By Value

            #endregion
        }

        #region Function => Question => 3 
        static void EnterString(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"original string : \n {input}");

                input = "Mohamed";
            }
        } 
        #endregion
    }
}
