using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonAnim : MonoBehaviour
{
    private Animator m_Anim;

    void Awake()
    {
        m_Anim = GetComponent<Animator>();
    }

    public void mmaKicking()
    {
        m_Anim.SetTrigger(DemonAnimationTag.MMAKICK);
    }

    public void punchLeft()
    {
        m_Anim.SetTrigger(DemonAnimationTag.PUNCHLEFT);
    }

    public void punchRight()
    {
        m_Anim.SetTrigger(DemonAnimationTag.PUNCHRIGHT);
    }
    public void walk(bool setWalk)
    {
        m_Anim.SetBool(DemonAnimationTag.WALK, setWalk);
    }
}
