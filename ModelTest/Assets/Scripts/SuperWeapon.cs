using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperWeapon : MonoBehaviour
{
    public Transform target;
    public GameObject bulletPrefab;
    public bool shooting = true;
    public int fireRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
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
