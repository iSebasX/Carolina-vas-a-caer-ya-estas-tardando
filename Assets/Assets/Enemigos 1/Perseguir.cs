using UnityEngine;

public class Perseguir : StateMachineBehaviour
{
    ControladorEnemigos Ranita;
  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Ranita = animator.GetComponent<ControladorEnemigos>();
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Ranita.movimiento) 
        {
            Ranita.rigid.linearVelocity = new Vector2(animator.transform.right.x* Ranita.velocidad, Ranita.rigid.linearVelocityY);
        }
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Ranita.rigid.linearVelocity = new Vector2(0, Ranita.rigid.linearVelocityY);
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
