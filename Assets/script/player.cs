using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private CharacterController controller;
    private bool start;

    public float speed;
    public float jump;
    public float gravity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        start = true;
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
            }
        }
        if (!start)
        {
            Vector3 direction = Vector3.forward * speed;
            controller.Move(direction * Time.deltaTime);
        }

    }
}
