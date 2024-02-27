using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerenter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();

        if (player != null && collision.attachedRigidbody.velocity.y < 0 && collision.transform.position.y - collision.bounds.size.y / 2 > transform.position.y)
        {
            player.Jump();
        }
    }
}
