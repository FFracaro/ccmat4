using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class returnToPreviousCanvas : MonoBehaviour
{
    public Button btnCloseReturn;
    public Canvas canvasAtual;
    public Canvas canvasAnterior;

	// Use this for initialization
	void Start()
    {
        btnCloseReturn.onClick.AddListener(voltarCanvasAnterior);
	}

    void voltarCanvasAnterior()
    {
        canvasAnterior.gameObject.SetActive(true);
        canvasAtual.gameObject.SetActive(false);
    }

}
