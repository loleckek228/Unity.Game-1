using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _authorsAnimator;

    public void Play()
    {
        SceneManager.LoadScene("level1");
    }

    public void Authors()
    {
        _authorsAnimator.SetBool("isOpen", !_authorsAnimator.GetBool("isOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
