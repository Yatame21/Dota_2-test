using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswereSystem : MonoBehaviour
{
    public GameObject _falseTrigger;
    public GameObject _trueTrigger;
    public GameObject _falsePanel;
    public GameObject _truePanel;

    public bool isTrue = false;

    public AudioSource myFx;
    public AudioClip trueFx;
    public AudioClip falseFx;

    public void Answer()
    {
        OnPlayerAnswer(isTrue);

        if (isTrue)
        {
            _truePanel.SetActive(true);
            _trueTrigger.SetActive(true);
            if (myFx != null && trueFx != null)
            {
                myFx.PlayOneShot(trueFx);
            }
        }
        else
        {
            StartCoroutine(ShowFalsePanelAndReturn());
        }
    }

    private IEnumerator ShowFalsePanelAndReturn()
    {
        _falsePanel.SetActive(true);
        _falseTrigger.SetActive(true);
        
        if (myFx != null && falseFx != null)
        {
            myFx.PlayOneShot(falseFx);
        }

        // ?????
        yield return new WaitForSeconds(5f);

        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.BackToMenu();
        }
    }

    public void OnPlayerAnswer(bool isCorrect)
    { 
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.CheckAnswer(isCorrect);
        }
    }   
}
