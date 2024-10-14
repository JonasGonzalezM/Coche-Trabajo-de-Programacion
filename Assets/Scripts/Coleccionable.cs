using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private int velocidad = 3;
    [SerializeField] Vector3 direccionArriba = new Vector3(0, 1, 0);
    [SerializeField] Vector3 direccionAbajo = new Vector3(0, -1, 0);

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            transform.Translate(direccionArriba * velocidad * Time.deltaTime);

        }
        if (timer <= 2f)
        {
           timer=0;
           transform.Translate(direccionArriba * -velocidad * Time.deltaTime);

        }
        

        
        //else
        //{
        //    timer += Time.deltaTime;
        //}

    }
}