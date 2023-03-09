
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class barradevida : MonoBehaviour
{
    public Image vida;

    public float  vidaactual;

        public float  vidamaxima;


    // Update is called once per frame
    void Update()
    {
        vida.fillAmount = vidaactual / vidamaxima;
    }
}
