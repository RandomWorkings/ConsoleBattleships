using ProgramNS;

namespace BattleshipsNS
{
    //Interfaces for a Battleship Game
    public interface IBattleshipsGameSetup : IGameSetup { }
    public interface IBattleshipsGamePlay : IGamePlay { }
    public interface IBattleshipsBoard : IGameBoard
    {
        int BoardSize { get; }
        BattleshipsBoardSpace[,] PlayGrid { get; }
    }
    public interface IBattleshipsBoardSpace : IGameBoardSpace
    {
        bool Occupied { get; set; }
        char? Contents { get; set; }
    }
    public interface IBattleshipsShips : IGameComponents
    {
        BattleshipsShip[] Ships { get; }
        int ShipCount { get; }
        int UpdateShipCount();
    }
    public interface IBattleshipsShip : IGameComponent
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
    public interface IBattleshipsInputHandler : IGameInputHandler
    {
        int ValidateInput(string userInput);
        (int, int) ConvertInputToTuple(string userInput);
    }
    public interface IBattleshipsOutputGenerator : IGameOutputGenerator
    {
        string GenerateInputRequest();
        string GenerateMessages(int MessagesCode, int SunkShipCount);
        string GeneratePlayGridUI(BattleshipsBoard playGrid);
    }
}