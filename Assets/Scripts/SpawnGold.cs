using System.Collections;
using UnityEngine;

public class SpawnGold : MonoBehaviour
{
	[SerializeField] private GameObject _gold;
	private bool _isReadyToSpawn;
	private bool _isPauseOfSpawnGold;

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
		float _countOfSpawn = 0;

		while (_countOfSpawn < 5)
		{
			yield return new WaitForSeconds(0.2f);
			Spawn();
			_countOfSpawn++;
		}

		StartCoroutine(WaiterToSpawn());
	}

	private void Spawn()
	{
		Instantiate(_gold, transform.position, Quaternion.identity);
	}
}
