using MongoDB.Bson;
using System.Text;
using udemy_1.Classes;
using udemy_1.DataModels;

namespace UdemyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation to perform on the database:");
            Console.WriteLine("Type \'C (or c)\' to create a document");
            Console.WriteLine("Type \'R (or r)\' to display all of the documents");
            Console.WriteLine("Type \'U (or u)\' to update a document");
            Console.WriteLine("Type \'D (or d)\' to delete a document");

            var userChosenOperation = Convert.ToChar(Console.ReadLine());
            var toLowerInput = Char.ToLower(userChosenOperation);

            switch (toLowerInput)
            {
                case 'c':
                    Console.WriteLine("Create operation:");

                    Console.WriteLine("Please enter name for the new user:");
                    var userInputName = Console.ReadLine();
                    Console.WriteLine("Please enter age for the new user:");
                    var userInputAge = Console.ReadLine();
                    Console.WriteLine("Please enter password for the new user:");
                    var userInputPassword = Console.ReadLine();

                    var newUserInfo = new User(userInputName, Convert.ToInt32(userInputAge), userInputPassword);

                    Console.WriteLine(CrudOperations.InsertUserMethod(newUserInfo));

                    break;
                case 'r':
                    Console.WriteLine("Read operation:");

                    Console.WriteLine("Following documents are a part of the chosen collection:");

                    var funcReturn = CrudOperations.ReadAllDocuments();

                    var goodString = new StringBuilder();
                    var spaceString = new StringBuilder();
                    spaceString.Append(' ', 7);
                    goodString.Append('-', 50);
                    goodString.Append("\n");
                    goodString.Append("Name");
                    goodString.Append(' ', 10);
                    goodString.Append("Age");
                    goodString.Append(' ', 10);
                    goodString.Append("Password");
                    goodString.Append("\n");
                    goodString.Append('-', 50);



                    Console.WriteLine(goodString);
                    foreach (BsonDocument doc in funcReturn)
                    {
                        Console.WriteLine(String.Format("{0} {3} {1} {4} {2}", doc[1], doc[2], doc[3], spaceString, spaceString));
                    }

                    break;
                case 'u':
                    Console.WriteLine("Update operation:");

                    Console.WriteLine("Choose which document to update:");

                    break;
                case 'd':
                    Console.WriteLine("Delete operation");

                    Console.WriteLine("Choose which document to delete:");

                    break;
                default:
                    Console.WriteLine("None of the operations were chosen correctly! Try again.");
                    break;
            }


        }
    }
}