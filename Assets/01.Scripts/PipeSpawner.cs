using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnCoolTime = 1f;

    private float currentTime = 0;
    private float minHeight = -1f;
    private float maxHeight = 2f;

    private void Update() 
    {
        currentTime += Time.deltaTime;

        if(currentTime > spawnCoolTime) {
            PipeSpawn();
            currentTime = 0;
        }
    }
    private void PipeSpawn()
    {
        GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);

        pipe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
