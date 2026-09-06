using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public int damageAmount = 10;
    public float attackRate = 1f;
    private float nextAttackTime = 0f;

    private Transform player;
    private PlayerHealth playerHealth;

    public float attackDistance = 1.2f;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (player == null) return;

        // Only measure distance to the PLAYER, not the gun
        float dist = Vector2.Distance(transform.position, player.position);

        if (dist <= attackDistance && Time.time >= nextAttackTime)
        {
            int beforeHP = playerHealth.currentHealth;

            playerHealth.TakeDamage(damageAmount);
            nextAttackTime = Time.time + attackRate;

            // If HP reset → player lost a life → destroy zombie
            if (beforeHP > 0 && playerHealth.currentHealth == playerHealth.maxHealth)
            {
                Destroy(gameObject);
            }
        }
    }
}
