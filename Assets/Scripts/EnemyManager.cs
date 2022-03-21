using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int life = 1;
    WaveManager wave;
    // Start is called before the first frame update
    void Start()
    {
        wave =GameObject.FindGameObjectWithTag("wave").GetComponent<WaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(life==0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet"))
        {
            life--;
            wave.score += 10;
            wave.enemycount--;
            Destroy(collision.gameObject);
        }
    }
}
