using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    public GameObject Left_LegPoint, Left_HandPoint, Right_LegPoint, Right_HandPoint;

    void SetLeftLegPointOn()
    {
        Left_LegPoint.SetActive(true);
    }

    void SetLeftLegPointOff()
    {
        if (Left_LegPoint.activeInHierarchy)
        {
            Left_LegPoint.SetActive(false);
        }
    }

    void SetLeftHandPointOn()
    {
        Left_HandPoint.SetActive(true);
    }

    void SetLeftHandPointOff()
    {
        if (Left_HandPoint.activeInHierarchy)
        {
            Left_HandPoint.SetActive(false);
        }
    }


    void SetRightLegPointOn()
    {
        Right_LegPoint.SetActive(true);
    }

    void SetRightLegPointOff()
    {
        if (Right_LegPoint.activeInHierarchy)
        {
            Right_LegPoint.SetActive(false);
        }
    }

    void SetRightHandPointOn()
    {
        Right_HandPoint.SetActive(true);
    }

    void SetRightHandPointOff()
    {
        if (Right_HandPoint.activeInHierarchy)
        {
            Right_HandPoint.SetActive(false);
        }
    }

}
