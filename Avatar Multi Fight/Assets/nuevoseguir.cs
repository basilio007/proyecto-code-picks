using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuevoseguir : StateMachineBehaviour
{

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float tiempoBase;

    private float tiempoSeguir;
    private Transform jugador;
    private Noumoviment chica;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        chica = animator.gameObject.GetComponent<Noumoviment>();
    }

    /* override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
     {
         animator.transform.position = Vector2.MoveTowards(animator.transform.position, jugador.position, velocidadMovimiento * Time.deltaTime);
         chica.Girar(jugador.position);
         tiempoSeguir -= Time.deltaTime;
         if(tiempoSeguir <= 0)
         {
             animator.setTrigger("volver");
         }

     }

     override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
     {


     }*/
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
