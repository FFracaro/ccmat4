using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callComprarAnimais : MonoBehaviour
{
    public Button btnCallComprarAnimais;
    public Canvas Curral;
    public Canvas ComprarAnimais;

	// Use this for initialization
	void Start () {
        btnCallComprarAnimais.onClick.AddListener(chamarComprarAnimais);
	}
	
    void chamarComprarAnimais ()
    {
        ComprarAnimais.gameObject.SetActive(true);
        Curral.gameObject.SetActive(false);
    }

}
