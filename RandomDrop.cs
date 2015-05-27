using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomDrop : MonoBehaviour {

	public UnityEngine.UI.Button Drop;
	private Vector3 startingPosition;
	private bool isWaiting;
	private int speed;
	private int seconds;
	private float reposition;
	private float maxFallDistance = -50;

	void Start ()
	{
		startingPosition = Drop.transform.position;
		speed = Random.Range (-8, -3);
		seconds = Random.Range (30, 1200);
		reposition = Random.Range (250, 1200);
	}
	IEnumerator Wait(){
		isWaiting = true;
		if (Drop.transform.position.y <= maxFallDistance) {
			speed = Random.Range (-8, -3);
			seconds = Random.Range (30, 1200);
			reposition = Random.Range (250, 1200);
			yield return new WaitForSeconds (seconds);
			Drop.transform.position = new Vector3(reposition, 500.0f, 0.0f);
			
		} else {
			float translation = Time.deltaTime * 2;
			transform.Translate (0, speed, translation);
			transform.Translate (Vector3.forward * translation);
		}
		isWaiting = false;
	}
	// Update is called once per frame
	void Update () {
		if (!isWaiting){
			StartCoroutine (Wait ());
		}
	}
}
