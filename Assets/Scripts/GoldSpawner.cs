using System.Collections;
using UnityEngine;

public class GoldSpawner : Spawner
{
    private void Start()
    {
        StartCoroutine(DelayBetweenGoldSpawn());
    }

    private IEnumerator DelayBetweenGoldSpawn()
    {
        while (true)
        {
            for (int i = 0; i < 5; i++)
            {
                yield return new WaitForSeconds(0.2f);
                Spawn();
            }
            yield return new WaitForSeconds(5);
        }
    }
}