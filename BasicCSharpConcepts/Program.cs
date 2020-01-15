using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Variables and Data Types
            // How to declare variables

            // DataType NameOfVariable; 
            int firstNumber;

            // Variable Initialization
            firstNumber = 10;

            // Case Sensitive
            // Raouf != rAouf
            // a != A

            byte smallNumber;
            int largeNumber;
            float monthlyFee;
            decimal salary;
            bool isMarried;
            string userName;
            

            // Variable Intialization
            smallNumber = 40;
            largeNumber = 20000;
            monthlyFee = 750.65f;
            salary = 15700.55m; // Money  // decimal
            isMarried = false;
            userName = "Muhammad Ahmed";



            // -> Rules of naming variables C#
            // -> No blank space in variable names int first number = 10;
            // -> does not start with digit or special symbol
            // -> You can use _ as startup character
            // -> Always use usefull names for your variable
            // -> We cannot use the reserve words as a variable name // if else int string decimal 


            // How to write variable names | Conventions
            // Camel Case | Pascal Case | Hungrian Notation
            // Camel Case 
            // should be start with small letter, then every next word will be start from capital letter
            string firstName;
            string lastName;
            DateTime age;

            // Pascal   FirstNumber FirstName LastName Gender 

            // Variable = camel case 
            // constant = pascal case

            // Value of variables varies/change on runtime
            decimal annualFee = 300.00m;

            annualFee = 450.00m;

            // Constant -> Remains same throughout the program
            const decimal Ratio = 2.3m;


            // Comments
            // 1) Single Line Comment 2) Double Line Comment

            // This is a single line comment

            /*
                This is 
                a 
                multi line
                comment
            

            // variable declartion
            int _firstNumber;
            int _secondNumber;

            // Variable Initialization
            _firstNumber = 10;
            _secondNumber = 20;

            // Calculation
            Console.WriteLine(_firstNumber + _secondNumber);

            // Opeartors | Conditional Statements | Iterations | Debugging | Exceptional Handling | Try Catch

            int daysInMonth = 30;
            string daysinString = daysInMonth.ToString();

            // .Net Fremework conversion methods

            daysInMonth.ToString();


           
            string isEligible = "0";

            int number = 1;

            // True / False or 1/0
            bool isavaille = Convert.ToBoolean(number);
             */




            /*

            if(isavaille)
                Console.WriteLine(isavaille);
            else
                Console.WriteLine(isavaille);

            
            string userInput = "Raouf";
            string user2Input = "6";

            int number1;
            int number2;

            int result;

            if (int.TryParse(userInput, out number1) && int.TryParse(user2Input, out number2))
            {
                result = number1 + number2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Conversion Failed.");
            }
            */




            int totalMarks = 100;
            int obtainedMarks = 73;

            decimal percentage = Convert.ToDecimal(totalMarks * obtainedMarks / 32.60);


            Console.WriteLine(decimal.Round(percentage,3));



            Console.ReadKey();
         }
    }
}
