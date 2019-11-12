
using System.Collections;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _randomObjectsToSpawn;
    [SerializeField] private float _minDelay;
    [SerializeField] private float _maxDelay;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(_minDelay, _maxDelay));
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(_randomObjectsToSpawn[Random.Range(0, _randomObjectsToSpawn.Length - 1)], transform.position, Quaternion.identity);

        StartCoroutine(Spawner());
    }
}


