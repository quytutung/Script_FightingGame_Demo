using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Move : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody AI_body;
    private AI_Anim enemyAnim;

    private Transform playerTarget;

    public float attack_Distance = 1f;
    private float chase_player_attack = 1f;

    private float current_attack_time;
    private float default_attack_time = 2f;

    private bool followPLayer, attackPLayer;
   
    void Awake()
    {
        AI_body = GetComponent<Rigidbody>();
        enemyAnim = GetComponentInChildren<AI_Anim>();

        playerTarget = GameObject.FindWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        followPLayer = true;
        current_attack_time = default_attack_time;
    }

    // Update is called once per frame
    void Update()
    {
        AttackPLayer();
    }

    void FixedUpdate()
    {
        FollowPLayer();
    }

    void FollowPLayer()
    {
        if (!followPLayer)
            return;

        if (Vector3.Distance(transform.position, playerTarget.position) > attack_Distance)
        {
            transform.LookAt(playerTarget);
            AI_body.velocity = transform.forward * speed;
        }
        else if (Vector3.Distance(transform.position, playerTarget.position) <= attack_Distance)
        {
            AI_body.velocity = Vector3.zero;

            followPLayer = false;
            attackPLayer = true;
        }
    }

    void AttackPLayer()
    {
        if (!attackPLayer)
            return;

        current_attack_time += Time.deltaTime;

        if (current_attack_time > default_attack_time)
        {
            enemyAnim.Epunch();
            current_attack_time = 0f;
        }

        if (Vector3.Distance(transform.position,playerTarget.position) > (attack_Distance + chase_player_attack))
        {
            attackPLayer = false;
            followPLayer = true;
        }
    }
}
