﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public void LoadLEvel (string name){
	
		Debug.Log("Level load requested for: " +name);
	}
	
	public void QuitRequest(){
	
		Debug.Log("I wanna quit !");
	}
}
