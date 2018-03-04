using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveToScene : MonoBehaviour {

	public void ClickB(int s){
		SceneManager.LoadScene (s);
	}
}
