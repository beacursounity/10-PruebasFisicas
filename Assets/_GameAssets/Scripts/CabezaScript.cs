using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabezaScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        // ESTO NO SE EJECUTA PQ EN LA JERARQUIA HAY UN PADRE CON RIGIDBOY
        print("Cabeza Oveja Trigger Enter:" + gameObject.name);        
    }
}
