﻿namespace BattleshipsNS
{
    // Interfaces for Basic Game Creation
    public interface IGamePlay
    {
        IGameSetup GameSetup { get; set; }
    }
    public interface IGameSetup
    {
        IGameComponents GameParts { get; }
        IGameBoard GameBoard { get; }
    }
    public interface IGameBoard { }
    public interface IGameBoardSpace { }
    public interface IGameComponents { }
    public interface IGameComponent { }
    public interface IGameInputHandler { }
    public interface IGameOutputGenerator { }
}
