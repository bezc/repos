﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "game_difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume (float volume){
		if (volume <= 1.0f && volume >= 0) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("Volume out of range");
		}
	}

	public static float GetMasterVolume (){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); //use 1 for true
		} else {
			Debug.LogError("Trying to unlock a level not in Build Order");
		}
	}

	public static bool IsLevelUnlocked (int level){

		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isUnlocked = (levelValue == 1);

		if (level <= Application.levelCount - 1) {
			return isUnlocked;
		} else {
			Debug.Log ("Trying to query a level not in Build Order");
			return false;
		}
	}

	public static void SetDifficulty (float difficulty){
		if (difficulty <= 3.0f && difficulty >= 1.0f) {
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("Difficulty out of range");
		}
	}
	
	public static float GetDifficulty (){
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}


}