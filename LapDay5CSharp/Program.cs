namespace LapDay5CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ZOO 
            //Zoo zoo = new Zoo();

            //zoo.AddAnimal(new Lion());
            //zoo.AddAnimal(new Sparrow());
            //zoo.AddAnimal(new Elephant());
            //zoo.AddAnimal(new Pigeon());

            //Console.WriteLine("Mammals:");
            //foreach (Animal item in zoo.Mammals)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("Birds:");
            //foreach (Animal item in zoo.Birds)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("All Animals:");
            //foreach (Animal item in zoo.Animals)
            //{
            //    Console.WriteLine(item);
            //}

            // Die Animal
            //zoo.RemoveAnimal(zoo.Mammals[0]);


            //Console.WriteLine("New Mammals:");
            //foreach (Animal item in zoo.Mammals)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region PhoneBook  Example (Indexer)
            //PhoneBook phoneBook = new PhoneBook();
            //phoneBook["Mohamed"] = 1234;
            //phoneBook[123456] = "Mariam";
            //phoneBook["Noah"] = 789;
            //phoneBook["Noah"] = 1111;

            //Console.WriteLine(phoneBook["Mohamed"]); // 1234
            //Console.WriteLine(phoneBook[123456]); // Mariam
            //Console.WriteLine(phoneBook["Noah"]); // 789 

            //phoneBook.RemoveEntryByPhoneNumber(123456);

            //Console.WriteLine(phoneBook[123456]); // throw Exception not Found key
            #endregion


            #region PhoneBookEntries

            //PhoneBookEntries entries = new PhoneBookEntries();
            //entries.AddEntry("Mohamed" , 01000);
            //entries.AddEntry("Ali" , 01111);
            //entries.AddEntry("Noah" , 01222);
             

            //foreach (KeyValuePair<string , int> item in entries.Entries)
            //{
            //    Console.WriteLine($"Name => {item.Key}\t Phone => {item.Value}");
            //}

            //Console.WriteLine("*************");
            //entries.RemoveEntry("Noah");


            //foreach (KeyValuePair<string, int> item in entries.Entries)
            //{
            //    Console.WriteLine($"Name => {item.Key}\t Phone => {item.Value}");
            //}
            #endregion



        }
    }
}
