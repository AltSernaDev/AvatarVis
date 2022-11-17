using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 4f;
    void Update()
    {
        //transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
        
        //transform.Rotate(new Vector3(rotationSpeed, 0, 0) * Time.deltaTime);
        
        //transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);

        //transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);

    }
}
