namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Database would you prefer to use?");
            Console.WriteLine("Types are: List, SQL or Mongo?");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            db.LoadData();
            db.SaveData();

        }
    }
}
