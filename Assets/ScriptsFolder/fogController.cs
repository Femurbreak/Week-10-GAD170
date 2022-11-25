using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cylinder") {
            other.gameObject.GetComponent<PlayerStats>().poisoned = true;
        }
    }

    private void OnTriggerLeave(Collider other)
    {
            if (other.gameObject.name == "Cylinder") {
                other.gameObject.GetComponent<PlayerStats>().poisoned = false;
            }
    }
    
}
