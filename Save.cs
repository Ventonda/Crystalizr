using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour {
	SaveLoad saveLoadBehavior;

	public void Start() {
		saveLoadBehavior = new SaveLoad();	
	}
	
	public void SaveNow(){
		SaveLoad.Save();
	}
	public void LoadNow(){
		SaveLoad.Load();
	}
}
