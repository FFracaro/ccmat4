using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class reloadLevel : MonoBehaviour
{
    public Button btnReload;

    // Use this for initialization
    void Start ()
    {
        btnReload.onClick.AddListener(callFinal);
	}

    void callFinal()
    {
        #if UNITY_STANDALONE
                        //Quit the application
                        Application.Quit();
        #endif

        #if UNITY_EDITOR
                        //Stop playing the scene
                        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}
