using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callCanvasConfirmarCompra : MonoBehaviour
{
    public Button btnComprar;
    public Canvas confirmarCompra;

	// Use this for initialization
	void Start ()
    {
        btnComprar.onClick.AddListener(chamarConfirmarCompra);
	}
	
    void chamarConfirmarCompra ()
    {
        confirmarCompra.gameObject.SetActive(true);
    }
}
