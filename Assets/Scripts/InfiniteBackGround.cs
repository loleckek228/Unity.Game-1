using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackGround : MonoBehaviour
{
	[SerializeField] private Transform _backGroung1;
	[SerializeField] private Transform _backGroung2;
	[SerializeField] private Transform _cameraPosition;

	public Transform[] _spawnersArray;

	private bool _whichBackGround = true;
	private float _currentBackGroungSize = 19.2f;

	private void Update()
	{
		if (_cameraPosition.position.x > _currentBackGroungSize)
		{
			if (_whichBackGround)
			{
				GetPosition(_backGroung1, 38.4f, '+');
			}
			else
			{
				GetPosition(_backGroung2, 38.4f, '+');
			}

			_currentBackGroungSize += 19.2f;

            for (int i = 0; i < _spawnersArray.Length; i++)
			{
				GetPosition(_spawnersArray[i], 19.2f, '+');
			}

			_whichBackGround = !_whichBackGround;
		}

		if (_cameraPosition.position.x + 19.2f < _currentBackGroungSize)
		{
			if (_whichBackGround)
			{
				GetPosition(_backGroung2, 38.4f, '-');
			}
			else
			{
				GetPosition(_backGroung1, 38.4f, '-');
			}
			_currentBackGroungSize -= 19.2f;
			for (int i = 0; i < _spawnersArray.Length; i++)
			{
				GetPosition(_spawnersArray[i], 19.2f, '-');
			}

			_whichBackGround = !_whichBackGround;
		}
	}

	private void GetPosition(Transform position, float distance, char operation)
	{
		if (operation.Equals('+'))
		{
        	position.localPosition = new Vector2(position.localPosition.x + distance, 0);
		}
		else if (operation.Equals('-'))
		{
			position.localPosition = new Vector2(position.localPosition.x - distance, 0);
		}
	}
}