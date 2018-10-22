using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluxoDeComida : MonoBehaviour
{
    public GameObject rabbits;

    private int rabbitsFed = 0;

    public void feedRabbits ()
    {
        if (rabbitsFed < 20)
        {
            rabbitsFed++;
            switch (rabbitsFed)
            {
                case 2:
                    rabbits.transform.Find("Rabbit0").gameObject.SetActive(true);
                    break;
                case 6:
                    rabbits.transform.Find("Rabbit2").gameObject.SetActive(true);
                    break;
                case 12:
                    rabbits.transform.Find("Rabbit3").gameObject.SetActive(true);
                    break;
            }
        }
        else
        {
            rabbitsFed = 0;
            rabbits.transform.Find("Rabbit0").gameObject.SetActive(false);
            rabbits.transform.Find("Rabbit2").gameObject.SetActive(false);
            rabbits.transform.Find("Rabbit3").gameObject.SetActive(false);
        }
    }
}
