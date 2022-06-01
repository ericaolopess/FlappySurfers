using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private bool start;
    private Animator anin;

    public int contador;
    public Text pontos;

    public float speed;
    public float jump;
    public float gravity;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        pontos.text = "" + contador;

        controller = GetComponent<CharacterController>();
        anin = GetComponent<Animator>();
        start = true;

        anin.SetBool("idle", true);
        anin.SetBool("run", false);
        anin.SetBool("jump", false);
        anin.SetBool("slide",false);

    }

    // Update is called once per frame
    void Update()
    {


        if (start)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 direction = Vector3.forward * speed;
                controller.Move(direction * Time.deltaTime);
                start = false;

                contador += 100;
                pontos.text = "" + contador;

                anin.SetBool("idle", false);
                anin.SetBool("run", true);
                anin.SetBool("jump", false);
                anin.SetBool("slide", false);
            }
        }
        else
        {
            Vector3 direction = Vector3.forward * speed;
            controller.Move(direction * Time.deltaTime);
            contador += 100;
            pontos.text = "" + contador;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            float x = Input.GetAxis("Horizontal");
            Vector3 move = transform.right * x;
            controller.Move(move * speed * Time.deltaTime);
            anin.SetBool("idle", false);
            anin.SetBool("run", true);
            anin.SetBool("jump", false);
            anin.SetBool("slide", false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            anin.SetBool("idle", false);
            anin.SetBool("run", false);
            anin.SetBool("jump", true);
            anin.SetBool("slide", false);

        }

    }
}

