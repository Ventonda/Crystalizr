using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad {
	public List<Game> savedGames = new List<Game>();

	public void Save() {
		savedGames.Add(Game.current);
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");
		bf.Serialize(file, SaveLoad.savedGames);
		file.Close();
	}
	public void Load() {
		if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			SaveLoad.savedGames = (List<Game>)bf.Deserialize(file);
			file.Close();
		}
	}
}
