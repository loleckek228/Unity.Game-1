using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	[SerializeField] private Animator AuthorsAnimator;

    public void Play()
    {
        SceneManager.LoadScene("level1");
    }

    public void Authors()
    {
        AuthorsAnimator.SetBool("isOpen", !AuthorsAnimator.GetBool("isOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }    
}
