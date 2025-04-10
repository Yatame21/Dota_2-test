using System;
using UnityEngine;
using UnityEngine.UI;

public class TextLanguage : MonoBehaviour
{
    public string language; 
    private Text text; 
    public string textRu; 
    public string textEng; 

    void Start()
    {
        text = GetComponent<Text>(); 
        
        if (!PlayerPrefs.HasKey("Language"))
        {
            PlayerPrefs.SetString("Language", "Eng"); 
        }
        
        language = PlayerPrefs.GetString("Language"); 
        UpdateText(); 
    }

    private void Update()
    {
        string newLanguage = PlayerPrefs.GetString("Language"); 

        if (newLanguage != language) 
        {
            language = newLanguage; 
            UpdateText();
        }
    }

    private void UpdateText() 
    {
       
        if (text == null)
        {
            return; 
        }

    
        if (language is "" or "Eng")
        {
            text.text = textEng; 
        }
        else if (language == "Ru")
        {
            text.text = textRu; 
        }
    }
}
