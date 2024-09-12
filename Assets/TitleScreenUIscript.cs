using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenUIscript : MonoBehaviour
{
    // Start is called before the first frame update
    
    //SceneLoading Method
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(1);
    }
}
