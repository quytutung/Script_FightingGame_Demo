using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonComboAttack : MonoBehaviour
{
    private DemonAnim comboChildren;

    private enum AttackCombo
    {
        NONE,
        PUNCH1,
        PUNCH2,
        KICK,
        OUT
    }

    private bool activeTimer = false;
    private float default_time = .5f;
    private float current_time;
    private AttackCombo current_state_attack = AttackCombo.NONE;


    // Start is called before the first frame update
    void Awake()
    {
        comboChildren = GetComponentInChildren<DemonAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        ActiveComboAttack();
        TimeComboChange();
    }

    void ActiveComboAttack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            activeTimer = true;
            current_time = default_time;
            current_state_attack++;

            if (current_state_attack == AttackCombo.OUT)
            {
                return;
            }
            if (current_state_attack == AttackCombo.PUNCH1)
            {
                comboChildren.punchLeft();
            }
            if (current_state_attack == AttackCombo.PUNCH2)
            {
                comboChildren.punchRight();
            }
            if (current_state_attack == AttackCombo.KICK)
            {
                comboChildren.mmaKicking();
            }
            
        }
    }

    void TimeComboChange()
    {
        if (activeTimer)
        {
            current_time -= Time.deltaTime;
            if (current_time <= 0f)
            {
                current_state_attack = AttackCombo.NONE;
                activeTimer = false;
            }
        }
    }
}
