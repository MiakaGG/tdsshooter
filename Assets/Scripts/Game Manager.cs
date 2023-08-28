using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;   

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateGameState(GameState.MainMenu);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState) 
        {
            case GameState.MainMenu:
                //put functions in here
                break;
            case GameState.PlayState:
                break;  
            case GameState.ScoreState:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null); 
        }

        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState 
{
    MainMenu,
    PlayState,
    ScoreState
}