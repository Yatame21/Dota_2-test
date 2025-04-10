using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour
{
    public void Ru()
    {
        PlayerPrefs.SetString("Language", "Ru"); 
        PlayerPrefs.Save(); 
    }
    
    public void Eng()
    {
        PlayerPrefs.SetString("Language", "Eng"); 
        PlayerPrefs.Save();
    }
}