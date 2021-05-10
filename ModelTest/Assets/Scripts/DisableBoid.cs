using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBoid : MonoBehaviour
{
    public GameObject main;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "303")
        {
            main.GetComponent<Boid>().enabled = false;
        }
    }
}
