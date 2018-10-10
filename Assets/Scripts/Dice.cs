using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour
{

    private int[, ,] diceNumbers;

    void Awake()
    {
        diceNumbers = new int[7, 7, 3];

        diceNumbers[0, 0, 0] = 0; diceNumbers[0, 0, 1] = 0; diceNumbers[0, 0, 2] = 3;
        diceNumbers[0, 1, 0] = 0; diceNumbers[0, 1, 1] = 90; diceNumbers[0, 1, 2] = 6;
        diceNumbers[0, 2, 0] = 0; diceNumbers[0, 2, 1] = 180; diceNumbers[0, 2, 2] = 4;
        diceNumbers[0, 3, 0] = 0; diceNumbers[0, 3, 1] = 270; diceNumbers[0, 3, 2] = 1;
        diceNumbers[0, 4, 0] = 0; diceNumbers[0, 4, 1] = -90; diceNumbers[0, 4, 2] = 1;
        diceNumbers[0, 5, 0] = 0; diceNumbers[0, 5, 1] = -180; diceNumbers[0, 5, 2] = 4;
        diceNumbers[0, 6, 0] = 0; diceNumbers[0, 6, 1] = -270; diceNumbers[0, 6, 2] = 6;

        diceNumbers[1, 0, 0] = 90; diceNumbers[1, 0, 1] = 0; diceNumbers[1, 0, 2] = 2;
        diceNumbers[1, 1, 0] = 90; diceNumbers[1, 1, 1] = 90; diceNumbers[1, 1, 2] = 2;
        diceNumbers[1, 2, 0] = 90; diceNumbers[1, 2, 1] = 180; diceNumbers[1, 2, 2] = 2;
        diceNumbers[1, 3, 0] = 90; diceNumbers[1, 3, 1] = 270; diceNumbers[1, 3, 2] = 2;
        diceNumbers[1, 4, 0] = 90; diceNumbers[1, 4, 1] = -90; diceNumbers[1, 4, 2] = 2;
        diceNumbers[1, 5, 0] = 90; diceNumbers[1, 5, 1] = -180; diceNumbers[1, 5, 2] = 2;
        diceNumbers[1, 6, 0] = 90; diceNumbers[1, 6, 1] = -270; diceNumbers[1, 6, 2] = 2;

        diceNumbers[2, 0, 0] = 180; diceNumbers[2, 0, 1] = 0; diceNumbers[2, 0, 2] = 4;
        diceNumbers[2, 1, 0] = 180; diceNumbers[2, 1, 1] = 90; diceNumbers[2, 1, 2] = 1;
        diceNumbers[2, 2, 0] = 180; diceNumbers[2, 2, 1] = 180; diceNumbers[2, 2, 2] = 3;
        diceNumbers[2, 3, 0] = 180; diceNumbers[2, 3, 1] = 270; diceNumbers[2, 3, 2] = 6;
        diceNumbers[2, 4, 0] = 180; diceNumbers[2, 4, 1] = -90; diceNumbers[2, 4, 2] = 6;
        diceNumbers[2, 5, 0] = 180; diceNumbers[2, 5, 1] = -180; diceNumbers[2, 5, 2] = 3;
        diceNumbers[2, 6, 0] = 180; diceNumbers[2, 6, 1] = -270; diceNumbers[2, 6, 2] = 1;

        diceNumbers[3, 0, 0] = 270; diceNumbers[3, 0, 1] = 0; diceNumbers[3, 0, 2] = 5;
        diceNumbers[3, 1, 0] = 270; diceNumbers[3, 1, 1] = 90; diceNumbers[3, 1, 2] = 5;
        diceNumbers[3, 2, 0] = 270; diceNumbers[3, 2, 1] = 180; diceNumbers[3, 2, 2] = 5;
        diceNumbers[3, 3, 0] = 270; diceNumbers[3, 3, 1] = 270; diceNumbers[3, 3, 2] = 5;
        diceNumbers[3, 4, 0] = 270; diceNumbers[3, 4, 1] = -90; diceNumbers[3, 4, 2] = 5;
        diceNumbers[3, 5, 0] = 270; diceNumbers[3, 5, 1] = -180; diceNumbers[3, 5, 2] = 5;
        diceNumbers[3, 6, 0] = 270; diceNumbers[3, 6, 1] = -270; diceNumbers[3, 6, 2] = 5;

        diceNumbers[4, 0, 0] = -90; diceNumbers[4, 0, 1] = 0; diceNumbers[4, 0, 2] = 5;
        diceNumbers[4, 1, 0] = -90; diceNumbers[4, 1, 1] = 90; diceNumbers[4, 1, 2] = 5;
        diceNumbers[4, 2, 0] = -90; diceNumbers[4, 2, 1] = 180; diceNumbers[4, 2, 2] = 5;
        diceNumbers[4, 3, 0] = -90; diceNumbers[4, 3, 1] = 270; diceNumbers[4, 3, 2] = 5;
        diceNumbers[4, 4, 0] = -90; diceNumbers[4, 4, 1] = -90; diceNumbers[4, 4, 2] = 5;
        diceNumbers[4, 5, 0] = -90; diceNumbers[4, 5, 1] = -180; diceNumbers[4, 5, 2] = 5;
        diceNumbers[4, 6, 0] = -90; diceNumbers[4, 6, 1] = -270; diceNumbers[4, 6, 2] = 5;

        diceNumbers[5, 0, 0] = -180; diceNumbers[5, 0, 1] = 0; diceNumbers[5, 0, 2] = 4;
        diceNumbers[5, 1, 0] = -180; diceNumbers[5, 1, 1] = 90; diceNumbers[5, 1, 2] = 1;
        diceNumbers[5, 2, 0] = -180; diceNumbers[5, 2, 1] = 180; diceNumbers[5, 2, 2] = 3;
        diceNumbers[5, 3, 0] = -180; diceNumbers[5, 3, 1] = 270; diceNumbers[5, 3, 2] = 6;
        diceNumbers[5, 4, 0] = -180; diceNumbers[5, 4, 1] = -90; diceNumbers[5, 4, 2] = 6;
        diceNumbers[5, 5, 0] = -180; diceNumbers[5, 5, 1] = -180; diceNumbers[5, 5, 2] = 3;
        diceNumbers[5, 6, 0] = -180; diceNumbers[5, 6, 1] = -270; diceNumbers[5, 6, 2] = 1;

        diceNumbers[6, 0, 0] = -270; diceNumbers[6, 0, 1] = 0; diceNumbers[6, 0, 2] = 2;
        diceNumbers[6, 1, 0] = -270; diceNumbers[6, 1, 1] = 90; diceNumbers[6, 1, 2] = 2;
        diceNumbers[6, 2, 0] = -270; diceNumbers[6, 2, 1] = 180; diceNumbers[6, 2, 2] = 2;
        diceNumbers[6, 3, 0] = -270; diceNumbers[6, 3, 1] = 270; diceNumbers[6, 3, 2] = 2;
        diceNumbers[6, 4, 0] = -270; diceNumbers[6, 4, 1] = -90; diceNumbers[6, 4, 2] = 2;
        diceNumbers[6, 5, 0] = -270; diceNumbers[6, 5, 1] = -180; diceNumbers[6, 5, 2] = 2;
        diceNumbers[6, 6, 0] = -270; diceNumbers[6, 6, 1] = -270; diceNumbers[6, 6, 2] = 2;

    }

    public void StartRolling(int player)
    {

        int count = 1; // player == 0 ? 1 : 2;
        for (int i = 0; i < count; i++)
        {
            Vector3 startPosition = new Vector3(4.5f, 5 * (i + 1), 4.5f);
            GameObject dice = GameObject.Instantiate(GameManager.staticGameManager.dice, startPosition, Quaternion.identity) as GameObject;
            int x = Random.Range(50, 360);
            int y = Random.Range(50, 360);
            int z = Random.Range(50, 360);
            dice.transform.Rotate(x, y, z);
            dice.GetComponent<Rigidbody>().AddTorque(x, y, z);
            StartCoroutine(CheckDice(dice, player));
        }

    }
    IEnumerator CheckDice(GameObject dice, int player)
    {
        while (true)
        {
            Vector3 prePosition = dice.transform.position;
            Vector3 preRotation = dice.transform.rotation.eulerAngles;
            yield return new WaitForSeconds(.5f);
            Vector3 position = dice.transform.position;
            Vector3 rotation = dice.transform.rotation.eulerAngles;
            if (position == prePosition && rotation == preRotation)
            {
                if (player == 0)
                {
                    UIScript.ui.TriggerDiceButtons();
                }
                float x = dice.transform.rotation.eulerAngles.x;
                float y = dice.transform.rotation.eulerAngles.y;
                float z = dice.transform.rotation.eulerAngles.z;

                x = FixRotationValues(x);
                y = FixRotationValues(y);
                z = FixRotationValues(z);

                int result = CheckResult(x, y, z);
                Destroy(dice);
                GameManager.staticGameManager.AfterDice(result, player);
                break;
            }
        }
        yield return null;
    }
    float FixRotationValues(float value)
    {
        float average = 45.0f;
        float angle = 90.0f;
        int counter = 1;
        float result = 0;
        while (true)
        {
            if (value <= angle)
            {
                if (value >= average)
                {
                    result = counter * 90;
                }
                else
                {
                    result = (-1 + counter) * 90;
                }
                break;
            }
            value -= 90.0f;
            counter++;
        }
        if (result >= 360)
        {
            result %= 360;
        }
        return result;
    }
    int CheckResult(float x, float y, float z)
    {
        for (int i = 0; i < diceNumbers.GetLength(0); i++)
        {
            for (int j = 0; j < diceNumbers.GetLength(1); j++)
            {
                if (x == this.diceNumbers[i, j, 0] && z == this.diceNumbers[i, j, 1])
                {
                    return this.diceNumbers[i, j, 2];
                }
            }
        }
        return 0;
    }
}
