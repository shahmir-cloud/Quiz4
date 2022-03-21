using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    private float speed = 0.5f;
    private int life = 15;
    WaveManager wave;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        wave =GameObject.FindGameObjectWithTag("wave").GetComponent<WaveManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (life == 0)
        {
            Destroy(gameObject);
            wave.enemycount = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            life--;
            wave.score += 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            player.playerlife = 0;
        }
    }
}
