using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muertebloque : MonoBehaviour
{
    public bool filaA;
    public bool filaB;
    public bool filaC;
    public bool filaD;
    public bool filaE;
    public bool filaF;
    public puntuacion punt;
    public GameObject PowerUp1;
    public GameObject PowerUp2;
    public GameObject PowerUp3;
    public int provavilidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Pelota")
        {
        Destroy(gameObject);
            if (filaA) 
            {
                punt.punt = punt.punt + 1;
            }
            if (filaB)
            {
                punt.punt = punt.punt + 2;
            }
            if (filaC)
            {
                punt.punt = punt.punt + 3;
            }
            if (filaD)
            {
                punt.punt = punt.punt + 4;
            }
            if (filaE)
            {
                punt.punt = punt.punt + 5;
            }
            if (filaF)
            {
                punt.punt = punt.punt + 6;
            }
        provavilidad=Random.Range(1, 10);
            if (provavilidad == 1)
            {
                Instantiate(PowerUp1,transform.position, transform.rotation);
            }
            if (provavilidad == 2)
            {
                Instantiate(PowerUp2, transform.position, transform.rotation);
            }
            if (provavilidad == 3)
            {
                Instantiate(PowerUp3, transform.position, transform.rotation);
            }
        }
    }
}
