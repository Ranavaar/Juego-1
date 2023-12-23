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
    public GameObject Life;
    public GameObject Life2;
    public GameObject Life3;
    public int vidas;
    

    void Start()
    {
        puntos = 0;
        vidas = 3;

        PosicionInicial();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas <= 0)
        {
            Destroy(player);
            Destroy(Life3);
        }
        if (vidas <= 2)
        {
            Destroy(Life);
        }
        if (vidas <= 1)
        {
            Destroy(Life2);
        }
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
    public void pierdeVidas()
    {
        vidas -= 1;
        
       

    }

}
