using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Movement : MonoBehaviour
{
    public Renderer meshRenderer;
    public float speed;
    private float timer = 0;
    private float interval = 2;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
     
        if(speed < 3)
        {
            if (timer < interval)
            {
                timer += Time.deltaTime;
            }
            else
            {
                speed = speed + 0.1f;
                timer = 0;
            }
        }
    }
}
