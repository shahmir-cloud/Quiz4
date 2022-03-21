using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8;
    private float HorizontalInput;
    public int playerlife=3;
    public bool stop =false;
    private Rigidbody playerRb;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        playerRb.velocity = Vector3.right * HorizontalInput * speed;
        if(transform.position.x > 8)
        {
            transform.position = new Vector3(8, transform.position.y, transform.position.z);
        }

        else if(transform.position.x < -8)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space) && stop==false)
        {
            Instantiate(bullet, transform.position + new Vector3(0, 0, 1), bullet.transform.rotation);
        }

    }

   
}
