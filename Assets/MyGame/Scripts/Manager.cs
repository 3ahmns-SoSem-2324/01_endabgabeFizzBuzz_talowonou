using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public TMP_Text Number;
    public int randomNum;
    public SpriteRenderer background;
    public TMP_Text infoText;
    public TMP_Text check;

    int GenerateRandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }

    void Start()
    {
        randomNum = GenerateRandomNumber(1, 1000);
        Number.text = randomNum.ToString();
        background.color = Color.white;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomNum = GenerateRandomNumber(1, 1000);
            Number.text = randomNum.ToString();
            background.color = Color.white;
            infoText.text = "";
            check.text = "";
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (randomNum % 3 == 0)
            {
                Debug.Log("Fizz!");
                background.color = Color.green;
                check.text = "RIGHT";
                check.color = Color.green;
            }
            else
            {
                Debug.Log("Falsch");
                background.color = Color.red;
                infoText.text = "Eine Zahl ist dann durch 3 Teilbar, wenn die Ziffernsumme durch 3 Teilbar ist";
                check.text = "FALSE";
                check.color = Color.red;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (randomNum % 5 == 0)
            {
                Debug.Log("Buzz!");
                background.color = Color.green;
                check.text = "RIGHT";
                check.color = Color.green;
            }
            else
            {
                Debug.Log("Falsch!");
                background.color = Color.red;
                infoText.text = "Eine Zahl ist durch 5 Teilbar, wenn die letzte Ziffer 5 oder 0 ist";
                check.text = "FALSE";
                check.color = Color.red;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (randomNum % 3 == 0 && randomNum % 5 == 0)
            {
                Debug.Log("Buzz! Fizz!");
                background.color = Color.green;
                check.text = "RIGHT";
                check.color = Color.green;
            }
            else
            {
                Debug.Log("Falsch");
                background.color = Color.red;
                infoText.text = "Eine Zahl ist dann durch 3 und 5 Teilbar, wenn die Ziffernsumme durch 3 Teilbar ist und wenn die letzte Ziffer 5 oder 0 ist";
                check.text = "FALSE";
                check.color = Color.red;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (randomNum % 3 != 0 && randomNum % 5 != 0)
            {
                Debug.Log("Richtig");
                background.color = Color.green;
                check.text = "RIGHT";
                check.color = Color.green;
            }
            else
            {
                Debug.Log("Falsch");
                background.color = Color.red;
                check.text = "FALSE";
                check.color = Color.red;
            }
        }
    }
}
