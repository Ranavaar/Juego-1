using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int velocidad = 10;
    public GameObject manager;
    public GameObject player;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * velocidad * Time.deltaTime, ForceMode2D.Force);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        velocidad = velocidad * -1;
       
        
        if (collision.gameObject.tag == "Player")
        {

            if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                manager.GetComponent<gamemanager>().PosicionInicial();

                manager.GetComponent<gamemanager>().pierdeVidas();

            }
            else
            {
                Destroy(gameObject);
            }
           

        }
    }
}
