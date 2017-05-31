using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

    PlayerController pc;
    public int LoadNextLevel;

    void Start()
    {
        pc = FindObjectOfType<PlayerController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (pc.GetCount() == 11)
        {
            pc.NextLevel(LoadNextLevel);
        }
    }
    /* public int countCoins = 0;
    public PlayerController _scriptP;
    private void Start()
    {
    }

    void Update()
    {    }

   /* public void OnMouseDown()
    {
      

        if (count >= 11) //put the amount you want here
        {
            SceneManager.LoadScene("MiniGame2");
        }
    }
    /* OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            count = count + 1;
        }
        if (count >= L1Goal)
        {
            SceneManager.LoadScene("MiniGame2");
        }
    }
    *
    void OnTriggerEnter()
    {
        //countCoins = _scriptP.count;
        //GameObject thePlayer = GameObject.Find("Player");
        //PlayerController otherScript = GetComponent<PlayerController>();
       // countCoins = otherScript.count;
        countCoins = 11;
        if (_scriptP.count >= 11)
        {
            SceneManager.LoadScene("MiniGame2");

        }
    }
    */
}
