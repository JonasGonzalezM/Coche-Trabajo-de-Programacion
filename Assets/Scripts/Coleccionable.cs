using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimietoPlataforma : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private int velocidad = 3;
    [SerializeField] Vector3 velocidadVector = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer <= 5)
        {
            transform.Translate(velocidadVector * velocidad * Time.deltaTime);
            if (timer >= 5)
            {
                timer -= Time.deltaTime;
                transform.Translate(velocidadVector * -velocidad * Time.deltaTime);

            }

        }
        timer = 0;

        
        //else
        //{
        //    timer += Time.deltaTime;
        //}

    }
}