using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeath : MonoBehaviour
{
    public GameObject projectilePrefab;
    PuntosScript puntosScript;

    private void Start()
    {
        puntosScript = FindObjectOfType<PuntosScript>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {

            puntosScript.puntos = puntosScript.puntos + 1;

            Destroy(collision.gameObject); 
            Destroy(gameObject); 
        }
    }

}