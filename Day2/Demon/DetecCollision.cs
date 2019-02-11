using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecCollision : MonoBehaviour
{
    public LayerMask collisionLayer;

    private float radius = 1f;

    public bool is_PLayer;

    public GameObject hit_FX_prefab;

    // Update is called once per frame
    void Update()
    {
        Detection();
    }

    void Detection()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);

        if (hit.Length>0)
        {
            if (is_PLayer)
            {

                print("Detec appear...");

                hit[0].GetComponent<DeathScripts>().ApplyDamage(10f, true);
               
            }

            gameObject.SetActive(false);
        }
    }
}
