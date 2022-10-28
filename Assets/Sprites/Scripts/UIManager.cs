using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
   
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI vidas;
    public GameObject gameOver;
    public TextMeshProUGUI puntaje;
   


    // Start is called before the first frame update
    void Start()
    {
        
      
    }



    void Update()
    {
        tiempo.text = Time.time.ToString("00.00");
        puntaje.text = GameManager.instance.puntuacion.ToString("000");
        vidas.text = GameManager.instance.vidas.ToString();


        if (GameManager.instance.vidas <= 0)
        {

            gameOver.SetActive(true);
            Time.timeScale = 0; 
        }



    }
   

}
