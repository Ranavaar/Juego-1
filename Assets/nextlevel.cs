using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            manager.GetComponent<gamemanager>().pantallaActual++;

            manager.GetComponent<gamemanager>().PosicionInicial();


        }
    }


}
