using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Verticalplatform : MonoBehaviour {
private PlatformEffector2D effector;
public float waitTime;

void Start() {

effector = GetComponent<PlatformEffector2D>();

}


void Update(){

    if (Input.GetKeyUp(KeyCode.C)) {

        waitTime = 0.5f;
    }

if (Input.GetKey(KeyCode.C)){

if(waitTime <=0) {
    effector.rotationalOffset = 180f;
    waitTime = 0.5f; 
}
else {

waitTime -= Time.deltaTime; 
}
}


if(Input.GetKey(KeyCode.Space)){

    effector.rotationalOffset = 0f;
}

}



}