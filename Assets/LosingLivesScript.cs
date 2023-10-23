using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosingLivesScript : MonoBehaviour
{

    public GameObject cube;
    LivesTextScript LivesTextScript;

    void Start()
    {
        LivesTextScript = FindObjectOfType<LivesTextScript>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LivesTextScript.vidas = LivesTextScript.vidas - 1;

        }
    }
}
