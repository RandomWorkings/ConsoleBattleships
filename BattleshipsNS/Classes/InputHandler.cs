using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class InputHandler : IInputHandler
    {
        private char[] AcceptedCharacters;
        private int[] AcceptedIntegers;
        private int BoardSize;

        public InputHandler(int boardSize)
        {
            BoardSize = boardSize;
            
            AcceptedCharacters = new char[BoardSize];
            SetAcceptedCharacters();

            AcceptedIntegers = new int[BoardSize];
            SetAcceptedIntegers();
        }

        public string GetUserInput()
        {
            Console.WriteLine("Enter Target Grid Space example: 'A1'");
            string userInput = Console.ReadLine();
            Console.WriteLine("Target is: " + userInput);
            Console.WriteLine();
            return userInput;
        }

        public int ValidateInput(string userInput)
        {
            char inputCharacter = CollectInputCharacter(userInput);
            int inputInteger = CollectInputInteger(userInput);

            //Input Checks
            int characterCheck = CheckValidCharacter(inputCharacter);
            int integerCheck = CheckValidInteger(inputInteger);

            return characterCheck + integerCheck;
        }

        public (int, int) ConvertInputToTuple(string userInput)
        {
            char inputCharacter = CollectInputCharacter(userInput);
            int inputInteger = CollectInputInteger(userInput);

            int column = Convert.ToInt32(inputCharacter) - 1;
            int row = inputInteger - 1;

            return (row, column);
        }

        private void SetAcceptedCharacters()
        {
            char FirstAcceptedCharacter = 'A';

            for(int i = 0; i < BoardSize; i++)
            {
                int CharacterAdjustment = 0 + i;
                char nextValidCharacter = (Char)(Convert.ToInt32(FirstAcceptedCharacter) + CharacterAdjustment);
                AcceptedCharacters[i] = nextValidCharacter;
            }
        }
        private void SetAcceptedIntegers()
        {
            int FirstAcceptedInteger = 1;
            for (int i = 0; i < BoardSize; i++)
            {
                int IntegerAdjustment = 0 + i;
                int nextValidInteger = FirstAcceptedInteger + IntegerAdjustment;
                AcceptedIntegers[i] = nextValidInteger;
            }
        }
        private char CollectInputCharacter(string userInput)
        {
            string inputLetter = userInput.Substring(0, 0);
            return char.Parse(inputLetter);        
        }
        private int CollectInputInteger(string userInput)
        {
            string inputNumber = userInput.Substring(1);            
            return int.Parse(inputNumber);
        }
        private int CheckValidCharacter(char inputCharacter)
        {
            bool validCharacter = Array.Exists(AcceptedCharacters, c => c == inputCharacter);
            if (validCharacter)
            { return 0; }
            else
            { return 1; } // Output Enum Flags Messages - Input_InvalidColumn
        }
        private int CheckValidInteger(int inputInteger)
        {
            bool validInteger = Array.Exists(AcceptedIntegers, i => i == inputInteger);
            if (validInteger)
            { return 0; }
            else
            { return 2; } // Output Enum Flags Messages - Input_InvalidRow
        }
    }
}