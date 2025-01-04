using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    private Animator monsterAnimator;

    private void Start()
    {
        // This will fetch the Animator from the same GameObject 
        // that this script is attached to
        monsterAnimator = GetComponent<Animator>();
    }

    public void Hit()
    {
        monsterAnimator.SetTrigger("endOfLine");
        // deal damage to player, etc.
    }
}
