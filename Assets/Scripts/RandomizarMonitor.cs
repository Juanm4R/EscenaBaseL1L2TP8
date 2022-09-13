using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomizarMonitor : MonoBehaviour
{
    [SerializeField] int randomNumber;
    [SerializeField] GameObject[] PantallaActiva;
    [SerializeField] GameObject[] Pantallas;
    [SerializeField] GameObject[] Monitores;
    int pantallasAzules = 0;
    float Timer = 0;
    int TimerCuantoEs = 3;
    // Start is called before the first frame update
    void Start()
    {
        Pantallas = GameObject.FindGameObjectsWithTag("Pantalla");
        Monitores = GameObject.FindGameObjectsWithTag("Monitor");
        for (int i = 0; i < Pantallas.Length; i++)
        {
            Pantallas[i].SetActive(false);
            Monitores[i].GetComponent<BoxCollider>().enabled = false;
        }
        while (pantallasAzules < 5)
        {
            GenerarNroAleatorio();
            Pantallas[randomNumber].SetActive(true);
            Monitores[randomNumber].GetComponent<BoxCollider>().enabled = true;
            Pantallas[randomNumber].tag = "PantallaActiva";
            pantallasAzules++;
        }
        if (Timer >= 10)
        {
            GenerarNroAleatorio();
            Pantallas[randomNumber].SetActive(true);
            Monitores[randomNumber].GetComponent<BoxCollider>().enabled = true;
            Pantallas[randomNumber].tag = "PantallaActiva";
        }
    }
    // Update is called once per frame
    void Update()
    {
        PantallaActiva = GameObject.FindGameObjectsWithTag("PantallaActiva");
        Timer += Time.deltaTime;

        if (Timer >= TimerCuantoEs)
        {
            GenerarNroAleatorio();
            Pantallas[randomNumber].SetActive(true);
            Monitores[randomNumber].GetComponent<BoxCollider>().enabled = true;
            Pantallas[randomNumber].tag = "PantallaActiva";
            TimerCuantoEs = TimerCuantoEs + 3;
        }
        if (PantallaActiva.Length == 0)
        {
            SceneManager.LoadScene("Ganar");
        }
        if (PantallaActiva.Length == Pantallas.Length)
        {
            SceneManager.LoadScene("Perder");
        }
    }

    void GenerarNroAleatorio()
    {
        randomNumber = Random.Range(0, 17);
    }
}
