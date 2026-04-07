namespace Questionnaire 
{
    public class System 
    {
        public static void Main() 
        {
            Console.ForegroundColor = ConsoleColor.Green;

            
            string name_input, city_of_birth, day_input, month_input, year_input, city_input;
            int day, month, year;

            #region NameInputs

            Console.Write("Enter your name: ");
            name_input = Console.ReadLine();

            while (name_input == "") 
            {
                Console.Write("Enter your name: ");
                name_input = Console.ReadLine();

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

            #region YearInput
            
            Console.Write("Enter your birth year:");
            year_input = Console.ReadLine();

            while (!int.TryParse(year_input, out year)) 
            {
                Console.Write("Enter a valid birth year:");
                year_input = Console.ReadLine();
            }



            #endregion

            #region CityInput

            Console.Write("Enter the city where you were born:");
            city_input = Console.ReadLine();

            while (city_input == "") 
            {
                Console.Write("Enter a valid city:");
                city_input = Console.ReadLine();
            }



            #endregion

        }
    }


    //Date of birth(age)
    //City of birth
    
    



}