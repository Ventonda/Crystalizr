using UnityEngine;
using System.Collections;

public class PullClick : MonoBehaviour {

	public UnityEngine.RectTransform Scroll;

	public void PullDown(){
		Scroll.anchoredPosition = new Vector3 (0, -220);
	}
}
