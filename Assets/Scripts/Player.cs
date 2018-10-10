using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{

    public static Player staticPlayer;

    void Awake()
    {
        staticPlayer = this;
    }

    public void Move(int result)
    {
        if (GameManager.player == 1)
        {
            GameManager.staticGameManager.player1Counter += result;
            if (GameManager.staticGameManager.player1Counter >= 99)
            {
                GameManager.staticGameManager.player1Counter = 99;
                Invoke("CheckForEndOfGame", 1.0f);
            }
            Vector3 position = new Vector3(GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.x,
                                           GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.y + .5f,
                                           GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.z);
            GameManager.staticGameManager.player1.transform.position = position;
        }
        else
        {
            GameManager.staticGameManager.player2Counter += result;
            if (GameManager.staticGameManager.player2Counter >= 99)
            {
                GameManager.staticGameManager.player2Counter = 99;
                Invoke("CheckForEndOfGame", 1.0f);
            }
            Vector3 position = new Vector3(GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.x,
                                           GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.y + .5f,
                                           GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.z);
            GameManager.staticGameManager.player2.transform.position = position;

        }

        Invoke("CheckSnake", 1.0f);
        Invoke("CheckLadder", 1.0f);
    }

    void CheckSnake()
    {
        if (GameManager.player == 1)
        {
            for (int i = 0; i < GameManager.snakes.Count; i++)
            {
                int source = GameManager.snakes[i][0] - 1;
                int destination = GameManager.snakes[i][1] - 1;
                if (source == GameManager.staticGameManager.player1Counter)
                {
                    GameManager.staticGameManager.player1Counter = destination;
                    Vector3 position = new Vector3(GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.x,
                                                   GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.y + .5f,
                                                   GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.z);
                    GameManager.staticGameManager.player1.transform.position = position;
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < GameManager.snakes.Count; i++)
            {
                int source = GameManager.snakes[i][0] - 1;
                int destination = GameManager.snakes[i][1] - 1;
                if (source == GameManager.staticGameManager.player2Counter)
                {
                    GameManager.staticGameManager.player2Counter = destination;
                    Vector3 position = new Vector3(GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.x,
                                                   GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.y + .5f,
                                                   GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.z);
                    GameManager.staticGameManager.player2.transform.position = position;
                    break;
                }
            }
        }
    }

    void CheckLadder()
    {
        if (GameManager.player == 1)
        {
            for (int i = 0; i < GameManager.ladders.Count; i++)
            {
                int source = GameManager.ladders[i][0] - 1;
                int destination = GameManager.ladders[i][1] - 1;
                if (source == GameManager.staticGameManager.player1Counter)
                {
                    GameManager.staticGameManager.player1Counter = destination;
                    Vector3 position = new Vector3(GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.x,
                                                   GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.y + .5f,
                                                   GameManager.cubes[GameManager.staticGameManager.player1Counter].cube.transform.position.z);
                    GameManager.staticGameManager.player1.transform.position = position;
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < GameManager.ladders.Count; i++)
            {
                int source = GameManager.ladders[i][0] - 1;
                int destination = GameManager.ladders[i][1] - 1;
                if (source == GameManager.staticGameManager.player2Counter)
                {
                    GameManager.staticGameManager.player2Counter = destination;
                    Vector3 position = new Vector3(GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.x,
                                                   GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.y + .5f,
                                                   GameManager.cubes[GameManager.staticGameManager.player2Counter].cube.transform.position.z);
                    GameManager.staticGameManager.player2.transform.position = position;
                    break;
                }
            }
        }
    }

    void CheckForEndOfGame()
    {
        UIScript.ui.DisableAllPlayersDice();
        UIScript.ui.EnableOrDisableEndUI(true);

    }
}
