using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllBall : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _countOfGold;
    [SerializeField] private Text _sumOfGold;
    private bool _isStarted;
    private Rigidbody2D _rigidbody2D;
    
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _isStarted = true;
    }
 
    private void Update()
    {
        if (_isStarted)
        {
            _sumOfGold.text = "Points: " + _countOfGold;
        }

        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gold"))
        {
            Destroy(collision.gameObject);
            _countOfGold++;
        }
    }
}
