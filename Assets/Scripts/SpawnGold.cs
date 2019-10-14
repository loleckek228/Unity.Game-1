using System.Collections;
using UnityEngine;


public class SpawnGold : MonoBehaviour
{
    [SerializeField] private GameObject _gold;
    private bool _isReadyToSpawn;
    private bool _isPauseOfSpawnGold;
    private float _countOfSpawn;

    private void Update()
    {
        if (!_isReadyToSpawn)
        {
            if (!_isPauseOfSpawnGold)
            {
                _isPauseOfSpawnGold = true;
                StartCoroutine(WaiterBetweenSpawn());
                _countOfSpawn++;
            }
        }

        if (_countOfSpawn >= 5)
        {
            _isReadyToSpawn = true;
            _countOfSpawn = 0;
            StartCoroutine(WaiterToSpawn());
        }
    }

    private void Spawn()
    {
        Instantiate(_gold, transform.position, Quaternion.identity);
    }

    private IEnumerator WaiterToSpawn()
    {
        yield return new WaitForSeconds(5);
        _isReadyToSpawn = false;
    }

    private IEnumerator WaiterBetweenSpawn()
    {
        yield return new WaitForSeconds(0.2f);
        _isPauseOfSpawnGold = false;
        Spawn();
    }
}
