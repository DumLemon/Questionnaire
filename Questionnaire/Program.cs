namespace Questionnaire 
{
    public class System 
    {
        public static void Main() 
        {
            Console.ForegroundColor = ConsoleColor.Green;

            
            string name, city_of_birth;

            int day, month, year;


            #region NameInputs

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            while (name == "") 
            {
                Console.Write("Enter your name:");
                name = Console.ReadLine();

            }
            
            #endregion






        }
    }


    //name
    //Date of birth(age)
    //City of birth
    
    



}