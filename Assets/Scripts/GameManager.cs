using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text Waves;
    public Text Timee;
    public Text Life;
    public Text Score;
    public Text TotalScore;
    public Text TotalTime;
    public Text WinScore;
    public Text WinTime;
    public Text Lifeleft;
    public Text WaveON;

    public Image image;
    public Image win;
    public Image Pause;
    private float time = 0;
    public bool gameover=false;


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
        Waves.text ="Wave :" + wave.wavenum;
        Timee.text = "Time :" + time;
        Life.text = "Lifes :" + player.playerlife;
        Score.text = "Score :" + wave.score;

        TotalScore.text = "Total Score :" + wave.score;
        TotalTime.text= "Total Time :" + time;

        WinScore.text = "Total Score :" + wave.score;
        WinTime.text = "Total Time :" + time;

        Lifeleft.text = "Lifes :" + player.playerlife;
        WaveON.text = "Wave :" + wave.wavenum;

        if (gameover == false)
        {
            time += Time.deltaTime;

        }

        if(player.playerlife<1)
        {
            gameover = true;
            wave.stop = true;
            image.gameObject.SetActive(true);
        }

        if(wave.wavenum>5)
        {
            gameover = true;
            wave.stop = true;
            win.gameObject.SetActive(true);
        }
    }
    public void OnPausee()
    {
        gameover = true;
        wave.stop = true;
        Pause.gameObject.SetActive(true);
    }
}
