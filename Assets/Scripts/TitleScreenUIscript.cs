using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenUIscript : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    private InputField inputField;


    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    private void Update()
    {
        if (inputField != null)
        {
            string inputText = inputField.text;
            textMeshProUGUI.text = inputText;
            Debug.Log(textMeshProUGUI);
        }
    }
    //SceneLoading Method
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(1);
    }
 }
