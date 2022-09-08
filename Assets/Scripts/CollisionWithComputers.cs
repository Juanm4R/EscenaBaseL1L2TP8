using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithComputers : MonoBehaviour
{
    bool colisiona;
    [SerializeField] GameObject ArreglarUI;
    GameObject pantalla;
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
