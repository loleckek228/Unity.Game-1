using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldStorage : MonoBehaviour
{
	[SerializeField] private Text _sumOfGold;
	[SerializeField] private float _countOfGoldLabel;

    private void Start()
    {
		_sumOfGold.text = "Points: " + _countOfGoldLabel;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Gold"))
		{
			Destroy(collision.gameObject);
			_countOfGoldLabel++;
			_sumOfGold.text = "Points: " + _countOfGoldLabel;
		}
	}
}
