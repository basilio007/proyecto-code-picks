
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class barradevida : MonoBehaviour
{
    Animator anim;
    public Image vida;

    public float vidaactual;

    public float vidamaxima;

    public GameObject signObject;
    public GameObject enemy;

    private bool activated = false;

    // Update is called once per frame
    void Update()
    {
        
        vida.fillAmount = vidaactual / vidamaxima;


    }
  

    /*private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EL trigger ha entrado");

        if(other.tag == "Enemigo")
        {
            signObject.setActive(true);
            if (!activated)
            {
                activated = true;
                enemy.SetActive(true);
            }
        }


    }*/

   /* private void OnTriggerExit(Collider other)
    {
        Debug.Log("ha salido");

        if (other.tag == "Enemigo")
        {
            signObject.setActive(false);
           
            
        }


    }
    */




    private void OnCollisionStay2D(Collision2D collision)
     {
         if (collision.collider.CompareTag("Enemigo"))
         {

             vidaactual = 85;
         }
     }
}
