using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    public Transform[] player;
    public Vector3 cameraPos;

    private float xMin, xMax, yMin, yMax;
    private float minDistance = 7f;

    void LateUpdate()
    {
       
        xMin = xMax = player[0].position.x;
        yMin = yMax = player[0].position.y;

        for (int i =0; i <player.Length;i++)
        {
            if (player[i].position.x<xMin)
            {
                xMin = player[i].position.x;
            }
            if (player[i].position.x > xMax)
            {
                xMax = player[i].position.x;
            }
            if (player[i].position.y < yMin)
            {
                yMin = player[i].position.y;
            }
            if (player[i].position.y > yMax)
            {
                yMax = player[i].position.y;
            }
        }

        float xMiddle = (xMin + xMax) / 2;
        float yMiddle = (yMin + yMax) / 2;

        float distance = xMax - xMin;

        if (distance<minDistance)
        {
            distance = minDistance;
        }

        transform.position = new Vector3(xMiddle, yMiddle + cameraPos.y, -distance - cameraPos.z);

    }

}
