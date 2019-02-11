using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    public Transform player1;
    public Vector3 cameraPos;

    
    void Awake()
    {
        player1 = GameObject.FindWithTag(TAG.PLAYE_TAG).transform;
    }
    

    void FixedUpdate()
    {
        transform.position = player1.position + cameraPos;
    }

}
