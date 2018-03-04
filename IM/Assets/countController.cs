using UnityEngine;
using System.Collections;

public class countController : MonoBehaviour {

	// Use this for initialization
	public static int count = 0;

	void increasScore(){

		string Score = "Score: " + count;
		GUI.Box (new Rect(Screen.width -150,20,130,20),Score);
	}


}
