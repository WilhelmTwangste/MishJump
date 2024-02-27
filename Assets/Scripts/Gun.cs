using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public Transform shotPoint;
    public float offset;

    private float timeShots;
    public float startTimeShots;
    private int bulletCount;

    public Transform enemy;

    //void Start()
    //{
    //    enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    //}
    // Update is called once per frame
    void Update()
    { 
        if (timeShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                //transform.position = Vector2.MoveTowards(transform.position, enemy.position, offset * Time.deltaTime);
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeShots = startTimeShots;
                bulletCount++;
                if (bulletCount > 5)
                {
                    bulletCount--;
                    Destroy(GameObject.Find("atack(Clone)"));
                }
            }
        }
        else
        {
            timeShots -= Time.deltaTime;
        }
        
    }
}
