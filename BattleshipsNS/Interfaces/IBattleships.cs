namespace BattleshipsNS
{
    //Interfaces for a Battleship Game
    public interface IBattleshipsBoard : IGameBoard
    {
        int BoardSize { get; }
        BoardSpace[,] PlayGrid { get; }
    }
    public interface IBattleshipsBoardSpace : IGameBoardSpace
    {
        bool Occupied { get; set; }
        char? Contents { get; set; }
    }
    public interface IBattleshipsShips : IGameComponents
    {
        Ship[] Ships { get; }
        int ShipCount { get; }
        int UpdateShipCount();
    }
    public interface IBattleshipsShip : IGameComponent
    {
        ShipTypes Type { get; }
        int Length { get; }
        bool Sunk { get; }
        bool Placed { get; }
        BoardSpace[] Sections { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        void PlaceShip(GameBoard gameBoard);
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
        string GeneratePlayGridUI(GameBoard playGrid);
    }
}