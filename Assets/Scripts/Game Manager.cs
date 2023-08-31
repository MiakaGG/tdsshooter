using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;   

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameState State;

    public PlayerController player;

    public static event Action<GameState> OnGameStateChanged;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateGameState(GameState.MainMenu);

        player.score = 0;
        player.health = 3;
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

    // TESTING FOR PLAYER.HEALTH
    public void playerLoseHealth(float value)
    {
        player.health = player.health - 1;
    }
}

public enum GameState 
{
    MainMenu,
    PlayState,
    ScoreState
}