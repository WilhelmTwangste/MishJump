using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    public Transform enemy;

    private int count;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }
    // Update is called once per frame
    private void Update()
    {
        RaycastHit2D hitInto = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        transform.position = Vector2.MoveTowards(transform.position, enemy.position, speed * Time.deltaTime);
        if (hitInto.collider != null)
        {
            if (hitInto.collider.CompareTag("Enemy"))
            {
                hitInto.collider.GetComponent<Enemy>().TakeDamage(damage);
                Destroy(gameObject);
            }
        }
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
