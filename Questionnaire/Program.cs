namespace Questionnaire 
{
    public class System 
    {
        public static void Main() 
        {
            Console.ForegroundColor = ConsoleColor.Green;

            
            string name, city_of_birth, day_input, month, year;
            int day;

            #region NameInputs

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            while (name == "") 
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

            }

            #endregion 


            #region AgeInputs

            Console.Write("Enter the day of your birhtday: ");
            day_input = Console.ReadLine();

            while (!int.TryParse(day_input, out day))
            {
                Console.Write("Please enter a valid number:");
                day_input = Console.ReadLine();
            }

            #endregion


        }
    }


    //name
    //Date of birth(age)
    //City of birth
    
    



}