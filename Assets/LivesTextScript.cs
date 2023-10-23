using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesTextScript : MonoBehaviour
{
    public TMP_Text textComponent;

    public int vidas = 3;

    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Vidas: " + vidas;
    }


}
