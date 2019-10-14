
using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] RandomObjectsToSpawn;
    [SerializeField] private float MinDelay;
    [SerializeField] private float MaxDelay;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(MinDelay, MaxDelay));
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(RandomObjectsToSpawn[Random.Range(0, RandomObjectsToSpawn.Length -1)], transform.position, Quaternion.identity);

        StartCoroutine(Spawner());
    }
}


