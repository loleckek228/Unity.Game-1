using System.Collections;
using UnityEngine;

public class TemplatesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _templates;
    [SerializeField] private float _minDelay;
    [SerializeField] private float _maxDelay;
    [SerializeField] private bool _isGold;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (true)
        {
            if (_isGold)
            {
                for (int i = 0; i < 5; i++)
                {
                    yield return new WaitForSeconds(0.2f);
                    Spawn();
                }
            }
            yield return new WaitForSeconds(Random.Range(_minDelay, _maxDelay));
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(_templates[Random.Range(0, _templates.Length - 1)], transform.position, Quaternion.identity);
    }
}


