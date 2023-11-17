using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class limites : MonoBehaviour
{
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > MaxX)
        {
            transform.position = new Vector2(MaxX, transform.position.y);
        }
        if (transform.position.x < MinX)
        {
            transform.position = new Vector2(MinX, transform.position.y);
        }
        if (transform.position.y > MaxY)
        {
            transform.position = new Vector2(transform.position.x, MaxY);
        }
        if (transform.position.y < MinY)
        {
            transform.position = new Vector2(transform.position.x, MinY);
        }
    }
    private void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }
}
