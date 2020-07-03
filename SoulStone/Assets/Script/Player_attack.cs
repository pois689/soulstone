using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // 공격모션이 끝나면 웨폰 off
        MyCharacter2D myChar2D = FindObjectOfType<MyCharacter2D>();
        if (myChar2D != null)
        {
            myChar2D._weapon.gameObject.SetActive(true);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("attack", false);

        // 공격모션이 끝나면 웨폰 off
        MyCharacter2D myChar2D = FindObjectOfType<MyCharacter2D>();
        if (myChar2D != null)
        {
            myChar2D._weapon.gameObject.SetActive(false);
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
