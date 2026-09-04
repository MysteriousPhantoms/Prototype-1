using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private PlayerLives lives;

    void Start()
    {
        currentHealth = maxHealth;
        lives = GetComponent<PlayerLives>();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            currentHealth = maxHealth; // reset HP
            lives.LoseLife();          // lose a brain
        }
    }
}
