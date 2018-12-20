using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastScript : MonoBehaviour {

    public Transform origen;
    public Transform destino;
    public Text texto;

    // PARA SABER SI HAY IMPACTO O NO
    bool hayImpacto;

    void Start() {
        texto.text = "" + hayImpacto;
    }



    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) { 
            Disparar();
        }

	}

    // SOLO NOS DEVUELVE SOLO UN ELEMENTO QUE HALLAC COLISIONADO Y EL OUT
    // NOS DEVUELVE CON QUIEN HA COLISIONADO
   /* void Disparar() {
        // AL SER EL STATIC .RAYCAST SE LE PUEDE LLAMAR DIRECTAMENTE Y DEBUELVE UN BOLEANO
        // hayImpacto = Physics.Raycast(origen.position,origen.forward);
        RaycastHit rh; // PARA SACAR LA INFORMACION DE CON QUIEN SE HA CHOCADO SOLO UN OBJETO
        hayImpacto = Physics.Raycast(origen.position,origen.forward, out rh);
        texto.text = "" + hayImpacto;

        // origen , destino .
        // me dibujara hasta donde esta mi target esto no es lo que queremos
        //Debug.DrawLine(origen.position, target.position, Color.red, 30 );
        // DrawLine vector de posicion  este se usaria para lanzar un rayo 
        Debug.DrawLine(origen.position, origen.forward * 10000, Color.red, 30); //
        // posicion de comienzo , DrawRay vector de direccion.... Este es el correcto
        // DIBUJA EL RAYO PARA SABER SI ESTA BIEN
        //Debug.DrawRay(origen.position, origen.forward * 100, Color.red, 50); //

        // TENEMOS QUE SABER CON QUIEN HA IMPACTADO
        if (hayImpacto) {
            // SI TENEMOS EL COMPONENTE PODEMOS ACCEDER A SU GAMEOBJECT Y A SU NAME
            string nombreObjectoImpactado = rh.transform.gameObject.name;
            texto.text = nombreObjectoImpactado;
        }

    }*/

    // CON EL RAYCASTALL
    public void Disparar() {
        // LANZAMOS EL RAYO Y NOS DEVUELVE UN ARRAY
        RaycastHit[] rhs = Physics.RaycastAll(origen.position, origen.forward);
        // HA ENCONTRADO ALGO CON QUIEN HA CHOCADO
        if (rhs.Length != 0) {
            for ( int i = 0; i < rhs.Length; i++) {
                // LO SACAMOS POR LA CONSOLA MAS FACIL
                print(rhs[i].transform.gameObject.name);
            }
        }
    }
}
