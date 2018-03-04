using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RBox : MonoBehaviour {
	 
	// Use this for initialization
	void Start () {
		
	}

	/*void SetTransformX(float n){
		transform.position = new Vector3(transform.position.x,n , transform.position.z);
	}
	void Update (){
		SetTransformX(0.3);
	}*/
	void Update () {
		//transform.position = new Vector3(0, -0.3, 0);*/
		transform.Rotate (new Vector3 (0, 0, 30)* Time.deltaTime );}


	public void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("pickUps"))
		{
			other.gameObject.SetActive (false);
			//countController.count++;

		}	
	}


}
	

