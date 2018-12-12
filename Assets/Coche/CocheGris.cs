using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocheGris : MonoBehaviour
{
    public string nombre;
    float velocidad = 15f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("right"))
        {
            this.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            this.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        gameObject.SetActive(false);

    }
}
