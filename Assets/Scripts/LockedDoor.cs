/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour {

    public PlayerController m_SomeScript;
    public int MaxCount = 11;

    void OnTriggerEnter(Collider other)
    {
        if (m_SomeScript.count == MaxCount)
        {
            if (other.gameObject.CompareTag("Goal"))
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}
*/