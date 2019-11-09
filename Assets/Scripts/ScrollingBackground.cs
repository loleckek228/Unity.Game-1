﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
	private float _speed = 0.15f;

	private void Update()
	{
		Vector2 offset = new Vector2(Time.time * _speed, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
