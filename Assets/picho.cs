using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picho : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject manager;
    float tiempo;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tiempo = tiempo * Time.deltaTime;
            tiempo++;
            manager.GetComponent<gamemanager>().PosicionInicial();

            manager.GetComponent<gamemanager>().pierdeVidas();

        }
                     

        

    }
}
