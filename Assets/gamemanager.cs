using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int puntos;
    public Transform[] InicialPosition;
    public Transform[] InicialPositionCam;

    public GameObject player;
    public GameObject Cam;

    public Text TextoCoins;

    private int coins;
    public int vidas;

    public GameObject Life;
    public GameObject Life2;
    public GameObject Life3;
    
    public GameObject gameOver;
    public GameObject ganador;

    public byte pantallaActual;

    
    

    void Start()
    {
        puntos = 0;
        vidas = 3;

        PosicionInicial();
        gameOver.SetActive(false);
        ganador.SetActive(false);
       
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
       

        if (pantallaActual==0)
        {
            player.transform.position = InicialPosition[0].position;
            Cam.transform.position = InicialPositionCam[0].position;
        }
        else if (pantallaActual==1)
        {
            player.transform.position = InicialPosition[1].position;
            Cam.transform.position = InicialPositionCam[1].position;
        }
        else
        {
            player.transform.position = InicialPosition[2].position;
            Cam.transform.position = InicialPositionCam[2].position;
        }

        if (pantallaActual > 3 )
        {
            ganador.SetActive(true);
            player.SetActive(false);
        }

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
        vidas--;

        if (vidas <= 2)
        {
            Life3.SetActive(false);
        }
        if (vidas <= 1)
        {
            Life2.SetActive(false);
        }
        if (vidas <= 0)
        {

            Life.SetActive(false);
            player.GetComponent<PlayerController>().enabled = false;
            gameOver.SetActive(true);
        }

    }

}
