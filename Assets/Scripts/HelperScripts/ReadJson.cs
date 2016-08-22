﻿using UnityEngine;
using System.Collections;
using System.IO;
using LitJson;

public class ReadJson : MonoBehaviour {
	private string JSONString;
	private JsonData levelData;


	public JsonData getLevel(string level){
		JSONString = File.ReadAllText (Application.dataPath + "/Resources/Json/" + level +".json");
		if (JSONString != null) {
			levelData = JsonMapper.ToObject (JSONString);
		
			return levelData;
		}else{
			return null;
		}
	}

	public JsonData getUnits(string units){
		JSONString = File.ReadAllText (Application.dataPath + "/Resources/Json/" + units +".json");
		if (JSONString != null) {
			levelData = JsonMapper.ToObject (JSONString);

			return levelData;
		}else{
			return null;
		}
	}
}
