using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateParticle : MonoBehaviour
{
    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Deactivation", timer);
    }
    
    void Deactivation()
    {
        gameObject.SetActive(false);
    }
}
