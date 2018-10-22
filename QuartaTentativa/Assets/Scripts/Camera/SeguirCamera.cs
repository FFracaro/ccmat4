using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCamera : MonoBehaviour {
    [SerializeField]
    private float maximoX;
    [SerializeField]
    private float minimoX;
    [SerializeField]
    private float minimoY;
    [SerializeField]
    private float maximoY;
    public Transform player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minimoX, maximoX), Mathf.Clamp(player.position.y, minimoY, maximoY), transform.position.z);
	}
}
