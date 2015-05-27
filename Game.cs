using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game { 
	
	public static Game current;
	public ClickProperties CurrentEuros { get; set; }
	
	public Game () {
		//CurrentEuros = 1;
		CurrentEuros = new ClickProperties();
	}
}
