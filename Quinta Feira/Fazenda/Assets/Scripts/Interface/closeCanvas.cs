using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closeCanvas : MonoBehaviour
{
    public Button btnClose;
    public Canvas canvasTarget;

    void Start()
    {
        btnClose.onClick.AddListener(closeCanvasTarget);
    }

    void closeCanvasTarget ()
    {
        canvasTarget.gameObject.SetActive(false);
    }
}
