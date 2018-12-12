using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocheRojo : MonoBehaviour
{
    public string nombre;
    float velocidad = 15f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown("i"))
        {
            gameObject.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }

    }
}
