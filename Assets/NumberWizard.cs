using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max ;
	int min ;
	int guess ;	
	public int maxGuessesAllowed = 10;

	public Text text;
	
	void Start () {
		
		StartGame();
	}
	
	void StartGame () {
	
		max = 1001;
		min = 1;
		NextGuess();			
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
		
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessesAllowed --;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
