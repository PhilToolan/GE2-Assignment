using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRockets : MonoBehaviour
{
    public float waitTime = 1.0f;
    private float timer = 0.0f;
    public bool fireonce = true;
    public bool firemultiple = false;
    private bool shooting = false;
    public int fireRate = 2;

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
            if (firemultiple)
            {
                shooting = true;
            }
           
        }
        
    }

    private void OnEnable()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            if (shooting)
            {
                GameObject bullet = GameObject.Instantiate(GetComponent<Fighter>().bullet
                    , transform.position + transform.forward * 2
                    , transform.rotation
                    );

            }
            yield return new WaitForSeconds(1.0f / (float)fireRate);
        }
    }
}

