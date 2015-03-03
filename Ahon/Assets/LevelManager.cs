using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void OnClickPlay()
	{
		Application.LoadLevel ("Game Level");
	}

	public void OnClickCancel()
	{
		Application.LoadLevel("Main Menu");
	}
}
