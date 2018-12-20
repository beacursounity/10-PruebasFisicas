using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaScript : MonoBehaviour {

    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform puntoGeneracion;
    // RECOGEMOS LA ESFERA PARA QUE SOLO SE MUEVA ESO CUANDO NOS MOVAMOS
    // CON LAS FLECHAS 
    //[SerializeField] Transform esferaCanyon;
    [SerializeField] Transform baseCanyon;
    [SerializeField] Transform ejeCanyon;

    // FUERZA DE LA BALA
    [SerializeField] int force = 5000;
	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
    
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject proyectil = Instantiate(prefabProyectil, 
                puntoGeneracion.position, 
                puntoGeneracion.rotation);
            proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * Time.deltaTime * force);
        }
        float xR = Input.GetAxis("Vertical");
        float yR = Input.GetAxis("Horizontal");
        
        // ME SIGUE A LAS TECLAS 
        baseCanyon.Rotate(0, yR, 0); // MUEVO EL EJE Y EN HPRIZONTAL
        ejeCanyon.Rotate(xR*-1, 0, 0); // MUEVO EL EJE X EN VERTICAL


		
	}
}
