using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel2 : MonoBehaviour
{

    void OnTriggerEnter()
    {
        SceneManager.LoadScene("MiniGame3");
    }

}
