using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SairInfoBtn : MonoBehaviour
{

    public Button sair;
    public Button info;
    public Canvas canvas;

    // Use this for initialization
    void Start()
    {
        sair.onClick.AddListener(sairOnClick);
    }

    void sairOnClick()
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
