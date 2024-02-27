using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] public Rigidbody2D rigidbody;
    [SerializeField] public float jumpForce;
    [SerializeField] public float speed;
    [SerializeField] public float accelar;
    [SerializeField] private bool left_rihht;

    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            accelar = Input.acceleration.x;
        }
        if (Input.acceleration.x > 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            if (Input.acceleration.x > 90)
            {
                transform.Translate(Vector2.left * speed * speed * Time.deltaTime);
            }
        }
        if (Input.acceleration.x < 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            if (Input.acceleration.x < -90)
            {
                transform.Translate(Vector2.left * speed * speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    } 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.velocity = new Vector2(0, 0);
        rigidbody.AddForce(Vector2.up * speed * jumpForce, ForceMode2D.Impulse);
    }
}
