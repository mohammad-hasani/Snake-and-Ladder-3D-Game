using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {

    public static UIScript ui;

    public GameObject btnPlayer1, btnPlayer2;
    public GameObject player1Left, player2Right;
    public GameObject endUi;

    void Awake()
    {
        UIScript.ui = this;
    }
    public void EnablePlayersDice()
    {
        btnPlayer1.SetActive(true);
        btnPlayer2.SetActive(true);
    }
    public void TriggerDiceButtons()
    {
        GameManager.player = GameManager.player == 1 ? 2 : 1;
        if(GameManager.player == 1)
        {
            player1Left.SetActive(true);
            player2Right.SetActive(false);
        }
        else if (GameManager.player == 2)
        {
            player1Left.SetActive(false);
            player2Right.SetActive(true);
        }
    }
    public void EnableDiceButtons(int player)
    {
        if (player == 1)
        {
            player1Left.gameObject.SetActive(true);
            player2Right.gameObject.SetActive(false);
        }
        else if (player == 2)
        {
            player1Left.gameObject.SetActive(false);
            player2Right.gameObject.SetActive(true);
        }
    }
    public void DisableAllPlayersDice()
    {
        player1Left.SetActive(false);
        player2Right.SetActive(false);
    }

    public void EnableOrDisableEndUI(bool status)
    {
        endUi.SetActive(status);
    }

    public void RestartGame()
    {
        //GameManager.cubes = null;
        //GameManager.snakes = null;
        //GameManager.ladders = null;
        GameManager.player = -1;
        GameManager.staticGameManager.player1Counter = 0;
        GameManager.staticGameManager.player2Counter = 0;
        GameManager.staticGameManager.player1Dice = 0;
        GameManager.staticGameManager.player2Dice = 0;
        Destroy(GameManager.staticGameManager.player1);
        Destroy(GameManager.staticGameManager.player2);
        EnablePlayersDice();
        endUi.SetActive(false);
        DisableAllPlayersDice();
        //UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
