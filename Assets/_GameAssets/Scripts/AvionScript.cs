using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionScript : MonoBehaviour {

    int speed = 100;
	

	// Update is called once per frame
	void Update () {
        // nos da un valor entre -1 y 1
        float vPos = Input.GetAxis("Vertical");
        float hPos = Input.GetAxis("Horizontal");

        // RECOGEMOS EL CHARACTERCONTROLLER Y LE DAMOS UNA VELOCIDAD
        // PARA IUN OBJETO TERRESTRE QUE ESTE SOBRE UNA SUPERFICIE
        // EN EL MOMENTO QUE SE INVOCA LE AFECTA LA GRAVEDAD
        // NOS DA UN BOLEANO PARA SABER SI ESTOY ES TIERRA O NO
        //bool estaEnTierra = GetComponent<CharacterController>().SimpleMove(Vector3.forward * Time.deltaTime * speed * vPos);

        // PIDE UN VECTOR DE POSICION, LE SUMA UN POQUITO HACIA DELANTE, el Vector3 es del munto
        //GetComponent<CharacterController>().Move(Vector3.forward * Time.deltaTime * speed * vPos);
        // EL MOVE NO LE AFECTA LA GRAVEDAD
        GetComponent<CharacterController>().Move(transform.forward * Time.deltaTime * speed );

        // EL AVION TIENE QUE GIRAR 
        // ROTAMOS EL AVION HACIA ARRIBA Y HACIA ABAJO SOBRE EL TRANSFORM
        // Y QUE ROTE SOBRE LA Z Y PARA QUE SE MUEVA EN LA Y PONEMOS LA HPOS
        transform.Rotate(new Vector3(-1 * vPos, hPos , -1 * hPos));

        

    }
}
