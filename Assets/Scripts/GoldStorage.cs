using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldStorage : MonoBehaviour
{
	[SerializeField] private Text _countOfGold;
	[SerializeField] private float _countOfGoldLabel;

    private void Start()
    {
		PrintText(_countOfGold, _countOfGoldLabel);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Gold"))
		{
			Destroy(collision.gameObject);
			_countOfGoldLabel++;
			PrintText(_countOfGold, _countOfGoldLabel);
		}
	}

    private void PrintText(Text text, float gold)
	{
		text.text = "Points: " + gold;
	}
}
