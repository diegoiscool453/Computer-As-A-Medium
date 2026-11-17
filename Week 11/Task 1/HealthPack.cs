using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player == null) return;

        if (player.health >= player.maxHealth) return;

        player.health = Mathf.Min(player.health + healAmount, player.maxHealth);

        Destroy(gameObject);
    }
}