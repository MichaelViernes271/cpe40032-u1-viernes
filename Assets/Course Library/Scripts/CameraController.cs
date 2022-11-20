﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	// Initializing camera position
	public GameObject player;
	private Vector3 offset = new Vector3(0, 5, -7);
		
    // Start is called before the first frame update
    void Start()
    {
    }

    // Updates after update method
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
