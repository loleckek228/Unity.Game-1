using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObjects : MonoBehaviour
{
	private float _border = -15f;

    private void Update()
	{
        if (transform.position.y < _border || transform.position.x < _border)
		{
			Destroy(gameObject);
		}
	}
}
