using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i = i + 1)
            {
                // call the Fizzbuzz function
                Fizzbuzz(i);
            }

            for (int j = 79; j >= 92; j = j - 1)
            {
                //call the Fizzbizz function
                Fizzbuzz(j);
            }

            Yodaizer("I like code");
            TextStats("This weekend weekend we are celebrating Labor Day. Our family took a vacation to South Dakota. It was nice to get away for awhile.");
            DashInsert(8675309);

            //keep window open
            Console.ReadKey();

        }
        //Challenge number 2
        static void Fizzbuzz(int number)
        {
            //If number is divisible by 5 and 3 then print fizzbuzz
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            //If number is divisible by 5 print fizz
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //If number is divisible by 3 print buzz 
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //If not divisible by either 5 or 3 then print out the number
            else
            {
                Console.WriteLine(number);
            }
        }



        //challenge number 3

        static void Yodaizer(string text)
        {
            //make the string into a list
            List<string> List = text.Split(' ').ToList();

            //take the string and make it so it prints out in reverse
            for (int i = List.Count - 1; i >= 0; i = i - 1)
            {
                Console.WriteLine(List[i]);
            }
        }


        // challenge number 4

        static void TextStats(string input)
        {
            //Count the number of characters
            int k = 0;
            string letter = input[k].ToString();

            Console.WriteLine(input.Length);


            //Count the number of words

            string textStats = input.Split(new char[] { ' ' }).Length.ToString();

            Console.WriteLine(input.Split(new char[] { ' ' }).Length.ToString());


            //Count the number of vowels and consonants in the loop


            int numVowels = 0;
            int numCons = 0;
            int numSpecial = 0;

            //find wheather its vowel or consonants or special character
            for (int i = 0; i < input.Length; i = i + 1)
            {
                string letter = input.ToString();
                //find vowels
                if ("aeiou".Contains(input.ToLower()))
                {
                    numVowels + 1;
                }
                //find periods and spaces
                else if (" .".Contains(letter))
                {
                    numSpecial + 1;
                }
                // if it isnt a vowel or special character then its a consonant
                else
                {
                    numCons + 1;
                }
            }
            Console.WriteLine("number of vowels:" + numVowels);
            Console.WriteLine("number of special characters:" + numSpecial);
            Console.WriteLine("number of consonants:" + numCons);

        }
    }

    //Challenge number 5
       
    static void IsPrime(int number)
        {
            //check number 1 - 25 to see which once are prime and which aren't
            bool prime = true;
            for (int i = 2; i < number; i = i + 1)
            {
                if (number % i == 0)
                {
                    //if it is divisible by a number,then it is not a prime
                    prime = false;
                    
                    //end loop
                    break;
                }
              }

            //write output to console
            if (prime)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number);
            }
      }

       
    //Challenge number 6
        
    static void DashInsert(int number)
        {
            string letter = number.ToString();
            //declare a new string
            string output = " ";
            string newString = number.ToString();
            
            for (int i = 0; i <= newString.Length - 2; i = i + 1)
            {
                //get first and second number (index[0] and index[1])
                string numString1 = newString[i].ToString();
                string numString2 = newString[i + 1].ToString();

                //change the integers to strings
                int num1 = int.Parse(numString1);
                int num2 = int.Parse(numString2);

                //see if both numbers are odd or not 
                if (num1 % 2 != 0 && num2 % 2 != 0)
                {
                    //if both are odd then add them to the output with a dash between them
                    output = output + num1 + " - ";
                }
                else
                {
                    //if they aren't both odd then just add the number to the output
                    output = output + num1;
                }
            }

            //add last number
            output = output + newString.index[6];

            //print output
            Console.WriteLine(output);
        }
    }
}




    



   
