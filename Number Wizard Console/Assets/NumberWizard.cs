using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        int maxGuess = 1000;
        int minGuess = 1;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number...");
        Debug.Log("The highest number you can choose is: " + maxGuess);
        Debug.Log("The lowest number you can choose is: " + minGuess);
        Debug.Log("Is your number higher or lower than my guess?");
        Debug.Log("Press Up = Higher, Press Down = Lower, Press Enter = Correct!");
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up Arrow key was pressed");
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow key was pressed");
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Yay! I guessed your number!");
        } 

    }
}
