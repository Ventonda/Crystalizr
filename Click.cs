using UnityEngine;
using System.Collections;

[System.Serializable]

public class ClickProperties {
	public float euros;
	public float eurosPerClick;
}

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text eurosPerClick;
	public UnityEngine.UI.Text eurosEarned;
	public ClickProperties myProps;

	public Click()
	{
		myProps.eurosPerClick = 1;
	}
	
	void Update(){
		eurosEarned.text = myProps.euros.ToString ("F0") + " Splinter";
		eurosPerClick.text = myProps.eurosPerClick + " Splinter/click";
	}

	public void Clicked(){
		myProps.euros += myProps.eurosPerClick;
	}

}
