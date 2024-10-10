using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    [SerializeField] private int velocidad;
    [SerializeField] Vector3 velocidadVector= new Vector3 (0,1,0);
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //transform.eulerAngles = new Vector3(45, 45, 45);
        GetComponent<Rigidbody>().AddTorque(velocidadVector * velocidad, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddTorque(velocidadVector * velocidad * Time.deltaTime, Space.World);
        ////Las variabes 
    }
}