using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject deathEffect;

    public void Kill()
    {
        Die();
    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
