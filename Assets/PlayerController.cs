using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public int velocidad = 10;
    public int salto = 10;

    public float VxMax = 10;
    public float VyMax = 1500;
    public float VxActual;
    public float VyActual;

    public bool isGrounded;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        VxActual = Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.x);

        if (Input.GetKey("right") || Input.GetKey("d"))
        {

            if (VxActual < VxMax)
            {
                //gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * velocidad * Time.deltaTime, ForceMode2D.Impulse);
                gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * velocidad * Time.deltaTime, ForceMode2D.Force);

            }


        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            if (VxActual < VxMax)
            {
                //gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * -velocidad * Time.deltaTime, ForceMode2D.Impulse);
                gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * -velocidad * Time.deltaTime, ForceMode2D.Force);


            }

        }
        if ((Input.GetKeyDown("up") || Input.GetKey("w")) && isGrounded == true)
        {


            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * salto, ForceMode2D.Force);

            isGrounded = false;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
            isGrounded = true;
    }


}
