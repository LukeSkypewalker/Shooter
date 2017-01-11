using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float bulletLifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, bulletLifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
