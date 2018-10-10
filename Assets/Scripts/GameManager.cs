using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static List<CubeStructure> cubes = new List<CubeStructure>();
    public Transform cubesParent;
    public GameObject dice;
    public GameObject rawPlayer1, rawPlayer2;

    public static GameManager staticGameManager;
    public static int player = -1;
    public static List<List<int>> snakes;
    public static List<List<int>> ladders;

    [HideInInspector]
    public Vector3 playerStartPosition;
    [HideInInspector]
    public int player1Dice, player2Dice;
    [HideInInspector]
    public GameObject player1, player2;

    public int player1Counter, player2Counter;

    void Awake()
    {
        staticGameManager = this;
        for (int i = 0; i < cubesParent.childCount; i++)
        {
            GameObject g = cubesParent.GetChild(i).GetChild(0).gameObject;
            CubeStructure cubeStructure = new CubeStructure();
            cubeStructure.cube = g;
            cubes.Add(cubeStructure);
        }
        playerStartPosition = new Vector3(cubes[0].cube.transform.position.x, cubes[0].cube.transform.position.y + .5f, cubes[0].cube.transform.position.z);

        // Snakes
        GameManager.snakes = new List<List<int>>();
        List<int> snake1 = new List<int>();
        snake1.Add(22);
        snake1.Add(3);
        GameManager.snakes.Add(snake1);

        List<int> snake2 = new List<int>();
        snake2.Add(86);
        snake2.Add(16);
        GameManager.snakes.Add(snake2);

        List<int> snake3 = new List<int>();
        snake3.Add(68);
        snake3.Add(26);
        GameManager.snakes.Add(snake3);

        // Ladders
        GameManager.ladders = new List<List<int>>();
        List<int> ladder1 = new List<int>();
        ladder1.Add(9);
        ladder1.Add(49);
        GameManager.ladders.Add(ladder1);

        List<int> ladder2 = new List<int>();
        ladder2.Add(18);
        ladder2.Add(44);
        GameManager.ladders.Add(ladder2);

        List<int> ladder3 = new List<int>();
        ladder3.Add(56);
        ladder3.Add(82);
        GameManager.ladders.Add(ladder3);

        List<int> ladder4 = new List<int>();
        ladder4.Add(54);
        ladder4.Add(93);
        GameManager.ladders.Add(ladder4);

    }
    public void AfterDice(int result, int player)
    {
        if (player != 0)
        {
            if ((player1Dice == 0) ^ (player2Dice == 0))
            {
                if (player == 1)
                {
                    player1Dice = result;
                }
                if (player == 2)
                {
                    player2Dice = result;
                }

                if (player1Dice > player2Dice)
                {
                    GameManager.player = 1;
                    InitPlayers();
                }
                else if (player2Dice > player1Dice)
                {
                    GameManager.player = 2;
                    InitPlayers();
                }
                else
                {
                    player = -1;
                    player1Dice = 0;
                    player2Dice = 0;
                    UIScript.ui.EnablePlayersDice();
                }
            }
            else if (player == 1)
            {
                player1Dice = result;
            }
            else if (player == 2)
            {
                player2Dice = result;
            }
        }
        else
        {
            ContinueGame(result);
        }
    }

    void InitPlayers()
    {

        player1 = Instantiate(rawPlayer1) as GameObject;
        player2 = Instantiate(rawPlayer2) as GameObject;
        player1.transform.position = player2.transform.position = playerStartPosition;
        StartGame();
    }

    void StartGame()
    {
        UIScript.ui.EnableDiceButtons(GameManager.player);
    }

    void ContinueGame(int result)
    {
        Player.staticPlayer.Move(result);
    }

}
