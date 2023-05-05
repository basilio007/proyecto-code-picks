using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class FELICITACIONES_JUEGO : MonoBehaviour
{
    [SerializeField] private GameObject JUEGO_SUPERADO;
    private VIDA_BOSS DATOS_CHICA_ENEMIGA;

    private void Start()
    {
        DATOS_CHICA_ENEMIGA = GameObject.FindGameObjectWithTag("ENEMIGA").GetComponent<VIDA_BOSS>();
        DATOS_CHICA_ENEMIGA.MuerteChico += ActivarMenu;


    }

    private void ActivarMenu(object sender, EventArgs e)
    {
        JUEGO_SUPERADO.SetActive(true);
    }



    public void Menu()
    {
        SceneManager.LoadScene("Menu inicial-juego");
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}