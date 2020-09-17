using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 1;

    [SerializeField]
    float count = 1;

    [SerializeField]
    int goToLevel = 1;

    public bool isGrounded;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        bool player_jump = Input.GetButtonDown("Jump");

        rb.velocity = new Vector3(h * moveSpeed,
                                  rb.velocity.y,
                                  v * moveSpeed);

        if (player_jump && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x,
                                  jumpSpeed,
                                  rb.velocity.z);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("coin"))
        {
            Destroy(collision.gameObject);

            count = count - 1;

            Debug.Log("you have " + count + " coins left");

            if(count == 0)
            {
                SceneManager.LoadScene(goToLevel);
                GameManager.instance.AddScore(goToLevel + 1);
            }
        }
    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }

}
