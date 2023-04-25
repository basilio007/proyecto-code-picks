using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour

{
    [SerializeField] private GameObject botonPause;

    [SerializeField] private GameObject menuPause;



    public void Pause()
    {
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar ()
    {
        SceneManager.LoadScene("Menu inicial-juego");
       // UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}