using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;

    public float speed, rotSpeed;

    public GameObject ps;
    public bool catchaP;
    public float timeDisable;
    public float timer;

    void Start()
    {
        //rig = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Move();
        Catcha();
    }

    void Move()
    {
        /*Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rig.AddForce(move * speed);*/

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalInput, 0, forwardInput);
        move.Normalize();

        transform.Translate(move * speed * Time.deltaTime, Space.World);

        if (move != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotSpeed * Time.deltaTime);
        }

    }

    void Catcha()
    {
        if (catchaP)
        {
            ps.SetActive(true);

            timer +=  Time.deltaTime;

            if (timer >= timeDisable)
            {
                ps.SetActive(false);
                timer = 0;
                catchaP = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Catch"))
        {
            catchaP = true;
        }
    }
}
