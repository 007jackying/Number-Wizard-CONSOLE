using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    Random rand = new Random();
    //int a = rand.NextInteger();
    // Start is called before the first frame update
    void Start()
    {
        int max = 5000;
        int min = 0;
        int newguess = Next(min, max);

        Debug.Log("Welcome to Number WIZARD!");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: "+ max);
        Debug.Log("Lowest number is: "+ min);
        Debug.Log("Tell me is my guess is higher or lower");
        Debug.Log("Push up = Higher, Push down= Lower, Push Enter = correct");
        Debug.Log("Game is now LOADING.........");
        print("My guess of the number is.... %d", newguess);
    }

    public virtual int Next(int minValue, int maxValue);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up ARROW key is pressed.");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key is pressed");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter is pressed");
        }
    }

    public int Recalculating(string code, int lastguess)
    {
        int newtotal;
        if (code == 1)
        {
            newtotal = rand.NextInteger();
        }
    }
}
