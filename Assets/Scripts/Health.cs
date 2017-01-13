using UnityEngine;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int health = maxHealth;
    public RectTransform healthBar;
    public bool destroyOnDeath;
    Vector3 spawnPoint = Vector3.zero;


    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
            else
            {
                health = maxHealth;
                transform.position =  new Vector3(Random.Range(-8f, 8f), 0f, Random.Range(-8f, 8f));
            }
        }

        healthBar.sizeDelta = new Vector2(health * 2, healthBar.sizeDelta.y);
    }
}
