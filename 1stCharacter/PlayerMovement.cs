
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 6f;
    private float rotation_Y = 180f;

    private Rigidbody m_body2b;
    private PlayerAnimation m_playerAnim;

    private enum ComboPunch
    {
        NONE,
        PUNCH1,
        PUNCH2,
        PUNCH3,
        OUT
    }

    private float default_time = 0.4f;
    private float current_time;
    private bool activate_time = false;
    private ComboPunch current_state_punch = ComboPunch.NONE;


    private enum ComboKick
    {
        NONE,
        KICK1,
        KICK2,
        KICK3,
        OUT
    }

    private ComboKick current_state_kick = ComboKick.NONE;
    // Start is called before the first frame update
    void Awake()
    {
        m_body2b = GetComponent<Rigidbody>();
        m_playerAnim = GetComponentInChildren<PlayerAnimation>();
    }

    void Update()
    {
        Rotation();
        ComboPunchAttack();
        ComboKickAttack();
        TimeCombo();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        JumpAndCrouch();
    }

    void Movement()
    {
        m_body2b.velocity = new Vector3(Input.GetAxisRaw(Axis.HORIZONTAL)*MoveSpeed
                , 0,0);
    }

    void Rotation ()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL) <0 )
        {
            transform.rotation = Quaternion.Euler(0f, -rotation_Y, 0f);
        } else if (Input.GetAxisRaw(Axis.HORIZONTAL) > 0)
        {
            transform.rotation = Quaternion.Euler(0f,0f,0f);
        }
        
    }

    void JumpAndCrouch()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_playerAnim.Jump();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_playerAnim.Crouch(true);
        } else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            m_playerAnim.Crouch(false);
        }
    }

    void ComboPunchAttack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            activate_time = true;
            current_time = default_time;
            current_state_punch++;
            if (current_state_punch ==ComboPunch.OUT)
            {
                return;
            }
            if (current_state_punch == ComboPunch.PUNCH1)
            {
                m_playerAnim.FirstPunch();
            }
            if (current_state_punch == ComboPunch.PUNCH2)
            {
                m_playerAnim.SecondPunch();
            }
            if (current_state_punch == ComboPunch.PUNCH3)
            {
                m_playerAnim.ThirdPunch();
            }
        }
    }

    void ComboKickAttack()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            activate_time = true;
            current_time = default_time;
            current_state_kick++;
            if (current_state_kick == ComboKick.OUT)
            {
                return;
            }
            if (current_state_kick == ComboKick.KICK1)
            {
                m_playerAnim.FirstKick();
            }
            if (current_state_kick == ComboKick.KICK2)
            {
                m_playerAnim.SecondKick();
            }
            if (current_state_kick == ComboKick.KICK3)
            {
                m_playerAnim.ThirdKick();
            }
        }
    }

    void TimeCombo()
    {
        if (activate_time)
        {
            current_time -= Time.deltaTime;
            if (current_time <= 0f)
            {
                activate_time = false;
                current_state_punch = ComboPunch.NONE;
                current_state_kick = ComboKick.NONE;
            }
        }
    }
   
}
