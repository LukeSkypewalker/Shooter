using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public RectTransform healthBar;
    public RectTransform maxHealthBar;
    public bool destroyOnDeath;

    private int health;

    void Start()
    {
        health = maxHealth;
        maxHealthBar.sizeDelta = new Vector2(health*2, maxHealthBar.sizeDelta.y);
        healthBar.sizeDelta = new Vector2(health*2, healthBar.sizeDelta.y);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
        }

        healthBar.sizeDelta = new Vector2(health*2, healthBar.sizeDelta.y);
    }
}
