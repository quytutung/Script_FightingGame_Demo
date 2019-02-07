using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    public LayerMask collisionMask;

    public float radius = 1f;
    public float damage = 2f;

    public bool is_player, is_enemy;

    public GameObject hit_FX;

    // Update is called once per frame
    void Update()
    {
        DetecCollision();
    }

    void DetecCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionMask); // need a collider to implement
        // create an OverlapSphere at transform.postion with radius (invisible sphere)
        // and detec collision on collisionMask layer

        if (hit.Length > 0)
        {
            if (is_player)
            {
                Vector3 hitFX_Pos = hit[0].transform.position;

                hitFX_Pos.y += 3f;

                if (hit[0].transform.forward.x > 0)
                {
                    hitFX_Pos.x += 0.3f;
                } else if (hit[0].transform.forward.x < 0)
                {
                    hitFX_Pos.x -= 0.3f;
                }

                Instantiate(hit_FX, hitFX_Pos, Quaternion.identity);
            }
            gameObject.SetActive(false);
        }
    }
}
