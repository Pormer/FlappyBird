using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private MeshRenderer meshRenderer;

    private void Awake() 
    {
        meshRenderer = GetComponent<MeshRenderer>();   
    }

    private void Update() 
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);    
    }
}
