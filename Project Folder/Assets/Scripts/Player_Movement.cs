using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    // public Vector3 carPos;
    public float speed = 5f;
    private int lane = 2;

    public Score_Manager scoreValue;

    public GameObject gameOverPanel;
    public GameObject gamePauseButton;
    
    // Start is called before the first frame update
    void Start()
    {
        // carPos = car.position;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && lane!=3 && Time.timeScale!=0) 
        {
            transform.position += new Vector3(3f, 0, 0);
            lane++;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && lane!=1 && Time.timeScale!=0)
        {
            transform.position -= new Vector3(3f, 0, 0);
            lane--;
        }

        /*carPos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        carPos.x = Mathf.Clamp(carPos.x, -2.14f, 2.14f);
        car.position = carPos;*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Time.timeScale = 0;
            gamePauseButton.SetActive(false);
            gameOverPanel.SetActive(true);
        }

        if (collision.gameObject.tag == "coin")
        {
            scoreValue.score += 5;
            Destroy(collision.gameObject);
        }
    }
}
