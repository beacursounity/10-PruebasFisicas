using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvejaScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        print("!Viva el Trigger! "+gameObject.name);
    }
}
