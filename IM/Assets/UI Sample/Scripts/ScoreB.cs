using UnityEngine;
using System.Collections;

public class ScoreB : MonoBehaviour {

		void onTEnter(Collider collide){

			switch (collide.gameObject.name) {

			case "Player":
				countController.count++;
				Destroy (this.gameObject);
				break;
			}


		}
	}
