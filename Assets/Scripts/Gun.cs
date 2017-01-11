using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefub;
    public Transform bulletSpawn;
    public float bulletSpeed = 10f;
    public float coolDown = 0.2f;

    private float lastShotTimeStamp = 0;

    public void Fire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefub, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
        lastShotTimeStamp = Time.time;
    }

    public bool isReadyToShoot()
    {
        return (Time.time >= lastShotTimeStamp + coolDown);
    }
}
