using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed;
    private Vector3 desiredDirection;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += desiredDirection * bulletSpeed * Time.deltaTime;
    }

    public void Movement(Vector3 direction, float speed)
    {
        desiredDirection = direction;
        bulletSpeed = speed;
    }
}
