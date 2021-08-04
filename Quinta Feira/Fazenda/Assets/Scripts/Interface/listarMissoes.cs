using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listarMissoes : MonoBehaviour
{
    public Button btnMissoes;
    public Canvas canvasMissoes;
    public Text missoes;

	// Use this for initialization
	void Start ()
    {
        btnMissoes.onClick.AddListener(mostrarMissoes);
	}
	
	void mostrarMissoes()
    {
        if (dataPersistence.ANIMAIS_ALIMENTADOS == 1 
            && dataPersistence.ANIMAIS_HIDRATADOS == 1 
            && dataPersistence.PLANTAS_HIDRATADAS == 1
            && !canvasMissoes.gameObject.activeSelf)
        {
            missoes.text = "Você completou todas as tarefas de hoje. Vá para casa, você merece um descanso! \n<Clique com o botão direito do mouse na casa perto do poço>";
            canvasMissoes.gameObject.SetActive(true);
        }
        else
        {
            canvasMissoes.gameObject.SetActive(true);
        }
    }
}
