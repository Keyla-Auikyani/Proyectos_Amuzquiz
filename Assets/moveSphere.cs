using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSphere : MonoBehaviour
{
    float speed = 5;
    Vector3 direction = new Vector3(0, 0, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = 0;
            direction.y = 0;
        direction.z = 0;
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
