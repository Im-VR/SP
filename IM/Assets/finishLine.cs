using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour {

    private void OnTriggerEnter(Collider collider){

        GameObject.Find("SpaceSH").SendMessage("Finnish");
    }
}
