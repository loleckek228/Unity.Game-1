using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    private float _speed = 0.15f;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        Vector2 offset = new Vector2(Time.time * _speed, 0);
        _renderer.material.mainTextureOffset = offset;
    }
}
