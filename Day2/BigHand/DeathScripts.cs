using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScripts : MonoBehaviour
{

    private BigHand_Anim m_Death;

    public float health = 100f;

    // Start is called before the first frame update
    void Awake()
    {
        m_Death = GetComponentInChildren<BigHand_Anim>();
    }

    public void ApplyDamage(float damage, bool death)
    {
        if (!death)
        {
            return;
        }

        health -= damage;

        if (health <= 0f)
        {
            m_Death.Death();
            health = 0f;
        } 
    }
}
