
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


   

    // Update is called once per frame
    void Update()
    {
        
        vida.fillAmount = vidaactual / vidamaxima;

        //vidaactual = anim.GetComponent<barradevida>().


    }
  


   

    




   /*private void OnCollisionStay2D(Collision2D collision)
     {
         if (collision.collider.CompareTag("Enemigo"))
         {

             vidaactual = 10;
         }
     }*/
}
