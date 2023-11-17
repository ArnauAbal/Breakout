using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class pelota : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    public Vector2 direccion;
    public puntuacion vidas;
    public GameObject Pelota;
    private void Start()
    {
        vidas = FindObjectOfType<puntuacion>();
        vidas.pelotas = vidas.pelotas + 1;
    }

    void Update()
    {
        transform.position = transform.position + (Vector3)direccion * velocidad * Time.deltaTime;
       
    }
    public void Duplicarse()
    {
      
        GameObject bola1 = Instantiate(Pelota, transform.position, transform.rotation);
        bola1.GetComponent<pelota>().direccion=-direccion;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vertical")
        {
            direccion = new Vector2(-direccion.x, direccion.y);
        }
        if (collision.gameObject.tag == "Horizontal")
        {
            direccion = new Vector2(direccion.x, -direccion.y);
        }
        if (collision.gameObject.tag == "Porteria")
        {
         
            if (vidas.pelotas <=1)
            {
                vidas.vidas = vidas.vidas - 1;
                Spawn();

            }
            else
            {
                vidas.pelotas -= 1;
                Destroy(gameObject);

            }
            if (vidas.vidas == 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Bloque")
        {
            Vector3 dir = transform.position - collision.transform.position;
            dir.Normalize();

            direccion = dir;
        }
        if (collision.gameObject.tag == "Jugador")
        {
            Vector3 dir = transform.position - collision.transform.position;
            dir.Normalize();

            direccion = dir;
        }
       
    }

    public void Spawn()
    {
        transform.position = new Vector3(0, 0);
        float x = Random.Range(-1f, 1f);
        if (x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = Random.Range(-1f, 1f);
        direccion = new Vector2(x, y);

    }
}
