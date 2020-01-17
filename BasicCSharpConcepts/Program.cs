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

            int daysInMonth = 30;
            string daysinString = daysInMonth.ToString();

            // .Net Fremework conversion methods

            daysInMonth.ToString();


           
            string isEligible = "0";

            int number = 1;

            // True / False or 1/0
            bool isavaille = Convert.ToBoolean(number);
             

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
           

            int totalMarks = 100;
            int obtainedMarks = 73;

            decimal percentage = Convert.ToDecimal(totalMarks * obtainedMarks / 32.60);
            Console.WriteLine(decimal.Round(percentage,3));
             

            // Identation

            int firstNumber = 10;
            int secondNumber = 20;

            if(firstNumber > secondNumber)
            {
                if(secondNumber == firstNumber)
                {
                    switch(firstNumber)
                    {
                        case 1:
                            Console.WriteLine(firstNumber);
                            Console.WriteLine(secondNumber);
                            Console.WriteLine("Sum of Two Numbers");
                            break;
                        case 2:
                            Console.WriteLine(secondNumber);
                            break;
                        default:
                            Console.WriteLine("Wrong Input");
                            break;
                    }
                }
                else
                {
                    
                }
            }

            */

            // Opeartors | Conditional Statements | Iterations | Debugging | Exceptional Handling | Try Catch
            // Concatenation | Format String | Operators | Order Presedence| Conditional Statements | Iterations | Debugging | Exceptional Handling | Try Catch

            // Operators
            // Logical Operators , Conditional Operators, Relational Operator, Arithmetic Operators, Increment / Decrement Operators
            // Logical Operators AND OR NOT  
            // AND && 
            // OR ||
            // NOT !

            // Conditional Operators | Ternary Operator
            //  short form of if statement bool iseligible = (age > 18) ? true :  false;

            // Relational Operators
            // Greater than | Less Than | 
            // > | < | >= | <= | ==(equality operator)
            // = Assignment Operator int marks = 10;
            // == Equality Operator  bool isEqual = (8 <= 9) ? true : false;
            // = or ==

            // + - * / % 26 % 5  26/5 = 

            // ++ increment -- decrement

            /*
            int number = 10;

            // ++number pre-increment | number++ post-increment
            Console.WriteLine(number++);

            Console.WriteLine(number);

   
            int secondNumber = 25;

            Console.WriteLine(secondNumber--);
            Console.WriteLine(secondNumber);

     */

            // Conditional Statement 
            // if statement | if else statement | if else if statement | nested if statement
            /*
              int firstNumber = 10;
              int secondNumber = 11;


              if(firstNumber > secondNumber)
                  Console.WriteLine("First Number is greater");
              else 
                  Console.WriteLine("Second Number is greater");

              // Logical Operators 

              int ali = 150;
              int taimoor = 350;
              int imran = 270;

              // Ali =1 done ? taimoor = 1? 

              // Find out First, second and third position holder
              if(ali > taimoor)
              {
                  if(ali > imran)
                  {
                      Console.WriteLine("Ali is at first position.");
                      if (taimoor > imran)
                      {
                          Console.WriteLine("Taimoor is at Second Position.");
                          Console.WriteLine("Imran is at Third Position.");
                      }
                      else
                      {
                          Console.WriteLine("Imran is at Second position.");
                          Console.WriteLine("Taimoor is at Third Position.");
                      }
                  }
              }
              else if(taimoor > ali)
              {
                  if(taimoor > imran)
                  {
                      Console.WriteLine("Taimoor is at First Position.");

                      if(imran > ali)
                      {
                          Console.WriteLine("Imran is at second position.");
                          Console.WriteLine("Ali is at third position.");
                      }
                      else
                      {
                          Console.WriteLine("Ali is at second position");
                          Console.WriteLine("Imran is at third position.");
                      }
                  }
              }
              else
              {
                  Console.WriteLine("Imran is at first position.");

                  if(taimoor > ali)
                  {
                      Console.WriteLine("Taimoor is at second position");
                      Console.WriteLine("Ali is at third position.");
                  }
                  else
                  {
                      Console.WriteLine("Ali is at second position");
                      Console.WriteLine("Taimoor is at third position.");
                  }
              }
              */


            // Switch -> Expressions

            string word = "e";

            // Check the given alphabet is vowel or not
            // vowel => aeiou

            /*
            if (word != "a" && word != "e" && word != "i" && word != "o" && word != "u")
            {
                Console.WriteLine("Given Word is not Vowel.");
            }

            

            switch (word)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Given word is vowel.");
                    break;

                default:
                    Console.WriteLine("Given word is not vowel.");
                    break;
            }
            

            int firstNumber = 10;
            int secondNumber = 20;

            decimal result = 0.0m;
           
            int opp = 1; // + - * / % 

            // int operator 1 = +, 2 = -, 3 = *......

            switch (opp)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    Console.WriteLine(result);
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    Console.WriteLine(result);
                    break;
                case 5:
                    result = firstNumber % secondNumber;
                    Console.WriteLine(result);
                    break;


                default:
                    break;
            }

            */



            // Opeartors | Conditional Statements | Iterations | Debugging | Exceptional Handling | Try Catch
            // Concatenation | Format String | Operators | Order Presedence| Conditional Statements | Iterations | Debugging | Exceptional Handling | Try Catch

            // Operators
            // Logical Operators , Conditional Operators, Relational Operator, Arithmetic Operators, Increment / Decrement Operators
            // Logical Operators AND OR NOT  
            // AND && 
            // OR ||
            // NOT !






            Console.ReadKey();
         }
    }
}
