using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonMove : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody DemonBody;

    private DemonAnim childrenAnim;

    // Start is called before the first frame update
    void Awake()
    {
        DemonBody = GetComponent<Rigidbody>();
        childrenAnim = GetComponentInChildren<DemonAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimationWalk();
    }

    void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {
        DemonBody.velocity = new Vector3(Input.GetAxisRaw(Axis.HORIZONTAL)*speed,DemonBody.velocity.y,
            Input.GetAxisRaw(Axis.VERTICAL)*speed);
    }
    void Rotation ()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL)<0)
        {
            DemonBody.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
        } else if (Input.GetAxisRaw(Axis.HORIZONTAL) > 0)
        {
            DemonBody.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    void SetAnimationWalk ()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL)!=0)
        {
            childrenAnim.walk(true);
        } else 
        {
            childrenAnim.walk(false);
        }
    }

}
