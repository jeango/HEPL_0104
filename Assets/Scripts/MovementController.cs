using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;
    public Rigidbody2D body;

    private void MoveDynamic()
    {
        body.velocity = direction * speed;
    }

    void FixedUpdate()
    {
        MoveDynamic();
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    public void SetDirection(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    
    private void Move()
    {
         var currentPosition = transform.position;
         currentPosition += Time.deltaTime * speed * (Vector3)direction.normalized;
         transform.position = currentPosition;       
    }


    
}
