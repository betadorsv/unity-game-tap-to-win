using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform firePoint1;
    public GameObject bulletPrefab1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // yield return new WaitForSeconds(3);
       if(Input.GetButton("Fire1"))
        Shoot();

    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab1, firePoint1.position, firePoint1.rotation);

    }
}
