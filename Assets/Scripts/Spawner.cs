using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _templates;

    [SerializeField] private float _minDelay;
    [SerializeField] private float _maxDelay;

    private void Start()
    {
        StartCoroutine(DelayBetweenSpawn());
    }

    private IEnumerator DelayBetweenSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(_minDelay, _maxDelay));
            Spawn();
        }
    }

    protected void Spawn()
    {
        Instantiate(_templates[Random.Range(0, _templates.Length - 1)], transform.position, Quaternion.identity);
    }
}