using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public bool isStart;
    public bool isQuit;
    public bool isCredit;

    private void OnMouseUp()
    {
        if(isStart)
        {
            SceneManager.LoadScene("MiniGame");
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (isQuit)
        {
            Application.Quit();
        }

        if (isCredit)
        {
            SceneManager.LoadScene("ThanksForPlay");
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
