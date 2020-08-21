using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Vector3 cubePosition;
    void Start()
    {
        
    }

    void Update()
    {
        if (cubePosition.x < 5)
        {
            cubePosition = transform.position;
            cubePosition.x += 10 * Time.deltaTime;
            transform.position = cubePosition;
        }
    }
}
