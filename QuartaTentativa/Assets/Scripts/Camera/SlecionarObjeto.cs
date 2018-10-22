using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlecionarObjeto : MonoBehaviour
{
    public LayerMask mask;
    public float MaxDistance = 100.0f;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit hit, hitPlayer;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Ray rayPlayer = new Ray(transform.position, transform.forward);
              

            if (Physics.Raycast(ray, out hit, MaxDistance, mask))
            {
                if (hit.transform != null)
                {
                    if (Physics.Raycast(transform.position, (hit.point - transform.position).normalized, out hitPlayer, MaxDistance, mask))
                    {
                        if (hitPlayer.distance <= 0.8f)
                        {
                            GameObject go = hitPlayer.transform.gameObject;
                            FluxoDeAgua fluxo = go.GetComponent<FluxoDeAgua>();
                            fluxo.turnWaterOn();
                        }
                        print(hitPlayer.distance);
                        print(hit.transform.name);
                        Debug.DrawRay(transform.position, (hit.point - transform.position).normalized * 5, Color.red, 2);
                    }
                    
                }

                //Debug.DrawLine(ray.origin, hit.point, Color.red);
            }
        }
	}
}
