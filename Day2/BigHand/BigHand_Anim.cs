using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHand_Anim : MonoBehaviour
{
    private Animator m_BighandAnim;

    void Awake()
    {
        m_BighandAnim = GetComponent<Animator>();
    }

    public void Death()
    {
        m_BighandAnim.SetTrigger(BighandAnimationTag.DEATH);
    }

    public void UpperPunch()
    {
        m_BighandAnim.SetTrigger(BighandAnimationTag.UPPERPUNCH);
    }

    public void HitReaction()
    {
        m_BighandAnim.SetTrigger(BighandAnimationTag.HITREACT);
    }
}
