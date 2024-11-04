using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToDamage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToDamage.Contains(other.tag))
        {
            Destroy(other.gameObject);
        }
    }
}