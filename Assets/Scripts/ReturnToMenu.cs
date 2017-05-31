using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {

    public bool isStart;

    private void OnMouseUp()
    {
        if(isStart)
        {
            SceneManager.LoadScene("Main Menu");
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
