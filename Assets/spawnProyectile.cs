using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProyectile : MonoBehaviour
{
    public GameObject proyectile;
    public moveCube moveCubeScript;
    
    void Start()
    {
        moveCubeScript = GameObject.FindObjectOfType<moveCube>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 cubePosition = moveCubeScript.transform.position;
            Instantiate(proyectile, cubePosition, Quaternion.identity);
        }

        
        
      
    }
}
