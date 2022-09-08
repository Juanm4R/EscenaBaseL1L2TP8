using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithComputers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }

    void OnTriggerEnter(Collider Collided)
    {
        if (Collided.gameObject.CompareTag("Monitor"))
        {
            ArreglarUI.SetActive(true);
        }
    }
    void OnTriggerExit(Collider Collided)
    {
        if (Collided.gameObject.CompareTag("Monitor"))
        {
            ArreglarUI.SetActive(true);
        }
    }
}
