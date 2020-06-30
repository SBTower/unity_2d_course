using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int my_guess;
    int lower_bound;
    int upper_bound;
    int guess_count;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        lower_bound = 0;
        upper_bound = 1001;
        guess_count = 0;
        my_guess = CalculateGuess(lower_bound, upper_bound);

        Debug.Log("Welcome to Numberwang!");
        Debug.Log("Pick a number between 1 and 1000, and I will guess it in no more than 10 turns!");
        Debug.Log("Maximum number is: " + (upper_bound - 1));
        Debug.Log("Minimum number is: " + (lower_bound + 1));
        Debug.Log("Tell me if your number is higher or lower than my guess");
        Debug.Log("Push up -> Higher");
        Debug.Log("Push down -> Lower");
        Debug.Log("Push enter if I'm right!");
        Debug.Log("Guess #" + guess_count + ": " + my_guess);
        guess_count += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is higher than " + my_guess);
            lower_bound = my_guess;
            my_guess = CalculateGuess(lower_bound, upper_bound);
            guess_count += 1;
            Debug.Log("Guess #" + guess_count + ": " + my_guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower than " + my_guess);
            upper_bound = my_guess;
            my_guess = CalculateGuess(lower_bound, upper_bound);
            guess_count += 1;
            Debug.Log("Guess #" + guess_count + ": " + my_guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + my_guess + "! :)");
            Debug.Log("I guessed your number in " + guess_count + " guesses");
            StartGame();
        }

    }

    int CalculateGuess(int lower_bound, int upper_bound)
    {
        int guess = (upper_bound + lower_bound) / 2;
        return guess;
    }
}
