namespace Questionnaire
{
    public class System
    {
        public static void Main()
        {

            string name_input, city_of_birth, day_input, month_input, year_input, city_input, country_input;
            int day, month, year;

            #region NameInputs

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your name: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            name_input = Console.ReadLine();

            while (name_input == "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter your name: ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                name_input = Console.ReadLine();

            }

            #endregion 

            #region DayInputs

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the day of your birthday: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            day_input = Console.ReadLine();

            
            while (!int.TryParse(day_input, out day))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Please enter a valid number:");

                Console.ForegroundColor = ConsoleColor.Cyan;
                day_input = Console.ReadLine();
            }

            #endregion

            #region MonthInput

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the number of the month of your birth (ex:February = 02): ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            month_input = Console.ReadLine();

            
            while (!int.TryParse(month_input, out month))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Please enter a valid number:");

                Console.ForegroundColor = ConsoleColor.Cyan;
                month_input = Console.ReadLine();
            }


            #endregion

            #region YearInput

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your birth year:");

            Console.ForegroundColor = ConsoleColor.Cyan;
            year_input = Console.ReadLine();

            while (!int.TryParse(year_input, out year))
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.Write("Enter a valid birth year:");

                Console.ForegroundColor = ConsoleColor.Cyan;
                year_input = Console.ReadLine();
            }



            #endregion

            #region CountryInput

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your country:");

            Console.ForegroundColor = ConsoleColor.Cyan;
            country_input = Console.ReadLine();


            while (country_input == "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter a valid country:");

                Console.ForegroundColor = ConsoleColor.Cyan;
                country_input = Console.ReadLine();
            }

            #endregion

            #region CityInput

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your city:");

            Console.ForegroundColor = ConsoleColor.Cyan;
            city_input = Console.ReadLine();

            
            while (city_input == "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Please enter a valid city:");

                Console.ForegroundColor = ConsoleColor.Cyan;
                city_input = Console.ReadLine();
            }


            #endregion

            #region ShowingTheInputs

            Console.WriteLine("\n\nPlease confirm your details:\n");
            Console.Write("Name: " + name_input + "\n" +
                          "Birthday: " + day + "." + month_input + "." + year_input + "\n" +
                          "City: " + city_input + ", " + country_input + "\n\n\n");

            #endregion

        }
    }
    
    
    //criar uma lista de numeros para dias de 1 - 30
    //Criar uma lista de meses de 1 - 12
    //Criar  uma lista de anos 1900 - 2026



}