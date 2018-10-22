using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCameraXZ : MonoBehaviour
{
    [SerializeField]
    private float maximoX;
    [SerializeField]
    private float minimoX;
    [SerializeField]
    private float minimoZ;
    [SerializeField]
    private float maximoZ;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minimoX, maximoX), transform.position.y, Mathf.Clamp(player.position.z-1, minimoZ, maximoZ));
    }
}
