using System.Collections;
using UnityEngine;

public class SpawnGold : MonoBehaviour
{
    [SerializeField] private GameObject _gold;

    private void Start()
    {
        StartCoroutine(WaiterBetweenSpawn());
    }

    private IEnumerator WaiterToSpawn()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(WaiterBetweenSpawn());
    }

    private IEnumerator WaiterBetweenSpawn()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.2f);
            Spawn();
        }

        StartCoroutine(WaiterToSpawn());
    }

    private void Spawn()
    {
        Instantiate(_gold, transform.position, Quaternion.identity);
    }
}
