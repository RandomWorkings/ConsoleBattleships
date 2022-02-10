namespace BattleshipsNS
{
    public class BattleshipsSetup : IBattleshipsSetup
    {
        public IGameBoard GameBoard { get; private set; }
        public IGameParts GameParts { get; private set; }
        public IValueGenerator ValueGenerator { get; private set; }

        public BattleshipsSetup(IGameBoard board, IGameParts parts, IValueGenerator valueGenerator)
        {
            GameBoard = board;
            GameParts = parts;
            ValueGenerator = valueGenerator;
        }

        public void GenerateGame()
        { 
            foreach (IShip ship in GameParts.Ships)
            {
                ship.PlaceShip(GameBoard, ValueGenerator);
            }
        }
}