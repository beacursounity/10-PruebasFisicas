using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPlanetasScript : MonoBehaviour {

    //[SerializeField] GameObject prefabPlaneta;
    // PARA RECOGER NUESTRAS POSICIONES GO VACIOS
    [SerializeField] Transform tX0Y0Z0;
    [SerializeField] Transform tX1;
    [SerializeField] Transform tY1;
    [SerializeField] Transform tZ1;

    // HACEMOS UNA TABLA PORQUE VAN A SER VARIOS ELEMENTOS
    [SerializeField] GameObject[] prefabsPlaneta;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 10; i++ ) {
            GenerarPlaneta();
        }

    }
	
	// Update is called once per frame
	void GenerarPlaneta () {
        // LO INSTANCIAMOS
        // ALEATORIO en X,Y y Z
        float x = Random.Range(tX0Y0Z0.position.x, tX1.position.x);
        float y = Random.Range(tX0Y0Z0.position.y, tY1.position.y);
        float z = Random.Range(tX0Y0Z0.position.z, tZ1.position.z);

        // POSICION ALEATORIA DE UN ARRAY DE PREFABS
        int posicionAleatoria = Random.Range(0, prefabsPlaneta.Length);

        // INSTANCIAMOS EL PREBAF
        GameObject planeta = Instantiate(prefabsPlaneta[posicionAleatoria]);
        // Y LE ASIGNAMOS LA POSICION
        planeta.transform.position = new Vector3(x, y, z);
    }
}
