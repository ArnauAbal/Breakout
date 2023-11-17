using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class movimientopala : MonoBehaviour
{
    public float velocidad;
    public puntuacion pelotas;
    public Vector2 direccion;
    public GameObject Pelotas;
    public float tiempo = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pelotas.pelotas == 0)
        {
            Instantiate(Pelotas);
        }



        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, vertical, 0) * velocidad * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Poweup1")
        {
            GameObject bola1 = Instantiate(Pelotas, transform.position, transform.rotation);
            bola1.GetComponent<pelota>().Spawn();
        }
        if (collision.gameObject.tag == "Powerup2")
        {
            GameObject bola2 = Instantiate(Pelotas, transform.position + Vector3.up, transform.rotation);
            bola2.GetComponent<pelota>().direccion = new Vector2(-0.5f, 1);
            GameObject bola3 = Instantiate(Pelotas, transform.position + Vector3.up, transform.rotation);
            bola3.GetComponent<pelota>().direccion = new Vector2(0.5f, 1);
            GameObject bola4 = Instantiate(Pelotas, transform.position + Vector3.up, transform.rotation);
            bola4.GetComponent<pelota>().direccion = new Vector2(0, 1);
        }
        if (collision.gameObject.tag == "Powerup3")
        {
            List<pelota> Listapelota = FindObjectsOfType<pelota>().ToList();
            for (int i = 0; i < Listapelota.Count; i++)
            {
                Listapelota[i].Duplicarse();
            }
        }


    }
}

