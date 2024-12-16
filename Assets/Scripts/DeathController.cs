using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject deathEffect;
    public int scoreOnDeath;

    public void Kill()
    {
        Die();
    }

    // Update is called once per frame
    void Die()
    {
        GameManager.score += scoreOnDeath;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
