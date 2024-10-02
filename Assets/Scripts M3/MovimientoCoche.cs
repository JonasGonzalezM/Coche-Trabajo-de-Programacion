using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    [SerializeField] Vector3 movementInput = Vector3.zero;
    [SerializeField] Vector3 rotationAngle= Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movementInput.z = 3*Time.deltaTime;
            


        } 
        if (Input.GetKey(KeyCode.S))
        {
            movementInput.z = -3 * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            //movementInput.z = 3;
            rotationAngle.y = 45 * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.W))
        {
            //movementInput.z = 3;
            rotationAngle.y = -45 * Time.deltaTime;

        }


    }
}
