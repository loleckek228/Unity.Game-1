using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldStorage : MonoBehaviour
{
    [SerializeField] private Text _goldCount;
    [SerializeField] private int _goldCountLabel;

    private void Start()
    {
        PrintText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gold"))
        {
            Destroy(collision.gameObject);
            _goldCountLabel++;
            PrintText();
        }
    }

    private void PrintText()
    {
        _goldCount.text = "Points: " + _goldCountLabel;
    }
}
