
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("Enemy health: " + health);

        if (health <= 0)
        {
            Debug.Log("Enemy destroyed!");
            Destroy(gameObject);
        }
    }
}
