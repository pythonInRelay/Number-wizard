using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    
    int minGuess = 1;
    int maxGuess = 1000;
    int guess = 500;
    
    void Start()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log($"Please pick a number between {minGuess} and {maxGuess}.");
        Debug.Log("Now tell me if I need to guess higher or lower!");
        Debug.Log("'Up' = Higher, 'Down' = Lower and 'Enter' = Correct");
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.UpArrow)) // If the key Up Arrow was pushed down, output a line to the console
        {
            Debug.Log("You pressed the Up Arrow!");
                minGuess = guess;
                Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pressed the Down Arrow!");
            maxGuess = guess;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You pressed the Enter Key!");
            Debug.Log("Yes that was my number!");
        }
    }
}
