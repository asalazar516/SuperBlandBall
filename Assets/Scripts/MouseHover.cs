using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.white;
	}

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void OnMouseExit () {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
