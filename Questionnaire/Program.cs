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
                Console.Write("Enter your name: ");
                name_input = Console.ReadLine();

            }

            #endregion 

            #region DayInputs

            Console.Write("Enter the day of your birthday: ");
            day_input = Console.ReadLine();

            while (!int.TryParse(day_input, out day))
            {
                Console.Write("Please enter a valid number:");
                day_input = Console.ReadLine();
            }

            #endregion

            #region MonthInput

            Console.Write("Enter the number of the month of your birth (ex:February = 02): ");
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

            #region CountryInput

            Console.Write("Enter your country:");
            country_input = Console.ReadLine();

            while (country_input == "")
            {
                Console.WriteLine("Enter a valid country:");
                country_input = Console.ReadLine();
            }

            #endregion

            #region CityInput

            Console.Write("Enter your city:");
            city_input = Console.ReadLine();

            while (city_input == "")
            {
                Console.Write("Please enter a valid city:");
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