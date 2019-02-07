using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Crouch(bool crouch)
    {
        anim.SetBool(AnimationTag.CROUCH, crouch); //crouch
    }
    public void Jump()
    {
        anim.SetTrigger(AnimationTag.JUMP); //jump
    }
    public void Death ()
    {
        anim.SetTrigger(AnimationTag.DEATHH);
    }
    public void Behit()
    {
        anim.SetTrigger(AnimationTag.BEHITT);
    }
    public void FirstPunch()
    {
        anim.SetTrigger(AnimationTag.FIRST_P);
    }
    public void SecondPunch()
    {
        anim.SetTrigger(AnimationTag.SECOND_P);
    }
    public void ThirdPunch()
    {
        anim.SetTrigger(AnimationTag.THIRD_P);
    }
    public void FirstKick()
    {
        anim.SetTrigger(AnimationTag.FIRST_K);
    }
    public void SecondKick()
    {
        anim.SetTrigger(AnimationTag.SECOND_K);
    }
    public void ThirdKick()
    {
        anim.SetTrigger(AnimationTag.THIRD_K);
    }
}
