using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int puntos;
    public Transform InicialPosition;
    public GameObject player;
    public Text TextoCoins;
    private int coins;
    

    void Start()
    {
        puntos = 0;

        PosicionInicial();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sumapuntos(int pts)
    {
        puntos += pts;

    }

    public void PosicionInicial()
    {
        player.transform.position = InicialPosition.position;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public void sumaMonedas()
    {
        coins++;
        puntos += 10;
        TextoCoins.text = coins.ToString();
    }

}
