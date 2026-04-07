namespace Questionnaire 
{
    public class System 
    {
        public static void Main() 
        {
            Console.ForegroundColor = ConsoleColor.Green;

            
            string name, city_of_birth, day_input, month_input, year;
            int day, month;

            #region NameInputs

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            while (name == "") 
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

            }

            #endregion 


            #region DayInputs

            Console.Write("Enter the day of your birhtday: ");
            day_input = Console.ReadLine();

            while (!int.TryParse(day_input, out day))
            {
                Console.Write("Please enter a valid number:");
                day_input = Console.ReadLine();
            }

            #endregion

            #region MonthInput

            Console.Write("Enter the number of the month of your birth ex:(February = 02):\n");
            month_input = Console.ReadLine();

            while (!int.TryParse(month_input, out month)) 
            {
                Console.Write("Please enter a valid number:");
                month_input = Console.ReadLine();
            }
            

            #endregion

        }
    }


    //Date of birth(age)
    //City of birth
    
    



}