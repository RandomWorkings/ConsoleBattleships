using System;
using System.Text.RegularExpressions;

namespace BattleshipsNS
{
    public class InputHandler : IInputHandler
    {
        private readonly char[] AcceptedCharacters;
        private readonly int[] AcceptedIntegers;
        private readonly int BoardSize = 10;

        public InputHandler()
        {
            AcceptedCharacters = new char[BoardSize];
            SetAcceptedCharacters();

            AcceptedIntegers = new int[BoardSize];
            SetAcceptedIntegers();
        }

        public InputHandler(int boardSize)
        {
            BoardSize = boardSize;

            AcceptedCharacters = new char[BoardSize];
            SetAcceptedCharacters();

            AcceptedIntegers = new int[BoardSize];
            SetAcceptedIntegers();
        }

        public int ValidateInput(string userInput)
        {
            int formatCheck = 0;
            int characterCheck = 0;
            int integerCheck = 0;

            // Input string validation
            string validFormat = @"(^\b[A-Z]{1}[0-9]{1,2}\b$)"; //A0 to Z99 accepted.
            Regex validInput = new Regex(validFormat);

            if (validInput.IsMatch(userInput))
            {
                // Input string split into elements
                char inputCharacter = CollectInputCharacter(userInput);
                int inputInteger = CollectInputInteger(userInput);

                // Element validation
                characterCheck = CheckValidCharacter(inputCharacter);
                integerCheck = CheckValidInteger(inputInteger);
            }
            else
            {
                formatCheck = (int)Messages.Invalid_Format;
            }

            return formatCheck + characterCheck + integerCheck;
        }

        public (int, int) ConvertInputToTuple(string userInput)
        {
            // Input string split into elements
            char inputCharacter = CollectInputCharacter(userInput);
            int inputInteger = CollectInputInteger(userInput);

            // Adjustment and conversion of elements
            int column = Array.IndexOf(AcceptedCharacters, inputCharacter);
            int row = inputInteger - 1;

            return (row, column);
        }

        private void SetAcceptedCharacters()
        {
            char FirstAcceptedCharacter = 'A';

            for (int i = 0; i < BoardSize; i++)
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
            string inputLetter = userInput.Substring(0, 1);
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
            {
                return 0;
            }
            else
            {
                return (int)Messages.Invalid_Column;
            }
        }
        private int CheckValidInteger(int inputInteger)
        {
            bool validInteger = Array.Exists(AcceptedIntegers, i => i == inputInteger);
            if (validInteger)
            {
                return 0;
            }
            else
            {
                return (int)Messages.Invalid_Row;
            }
        }
    }
}