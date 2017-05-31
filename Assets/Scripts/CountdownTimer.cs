using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

    float Timer = 61;
    public Text TimeText;
    //private AudioSource _explosion;

    void Start()
    {
        Scene loadedLevel = SceneManager.GetActiveScene();
    }

	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        setTimeText();
	}

    void setTimeText()
    {
        if(Timer > 0)
        {
            TimeText.text = "" +(int)Timer;
        }
        else
        {
            TimeText.text = "Time's up!";
            //_explosion.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
