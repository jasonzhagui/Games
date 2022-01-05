using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;
    Rigidbody rb;

    bool isAlive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isAlive)
        {
            return;
        }

        float zSpeed = Input.GetAxis("Vertical") * speed;
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        rb.AddForce(new Vector3(xSpeed,0,zSpeed));

        if(transform.position.y < -10)
        {
            isAlive = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
