﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb2d;
    
    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float direction = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(direction * _speed, _rb2d.velocity.y);
        _rb2d.velocity = playerVelocity;
        SwapFacing(direction);
    }

    private void SwapFacing(float direction)
    {
        bool playerHorizontalSpeed = Mathf.Abs(_rb2d.velocity.x) > Mathf.Epsilon;
        if (playerHorizontalSpeed)
            transform.localScale = new Vector2 (Mathf.Sign(direction), transform.localScale.y);
    }
}
