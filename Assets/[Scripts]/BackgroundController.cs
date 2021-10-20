/*
 Name               :   Hancong Zhang
 Student ID         :   101234068
 File               :   BackgroundController.cs
 Description        :   This script control the movement and reset of the game background
 Date Modified      :   Oct 20, 2021
 Revision History   :   - Changing background movement from verticle to horizontal
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // public float verticalSpeed;
    public float HorizontalSpeed;
    // public float verticalBoundary;
    public float HorizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        // transform.position = new Vector3(0.0f, verticalBoundary);
        transform.position = new Vector3(HorizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        // transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
        transform.position -= new Vector3(HorizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -HorizontalBoundary)
        {
            _Reset();
        }
    }
}
