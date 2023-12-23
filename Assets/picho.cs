using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picho : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            manager.GetComponent<gamemanager>().PosicionInicial();

        }
    }
}
