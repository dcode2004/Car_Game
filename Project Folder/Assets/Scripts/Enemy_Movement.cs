using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

        DeleteGameObject();
    }
    
    void DeleteGameObject()
    {
        if (transform.position.y < -25)
        {
            Destroy(gameObject);
        }
    }
}
