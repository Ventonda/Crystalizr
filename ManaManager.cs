using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	public Color standard;
	public Color affordable;
	private float baseCost;
	
	void Start(){
		baseCost = cost;
	}
	
	void Update(){
		itemInfo.text = itemName + "\nCost: " + cost;
		
		if (Game.current.CurrentEuros.euros >= cost) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}
	
	public void PurchadesUpgrade(){
		if (Game.current.CurrentEuros.euros >= cost) {
			Game.current.CurrentEuros.euros -= cost;
			count += 1;
			Game.current.CurrentEuros.eurosPerClick += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.85f, count));
		}
	}
}
