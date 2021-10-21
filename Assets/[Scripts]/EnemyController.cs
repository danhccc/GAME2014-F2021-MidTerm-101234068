/*
 Name               :   Hancong Zhang
 Student ID         :   101234068
 File               :   EnemyController.cs
 Description        :   This is the Enemy Controller script, it controls the boundaries and direction of enemy objects.
 Date Modified      :   Oct 20, 2021
 Revision History   :   - Changing the enemy positions and make them travel on y-axis, and also make boundaries on y-axis.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // public float horizontalSpeed;
    // public float horizontalBoundary;
    public float VerticalSpeed;
    public float VerticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, VerticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    // Check if enemy reach screen boundary, then change direction to opposite.
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= VerticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -VerticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
