using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimTest : MonoBehaviour
{
    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetIdleTrigger()
    {
        animator.SetTrigger("Idle");
    }

    public void SetWalkTrigger()
    {
        animator.SetTrigger("Walk");
    }

}
