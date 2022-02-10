using ProgramNS;

namespace BattleshipsNS
{
    //Interfaces for a Battleship Game

    public interface IGameSetup
    {
        IGameComponents GameParts { get; }
        IGameBoard GameBoard { get; }
    }
    public interface IGamePlay
    {
        IGameSetup GameSetup { get; set; }
    }

    public interface IBoard
    {
        int BoardSize { get; }
        BattleshipsBoardSpace[,] PlayGrid { get; }
    }
    public interface IBoardSpace
    {
        bool Occupied { get; set; }
        char? Contents { get; set; }
    }
    public interface IShips
    {
        BattleshipsShip[] Ships { get; }
        int ShipCount { get; }
        int UpdateShipCount();
    }
    public interface IShip
    {
        ShipTypes Type { get; }
        int Length { get; }
        bool Sunk { get; }
        bool Placed { get; }
        BattleshipsBoardSpace[] Sections { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        void PlaceShip(BattleshipsBoard gameBoard);
        void UpdateSunk();
    }
    public interface IInputHandler
    {
        int ValidateInput(string userInput);
        (int, int) ConvertInputToTuple(string userInput);
    }
    public interface IOutputGenerator
    {
        string GenerateInputRequest();
        string GenerateMessages(int MessagesCode, int SunkShipCount);
        string GeneratePlayGridUI(BattleshipsBoard playGrid);
    }
}