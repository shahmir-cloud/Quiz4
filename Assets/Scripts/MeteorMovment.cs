using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour
{
    private float speed = 5;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.z < -8)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.playerlife--;
            Debug.Log(player.playerlife);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
