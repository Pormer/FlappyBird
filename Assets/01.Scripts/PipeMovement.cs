using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < -12) {
            Destroy(gameObject);
        }
    } 
}
