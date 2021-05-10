using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRockets : MonoBehaviour
{
    private float waitTime = 1.0f;
    private float timer = 0.0f;
    private bool fireonce = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            if (fireonce)
            {
                GameObject bullet = GameObject.Instantiate(GetComponent<Fighter>().bullet, transform.position + transform.forward * 2, transform.rotation);
                fireonce = false;
            }
           
        }
        
    }
}
