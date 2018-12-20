using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour {

    // TRANSFORM DE LA BOLA
    [SerializeField] Transform target;

    // RECOJO EL RIGIDBODY DE NUESTRO CYBO
    Rigidbody miRigidBody;

    private void Start() {
        miRigidBody = GetComponent<Rigidbody>();    

    }

    // Update is called once per frame
    void FixedUpdate () {
        // PARA SABER LA DISTANCIA QUE HAY ENTRE LOS DOS ELEMENTOS
        Vector3 distancia = target.position - transform.position;
        // EL RIGID LO QUEREMOS MOVER POCO A POCO
        // NORMALIZAR LA DISTANCIA ESTAMOS REPRESENTANDO LA DISTANCIA A 1 
        Vector3 distancianormalizada = distancia.normalized;
        //
        Vector3 deltaPosition = distancianormalizada * Time.deltaTime;
        // LO MOVERE EN UNA DISTANCIA NORMALIZADA Y LO MULTIPLICAMOS CON EL TIME...
        // SE MOVERA HACIA EL TARGET
        if (distancia.magnitude > 0.1f) { // PARA QUE NO TIEMBLE CUANDO ESTA TOCANDO A LA ESFERA
            // MOVIMIENTO DE POSICION SOBRE UN OBJ CINEMATICO
            miRigidBody.MovePosition(miRigidBody.position + deltaPosition);
        }

	}
}
