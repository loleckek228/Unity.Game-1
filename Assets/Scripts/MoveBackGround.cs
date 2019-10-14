using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    [SerializeField] private Transform _backGroung1;
    [SerializeField] private Transform _backGroung2;
    [SerializeField] private Transform _cameraPosition;
    [SerializeField] private Transform _obstaclesSpawner;
    [SerializeField] private Transform _goldsSpawner;
    [SerializeField] private Transform _checkObjects;

    private bool _whichBackGround = true;
    private float _currentBackGroungSize = 19.2f;
   
    private void Update()
    {
        if (_cameraPosition.position.x > _currentBackGroungSize)
        {
            if (_whichBackGround)
            {
                _backGroung1.localPosition = new Vector2(_backGroung1.localPosition.x + 38.4f, 0);
            }
            else
            {
                _backGroung2.localPosition = new Vector2(_backGroung2.localPosition.x + 38.4f, 0);
            }
            _currentBackGroungSize += 19.2f;
            _obstaclesSpawner.localPosition = new Vector2(_obstaclesSpawner.localPosition.x + 19.2f, 0);
            _goldsSpawner.localPosition = new Vector2(_goldsSpawner.localPosition.x + 19.2f, 0);
            _checkObjects.localPosition = new Vector2(_checkObjects.localPosition.x + 19.2f, 0);

            _whichBackGround = !_whichBackGround;   
        }

        if (_cameraPosition.position.x + 19.2f < _currentBackGroungSize)
        {
            if (_whichBackGround)
            {
                _backGroung2.localPosition = new Vector2(_backGroung2.localPosition.x - 38.4f, 0);
            }
            else
            {
                _backGroung1.localPosition = new Vector2(_backGroung1.localPosition.x - 38.4f, 0);
            }
            _currentBackGroungSize -= 19.2f;
            _obstaclesSpawner.localPosition = new Vector2(_obstaclesSpawner.localPosition.x - 19.2f, 0);
            _goldsSpawner.localPosition = new Vector2(_goldsSpawner.localPosition.x - 19.2f, 0);
            _checkObjects.localPosition = new Vector2(_checkObjects.localPosition.x - 19.2f, 0);
            _whichBackGround = !_whichBackGround;
        }      
    }
}
