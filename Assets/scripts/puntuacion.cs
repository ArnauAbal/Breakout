using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class puntuacion : MonoBehaviour
{
    public int punt;
    public int vidas = 3;
    public TMP_Text puntText;
    public TMP_Text vidasText;
    public int pelotas=1;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntText.text = punt.ToString();
        vidasText.text = vidas.ToString();
    }
}
