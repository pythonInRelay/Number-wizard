using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    
    int minGuess;
    int maxGuess;
    int guess;
    int numOfGuesses;
    
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        minGuess = 1;
        maxGuess = 1000;
        guess = 500;
        numOfGuesses = 0;
        
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log($"Please pick a number between {minGuess} and {maxGuess}.");
        Debug.Log("Now tell me if I need to guess higher or lower!");
        Debug.Log("'Up' = Higher, 'Down' = Lower and 'Enter' = Correct");
        maxGuess += 1;
    }
    
    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.UpArrow)) // If the key Up Arrow was pushed down, output a line to the console
        {
            minGuess = guess;
            NextGuess();
            
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log($"Great I guessed your number in only {numOfGuesses} guesses!");
            Debug.Log("Let's play another round!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        numOfGuesses += 1;
        Debug.Log($"Press the up arrow if your number is higher than {guess}!");
    }
}
