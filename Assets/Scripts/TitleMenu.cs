using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour
{
    public static TitleMenu Instance;

    public TMP_InputField inputName;
    public string enteredName;
    public string savedName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        savedName = null;
    }
    public void EnterName()
    {
        enteredName = inputName.text;
        if (enteredName != null)
        {
            savedName = enteredName;
        }
        Debug.Log(savedName);
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
#endif
    }

}
