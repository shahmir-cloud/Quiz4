using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject TestMeteor;
    public GameObject Meteor;
    public GameObject Boos;
    private int ColumnLength =2;
    private int RowHeight=8;
    public int wavenum = 1;
    public int score = 0;
    private float xposition=-7;
    private float zposition = 5;
    public int enemycount;
    private float delay=6;
    public bool stop = false;
    public GameObject[,] meteorArray;

    // Start is called before the first frame update
    void Start()
    {
        meteorArray = new GameObject[ColumnLength, RowHeight];
        SpawnEnemyWave();
        InvokeRepeating("MeteorSpawn", 2, delay);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(delay);
        
        if(enemycount==0)
        {
            wavenum++;
            delay=delay-1;
            ColumnLength++;
            meteorArray = new GameObject[ColumnLength, RowHeight];
            if(wavenum>4)
            {
                Instantiate(Boos, new Vector3(-0.13f, 1.5f, 8.71f), Boos.transform.rotation);
                enemycount = 1;
            }
            else
            {
                SpawnEnemyWave();
            }

        }
        
    }
    void SpawnEnemyWave()
    {
        enemycount = RowHeight * ColumnLength;
        for (int i = 0; i < ColumnLength; i++)
        {
            for (int j = 0; j < RowHeight; j++)
            {
                meteorArray[i, j] = (GameObject)Instantiate(TestMeteor, new Vector3(xposition, 0.6571962f, zposition), Quaternion.identity);
                xposition = xposition + 2;
            }
            xposition = -7;
            zposition = zposition - 2;
        }
        zposition = 5;
    }
    
    void MeteorSpawn()
    {
        if(stop==false)
        {
            float position = Random.Range(-8.0f, 8.0f);

            Instantiate(Meteor, new Vector3(position, 0.66f, 8.5f), Meteor.transform.rotation);
        }
        
    }
}
