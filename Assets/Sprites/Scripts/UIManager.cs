using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI Puntuacion;
    public TextMeshProUGUI vidas;
    public GameObject gameOver;
    public int score { get; private set; }
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //score = GameManager.instance.puntuacion;
    }

    private void SetScore(int score)
    {
        this.score = score;
        scoreText.text = score.ToString();
    }

    void Update()
    {
        tiempo.text = Time.time.ToString("00.00");

        // Puntuacion.text = score.ToString("000000");

        if (GameManager.instance.vidas <= 0)
        {
            gameOver.SetActive(true);
        }
        else 
            {
            SetScore(0);
            }

    }
    
}
