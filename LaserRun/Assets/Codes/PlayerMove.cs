using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;
    public float speed;
    public float jump;

    Rigidbody physic;
    Animator anim;

    void Start()
    {
        physic = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Player.transform.Translate(0, 0, Time.deltaTime * speed);
            //anim.SetTrigger("Run");
        }
        if (Input.GetKey(KeyCode.A))
        {

            Player.transform.Translate(Time.deltaTime * -speed, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {

            Player.transform.Translate(Time.deltaTime * speed, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

                Player.transform.Translate(0, Time.deltaTime * jump, 0);
                anim.SetTrigger("Jump");


        }
    }
}
