using UnityEngine;
using System.Collections;

public class BuyMana : MonoBehaviour {
	
	public UnityEngine.UI.Text ManaEarned;
	public RandomDrop Drop;
	public float manaState = 0.00f;
	public int manaPerClick = 1;
	private float reposition;

	void Start ()
	{
		reposition = Random.Range (250, 1200);
	}
	
	void Update(){
		ManaEarned.text = manaState.ToString ("F0") + " Mana";
	}
	
	public void OnMouseDown(){
		Drop.transform.position = new Vector3(reposition, 500, 0);
		reposition = Random.Range (250, 1200);
		manaState += manaPerClick;
	}
}
