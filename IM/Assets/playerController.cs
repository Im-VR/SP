using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	public int count ;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		count = 0;
		updateScore ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void incScore(){
		count++;
		updateScore ();
	}

	public void updateScore(){
		scoreText.text = "Score: " + count.ToString();

	}


}
