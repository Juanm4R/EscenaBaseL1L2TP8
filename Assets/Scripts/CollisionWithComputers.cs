using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithComputers : MonoBehaviour
{
    bool colisiona;
    [SerializeField] GameObject ArreglarUI;
    GameObject pantalla;
    GameObject BoxMonitor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colisiona)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pantalla.SetActive(false);
                BoxMonitor.GetComponent<BoxCollider>().enabled = false;
                ArreglarUI.SetActive(false);
                pantalla.tag = "Pantalla";
            }
        }
    }

    void OnTriggerEnter(Collider Collided)
    {
        if (Collided.gameObject.CompareTag("Monitor"))
        {
            ArreglarUI.SetActive(true);
            colisiona = true;
            pantalla = Collided.gameObject.transform.GetChild(0).gameObject;
            BoxMonitor = Collided.gameObject;
        }
    }
    void OnTriggerExit(Collider Collided)
    {
        if (Collided.gameObject.CompareTag("Monitor"))
        {
            ArreglarUI.SetActive(false);
            colisiona = false;
        }
    }
}
