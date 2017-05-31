using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text WinText;

    private Rigidbody rb;
    public int count = 0;
    public int RestartLevel;
    Collider Goal;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Count: " + count.ToString();
        WinText.text = "";
        Scene loadedLevel = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            //Debug.Log("OnTriggerEnter() was called");
            other.gameObject.SetActive (false);
            count = count + 1;
            setCountText();
          //  Debug.Log("Score is now " + count);
            Destroy(other.gameObject);
        }
            
    }

    void setCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if(count>= 11)
        { 
            WinText.text = "Gattem!";
        }
    }

    public void NextLevel(int x)
    {
        SceneManager.LoadScene(x);
    }

    public int GetCount()
    {
        return count;
    }
}