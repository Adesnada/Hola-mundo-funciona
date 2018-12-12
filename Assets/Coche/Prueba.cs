using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour {
    float velocidad = 10f;
    public KeyCode teclaAsignada = KeyCode.F1;
    public string nombre;
    int cuenta = 0;
    public Text marcador1;

    void Update() {
        if (cuenta>10)
            Debug.Log("El ganador es " + nombre);
        
        else
    
            if (Input.GetKeyDown ("F1"))
                this.transform.Translate(new Vector3(0, velocidad,0));
        cuenta++;
        marcador1.text = "" + cuenta;
        }
}
