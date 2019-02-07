using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_AttackPoint : MonoBehaviour
{
    public GameObject attackLeftHand, attackRightHand, attackLeftLeg, attackRightLeg;
    
    void LeftHandEnable()
    {
        attackLeftHand.SetActive(true);
    }

    void LeftHandDisable()
    {
        if (attackLeftHand.activeInHierarchy)
        {
            attackLeftHand.SetActive(false);
        }
    }

    void RightHandEnable()
    {
        attackRightHand.SetActive(true);
    }

    void RightHandDisable()
    {
        if (attackRightHand.activeInHierarchy)
        {
            attackRightHand.SetActive(false);
        }
    }

    void LeftLegEnable()
    {
        attackLeftLeg.SetActive(true);
    }

    void LeftLegDisable()
    {
        if (attackLeftLeg.activeInHierarchy)
        {
            attackLeftLeg.SetActive(false);
        }
    }

    void RighLegEnable()
    {
        attackRightLeg.SetActive(true);
    }

    void RightLegDisable()
    {
        if (attackRightLeg.activeInHierarchy)
        {
            attackRightLeg.SetActive(false);
        }
       
    }
}
