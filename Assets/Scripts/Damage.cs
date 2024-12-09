using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToDamage;
    public bool canKill;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToDamage.Contains(other.tag))
        {
            KillOrDestroy(other.gameObject);
        }
    }

    void KillOrDestroy(GameObject other)
    {
        if (!canKill)
        {
            Destroy(other);
            return;
        }
        var deathCtrl = other.GetComponent<DeathController>();
        if (!deathCtrl)
        {
            Destroy(other);
            return;
        }
        deathCtrl.Kill();
    }
}
