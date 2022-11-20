using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    private Vector3 Spin = new Vector3(0, 0, 1000);

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate( Spin * Time.deltaTime); 

    }
}
