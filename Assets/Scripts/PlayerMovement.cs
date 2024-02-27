using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Setting")]

    [SerializeField] private float speed;
    [SerializeField] private float jumpp;

    [Header("Components")]
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private bool left_rihht;

    private void Update() 
    {
        Move();
    }

    private void Move()
    {
        rigidbody.velocity = new Vector2(Input.acceleration.x * speed, rigidbody.velocity.y);
        CheckFlip();
    }

    public void Jump()
    {
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpp);
    }

    private void CheckFlip()
    {
        if (Input.acceleration.x > 0 && !left_rihht)
        {
            Flip();
        }
        else if(Input.acceleration.x < 0 && left_rihht)
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        left_rihht = !left_rihht;
    }
}
