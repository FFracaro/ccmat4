using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerXZ : MonoBehaviour
{
    public GameObject Player;
    public float Speed = 0f;

    private Rigidbody PlayerBody;
    private Animator Animador;
    private SpriteRenderer Renderer;
    private float moveX, moveZ;

    // Use this for initialization
    void Start()
    {
        PlayerBody = Player.GetComponent<Rigidbody>();
        Animador = Player.GetComponent<Animator>();
        Renderer = Player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        Vector3 VectorXZ = new Vector3(moveX, 0, moveZ);
        VectorXZ = VectorXZ.normalized * Speed * Time.deltaTime;
        PlayerBody.MovePosition(PlayerBody.transform.position + VectorXZ);

        //PlayerBody.velocity = new Vector2(moveX * Speed, PlayerBody.velocity.y);

        Animador.SetFloat("Speed", Mathf.Abs(moveX));

        if (Input.GetKey(KeyCode.D))
        {
            if (Renderer.flipX)
            {
                Renderer.flipX = false;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (!Renderer.flipX)
            {
                Renderer.flipX = true;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            // Subindo
        }

        if (Input.GetKey(KeyCode.A))
        {
            // frente do personagem
        }
    }
}
