using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
   
          public Color startColor = Color.green;
    public Color endcolor = Color.black;

    [Range(0, 10)]
    public float speed = 1;

    Image imgcomp;

    void Awake()
    {
        imgcomp = GetComponent<Image>();
    }

    void Update()
    {
        imgcomp.color = Color.Lerp(startColor, endcolor, Mathf.PingPong(Time.time * speed, 1));
    }

}