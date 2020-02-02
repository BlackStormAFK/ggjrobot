using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController controller;
    public float speed;
    public float rspeed;
    private Rigidbody rb;
    private Vector3 direction;

    public Vector3 moveDirection;

    public float Force;

    public Vector3 startingPosition;

   

    void Start()
    {
        //controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        startingPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);*/
        Movement();

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(transform.forward * Force);
        }

        

    }

    void Movement()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        direction = new Vector3(x: horizontalMove, y: 0.0f, z: verticalMove);

        if(direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(a: transform.rotation, b: Quaternion.LookRotation(direction), t: rspeed * Time.deltaTime);
        }
        rb.MovePosition(transform.position + speed * Time.deltaTime * direction);
    }

   /* private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Spikes")
        {
            Debug.Log("You Died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Spikes")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            transform.position = startingPosition;
        }
        
    }


}

