using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class PasswordCheck
    {
        public static int GetCapitalLetter(string input) 
        {
            int capitalLetter = 0; // To hold the number of capital letters in the password.

            foreach (char letter in input) 
            {
                if (char.IsUpper(letter)) 
                {
                    capitalLetter++;
                }
                
            }
            return capitalLetter;
        }

        public static int GetLowerCaseLetter(string input) 
        {
            int lowerCaseLetter = 0; // To hold the number of lowercase letters in the password.

            foreach (char letter in input) 
            {
                if (char.IsLower(letter)) 
                {
                    lowerCaseLetter++;
                }
            }
            return lowerCaseLetter;
        }

        public static int GetNumbers(string input) 
        {
            int numbers = 0; // To hold the amount of numbers in the password. 

            foreach (char letter in input) 
            {
                if (char.IsDigit(letter)) 
                {
                    numbers++;
                }
            }
            return numbers;
        }

        public static int GetSpecialCharacter(string input) 
        {
            int punctuation = 0; // To hold the number of punctuations in the password.

            foreach (char letter in input) 
            {
                if (char.IsPunctuation(letter)) 
                {
                    punctuation++;
                }
            }
            return punctuation;
        }

        public static string CheckPassword(string input) 
        {
            string correct = "valid";
            string incorrect = "invalid";

            const int BASE_LENGTH = 8;
            const int MAX_LENGTH = 15;


            if (input.Length >= BASE_LENGTH &&
                input.Length <= MAX_LENGTH &&
                GetCapitalLetter(input) >= 1 &&
                GetLowerCaseLetter(input) >= 1 &&
                GetNumbers(input) >= 1 &&
                GetSpecialCharacter(input) >= 1)
            {
                return correct;
            }
            else
            {
                return incorrect;
            }
        }
    }
}
