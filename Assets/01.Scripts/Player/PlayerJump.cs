using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float jumpPower = 5f;

    private Vector3 _direction;
    private PlayerInput _playerInput;

    
    private void Awake() 
    {
        _playerInput = GetComponent<PlayerInput>();    
    }

    private void Start() 
    {
        _playerInput.OnJumpEvent +=  HandleJumpEvent;   

        transform.position = new Vector2(transform.position.x, 0);
        _direction = Vector2.zero;
    }

    private void OnDestroy() 
    {
        _playerInput.OnJumpEvent -=  HandleJumpEvent;   
    }

    private void Update() 
    {
        GravitySetting();
    }

    private void GravitySetting()
    {
        _direction.y += gravity * Time.deltaTime;
        transform.position += _direction * Time.deltaTime;
    }

    private void HandleJumpEvent()
    {
        _direction = Vector2.up * jumpPower;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Obstacle")) {
            GameManager.Instance.GameOver();
        }
    }
}
