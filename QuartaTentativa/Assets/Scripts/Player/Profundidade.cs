using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profundidade : MonoBehaviour
{

    [ExecuteInEditMode]
    [RequireComponent(typeof(Renderer))]
    public class DepthSortByY : MonoBehaviour
    {

        private const int IsometricRangePerYUnit = 100;

        void Update()
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.sortingOrder = -(int)(transform.position.z * IsometricRangePerYUnit);
        }
    }

}
