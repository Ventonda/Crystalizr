using UnityEngine;
using System.Collections;

public class EuroPerSec : MonoBehaviour {

	public UnityEngine.UI.Text epsDisplay;
	public Click click;
	public ItemManager[] items;

	void Start(){
		StartCoroutine (AutoTick ());
	}

	void Update(){
		epsDisplay.text = GetEuroPerSec () + " Splinter/sec";
	}

	public float GetEuroPerSec(){
		float tick = 0;
		foreach (ItemManager item in items) {
			tick += item.count * item.tickValue;
		}
		return tick;
	}

	public void AutoEuroPerSec(){
		Game.current.CurrentEuros.euros += GetEuroPerSec () / 10;
	}

	IEnumerator AutoTick(){
		while(true){
			AutoEuroPerSec();
			yield return new WaitForSeconds(0.10f);
		}
	}

}
