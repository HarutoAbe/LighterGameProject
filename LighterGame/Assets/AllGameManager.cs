using UnityEngine;

public class AllGameManager : SingletonMonoBehaviour<AllGameManager>
{
    public enum GameState
    {
        Title,
        MainMenu,
        InGame,
        Result
    }
}
