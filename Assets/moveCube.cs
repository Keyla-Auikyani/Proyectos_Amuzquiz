using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    float speed = 5f;
    public Vector3 direction = new Vector3(0, 0, 0);
    void Start()
    {
        
    }

    
    void Update()
    {
        direction.x = 0;
        
        direction.z = 0;
        
        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1;
        }
        else if(Input.GetKey(KeyCode.S))
        { direction.y = -1; }
        else
        { direction.y = 0; }
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
