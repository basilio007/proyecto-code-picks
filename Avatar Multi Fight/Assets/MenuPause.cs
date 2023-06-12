using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;

public class MenuPause : MonoBehaviour

{
    [SerializeField] private GameObject botonPause;

    [SerializeField] private GameObject menuPause;

    private bool JuegoPausado = false;

    private void Update()
    {
        // quan toco la tecla ESC em fara el menu de pausa
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Pause()
    {
        //QUAN FIQUEM APRETEM EL BOTO DE PAUSA O LA TECLA ESC S'ACTIVARA EL MENU PAUSAT I LO ALTRE HO TENIM DESACTIVAT 
        JuegoPausado =true;
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Reanudar()
    {
       // QUAN FIQUEM APRETEM AL MENU PAUSA  EL BOTO DE REANUDAR PODRAS REPENDRE LA PARTIDA 
        JuegoPausado = false;
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Reiniciar()
    {
        // QUAN FIQUEM APRETEM AL MENU PAUSA  EL BOTO DE REANUDAR PODRAS REINICIAR LA PARTIDA 
        JuegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Cerrar ()
    {
        Application.Quit();
        //SceneManager.LoadScene(0);
       // menuPause.SetActive(true);
        // SceneManager.LoadScene(0);
        // SceneManager.LoadScene("Menu inicial-juego");
        // UnityEditor.EditorApplication.isPlaying = false;

    }
}