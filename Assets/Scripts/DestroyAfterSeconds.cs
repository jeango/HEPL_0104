
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float delay;
    // Start is called before the first frame update
    void OnEnable()
    {
        SelfDestruct();
    }

    void SelfDestruct()
    {
        Destroy(gameObject, delay);
    }

}
