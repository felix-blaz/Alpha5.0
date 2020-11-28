﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBolderBack : MonoBehaviour
{
    private float zSpawnPos = -6;
    private float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < zSpawnPos && gameObject.CompareTag("Bolder"))
        {
            Destroy(gameObject);
        }
    }
}
