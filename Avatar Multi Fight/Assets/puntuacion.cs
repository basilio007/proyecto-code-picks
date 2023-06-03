using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacion : MonoBehaviour
{

    public int score_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score_1 = score_1+CHICAPEGA.score;
    }
}
