using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public bool shooting = false;
    public GameObject bulletPrefab;
    private float waitTime = 2.0f;
    private float timer = 0.0f;
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
            shooting = true;
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
                GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab
                    , transform.position + transform.forward * 2
                    , transform.rotation
                    );

            }
            yield return new WaitForSeconds(1.0f / (float)fireRate);
        }
    }
}
