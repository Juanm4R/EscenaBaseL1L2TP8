using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizarMonitor : MonoBehaviour
{
    [SerializeField] int randomNumber;
    [SerializeField] GameObject[] Pantallas;
    int pantallasAzules = 0;
    // Start is called before the first frame update
    void Start()
    {
        Pantallas = GameObject.FindGameObjectsWithTag("Pantalla");
        for (int i = 0; i < Pantallas.Length; i++)
        {
            Pantallas[i].SetActive(false);
        }
        while (pantallasAzules < 5)
        {
            GenerarNroAleatorio();
            Pantallas[randomNumber].SetActive(true);
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
