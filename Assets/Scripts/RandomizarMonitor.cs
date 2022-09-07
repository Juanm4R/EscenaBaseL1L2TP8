using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizarMonitor : MonoBehaviour
{
    [SerializeField] int randomNumber;
    [SerializeField] GameObject[] Monitores;
    int monitoresEliminados;
    // Start is called before the first frame update
    void Start()
    {
        Monitores = GameObject.FindGameObjectsWithTag("Monitor");
        while (monitoresEliminados != 4)
        {
            GenerarNroAleatorio();
            Monitores[randomNumber].SetActive(false);
            monitoresEliminados++;
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
