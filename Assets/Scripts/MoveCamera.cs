using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    private Vector3 _position;

    private void Start()
    {
        transform.position = _target.position;
    }

    private void Update()
    {
        _position = _target.position;
        _position.y = 0;
        _position.z = -10f;
        transform.position = Vector3.Lerp(transform.position, _position, _speed * Time.deltaTime);
    }
}
