using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    [SerializeField] Vector3 movimientoDelante = new Vector3(0,1,0);
    [SerializeField] Vector3 Giro= Vector3.zero;
    [SerializeField] private int fuerza = 20;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        VelocidadM3();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    movementInput.z = 3*Time.deltaTime;
            


        //} 
        //if (Input.GetKey(KeyCode.S))
        //{
        //    movementInput.z = -3 * Time.deltaTime;

        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    //movementInput.z = 3;
        //    rotationAngle.y = 45 * Time.deltaTime;

        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //movementInput.z = 3;
        //    rotationAngle.y = -45 * Time.deltaTime;

        //}


    }

    void VelocidadM3()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {

            rb.AddForce(movimientoDelante * fuerza, ForceMode.Impulse);



        }
    }


}
