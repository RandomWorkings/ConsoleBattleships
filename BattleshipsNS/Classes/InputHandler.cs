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
        private int AcceptedLength;
        private int boardSize;

        public InputHandler(GameBoard gameBoard)
        {
            boardSize = gameBoard.BoardSize;
            
            AcceptedCharacters = new char[boardSize];
            SetAcceptedCharacters();

            AcceptedIntegers = new int[boardSize];
            SetAcceptedIntegers();

            SetAcceptedLength(); 
        }

        public int[] GetTargetSpace()
        {
            //Get User Input
            Console.WriteLine("");
            string userInput = Console.ReadLine();

            //Chop up input and covert to appropriate type for checks
            string inputLetter = userInput.Substring(0, 0);
            char inputCharacter = char.Parse(inputLetter);

            string inputNumber = userInput.Substring(1);
            int inputInteger = int.Parse(inputNumber);

            //Input Checks
            int lengthCheck = CheckValidLength(userInput);
            int characterCheck = CheckValidCharacter(inputCharacter);
            int integerCheck = CheckValidInteger(inputInteger);

            //Change input into Index 0 values
            int row = inputInteger - 1;
            int column = Convert.ToInt32(inputCharacter) - 1;

            int[] output = {row, column, lengthCheck, characterCheck, integerCheck};
            return output;
        }

        private void SetAcceptedCharacters()
        {
            char FirstAcceptedCharacter = 'A';

            for(int i = 0; i < boardSize; i++)
            {
                int CharacterAdjustment = 0 + i;
                char nextValidCharacter = (Char)(Convert.ToInt32(FirstAcceptedCharacter) + CharacterAdjustment);
                AcceptedCharacters[i] = nextValidCharacter;
            }
        }
        private void SetAcceptedIntegers()
        {
            int FirstAcceptedInteger = 1;
            for (int i = 0; i < boardSize; i++)
            {
                int IntegerAdjustment = 0 + i;
                int nextValidInteger = FirstAcceptedInteger + IntegerAdjustment;
                AcceptedIntegers[i] = nextValidInteger;
            }
        }
        private void SetAcceptedLength()
        {
            char LastIDCharacter = AcceptedCharacters[AcceptedCharacters.Length - 1];
            int LastIDInteger = AcceptedIntegers[AcceptedIntegers.Length - 1];
            string LastSpaceID = ""+LastIDCharacter + LastIDInteger;
            AcceptedLength = LastSpaceID.Length;
        }
        private int CheckValidLength(string inputString)
        {
            bool validLength = (inputString.Length <= AcceptedLength);
            return Convert.ToInt32(validLength);
        }
        private int CheckValidCharacter(char inputCharacter)
        {
            bool validCharacter = Array.Exists(AcceptedCharacters, c => c == inputCharacter);
            return Convert.ToInt32(validCharacter);
        }
        private int CheckValidInteger(int inputInteger)
        {
            bool validInteger = Array.Exists(AcceptedIntegers, i => i == inputInteger);
            return Convert.ToInt32(validInteger);
        }
    }
}