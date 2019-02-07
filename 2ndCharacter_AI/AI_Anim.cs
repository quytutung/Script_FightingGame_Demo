using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Anim : MonoBehaviour
{
    private Animator Eanim;

    void Awake()
    {
        Eanim = GetComponent<Animator>();
    }

    public void Epunch()
    {
        Eanim.SetTrigger(EnemyTag.E_punch);
    }
    public void Ekick()
    {
        Eanim.SetTrigger(EnemyTag.E_kick);
    }
    public void Ecrouch(bool crouch)
    {
        Eanim.SetBool(EnemyTag.E_crouch, crouch);
    }
    public void Edeath()
    {
        Eanim.SetTrigger(EnemyTag.E_death);
    }
    public void Ebehit()
    {
        Eanim.SetTrigger(EnemyTag.E_behit);
    }

}
