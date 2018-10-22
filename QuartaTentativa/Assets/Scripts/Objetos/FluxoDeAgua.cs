using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluxoDeAgua : MonoBehaviour
{
    public GameObject floresta;
    public ParticleSystem pseudoAgua;

    private int growthStage = 0;
    private bool readyToCollect = false;

    public void turnWaterOn()
    {
        if (!readyToCollect)
        {
            growthStage += 1;
            floresta.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            pseudoAgua.Play();
            if (growthStage == 4)
            {
                growthStage = 0;
                readyToCollect = true;
            }
        }
        else
        {
            readyToCollect = false;
            floresta.transform.localScale -= new Vector3(2.0f, 2.0f, 2.0f);
        }
    }
}
