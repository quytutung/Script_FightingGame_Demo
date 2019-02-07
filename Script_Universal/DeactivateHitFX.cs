using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateHitFX : MonoBehaviour
{
    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disappear", timer);
    }
    
    void Disappear()
    {
        gameObject.SetActive(false);
    }
}
