using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playLeaveGame : MonoBehaviour
{
    public Button play;
    public Button leave;
    public Canvas canvas;
    public Canvas canvasHistoria;

	// Use this for initialization
	void Start ()
    {
        play.onClick.AddListener(jogarOnClick);
        leave.onClick.AddListener(sairOnClick);
	}

    void jogarOnClick ()
    {
        canvas.enabled = false;
        canvasHistoria.enabled = true;
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
