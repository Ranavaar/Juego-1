using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //manager.GetComponent<gamemanager>().sumapuntos(10);
            manager.GetComponent<gamemanager>().sumaMonedas();
            Destroy(gameObject);
        }
    }
}
