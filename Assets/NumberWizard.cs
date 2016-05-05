﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max ;
	int min ;
	int guess ;	
	public int maxGuessesAllowed = 5;

	public Text text;
	
	void Start () {
	
		StartGame();
		
	}
	
	void StartGame () {
	
		max = 1000;
		min = 1;
		guess =500;		
		max = max + 1;		
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	public void GuessHigher(){	
		min = guess;
		NextGuess();
	}
	
	void NextGuess () {	
		guess = (max + min )/2;
		text.text = guess.ToString();
		maxGuessesAllowed --;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
