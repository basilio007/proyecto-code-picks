using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{

        public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();

    }

    public void Jugar2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void Salir1()
    {
        Debug.Log("Salir...");
        Application.Quit();

    }
    public void ModoMedio()
    {
        SceneManager.LoadScene("Beach.medio");
    }
    public void ModoDificil()
    {
        SceneManager.LoadScene("Beach.dificil");
    }
}


