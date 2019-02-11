using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHand_Move : MonoBehaviour
{
    private Transform playerTarget;
    private Rigidbody bighandBody;
    private BigHand_Anim m_bighandAnim;

    private float attack_distance = 2f;
    private float chase_distance = 1f;

    public float speed = 4f;

    private bool followPlayer, attackPlayer;
    private float current_attack_time;
    private float default_attack_time = 1f;

    // Start is called before the first frame update
    void Awake()
    {
        playerTarget = GameObject.FindWithTag(TAG.PLAYE_TAG).transform;
        bighandBody = GetComponent<Rigidbody>();
        m_bighandAnim = GetComponentInChildren<BigHand_Anim>();
    }

    void Start()
    {
        followPlayer = true;
        attackPlayer = false;
        current_attack_time = default_attack_time;
    }
    // Update is called once per frame
    void Update()
    {
        AttackPlayer();
    }

    void FixedUpdate()
    {
        AImove();
    }

    void AImove()
    {
        if (!followPlayer)
        {
            return;
        }
        if (Vector3.Distance(transform.position, playerTarget.position) > attack_distance)
        {
            transform.LookAt(playerTarget);
            bighandBody.velocity = transform.forward * speed;

        }
        else if (Vector3.Distance(transform.position, playerTarget.position) <= attack_distance)
        {
            bighandBody.velocity = Vector3.zero;

            followPlayer = false;
            attackPlayer = true;
        }

    }

    void AttackPlayer()
    {
        if (!attackPlayer)
        {
            return;
        }

        current_attack_time += Time.deltaTime;

        if (current_attack_time > default_attack_time)
        {
            m_bighandAnim.UpperPunch();
            current_attack_time = 0f;
        }
        if (Vector3.Distance(transform.position,playerTarget.position) > (attack_distance + chase_distance))
        {
            attackPlayer = false;
            followPlayer = true;
        }
    }
}
