using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Awake()
    {
        
            DontDestroyOnLoad(this.gameObject);
        
        


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("ice scene",LoadSceneMode.Single);
        }
        
        
    }
}
