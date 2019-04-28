using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int maxGuess;
    int minGuess;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    // All statements for the start of the game
    void StartGame() {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("WELCOME TO NUMBER WIZARD!");
        Debug.Log("Pick a number...");
        Debug.Log("The highest number you can choose is: " + maxGuess);
        Debug.Log("The lowest number you can choose is: " + minGuess);
        Debug.Log("Is your number " + guess + "?");
        Debug.Log("Press UP = Higher, Press DOWN = Lower, Press ENTER = Correct!");

        // Allow console to guess 1000:
        maxGuess = maxGuess + 1;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Darn, your number is higher!");
            minGuess = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Darn, your number is lower!");
            maxGuess = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Yay! I guessed your number! :D");
            StartGame();
        } 
    }

    // Create a new guess, using the new max/min
    void NextGuess() {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("Is your number " + guess + "?");
    }
}
