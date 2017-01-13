using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float bulletLifeTime = 2f;
    public int damage = 10;

    void Start()
    {
        Destroy(gameObject, bulletLifeTime);
    }

    void OnCollisionEnter(Collision other
        )
    {
        if (other.gameObject.tag == "Shootable")
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damage);

        }
        Destroy(gameObject);
    }
}
