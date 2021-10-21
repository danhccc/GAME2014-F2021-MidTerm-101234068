/*
 Name               :   Hancong Zhang
 Student ID         :   101234068
 File               :   BulletController.cs
 Description        :   This is the Bullet Controller script
 Date Modified      :   Oct 20, 2021
 Revision History   :   - Changing the bullet direction from Verticle to Horizontal
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float HorizontalSpeed;
    public float verticalBoundary;
    public float HorizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Changed the bullet to travel in horizontal direction (Left to right)
    private void _Move()
    {
        // transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
        transform.position += new Vector3(HorizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > HorizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
