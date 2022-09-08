using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizarMonitor : MonoBehaviour
{
    [SerializeField] int randomNumber;
    [SerializeField] GameObject[] Pantallas;
    [SerializeField] GameObject[] Monitores;
    int pantallasAzules = 0;
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
            pantallasAzules++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarNroAleatorio()
    {
        randomNumber = Random.Range(0, 17);
    }
}
