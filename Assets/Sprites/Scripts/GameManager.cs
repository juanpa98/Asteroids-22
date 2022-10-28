using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    
    public static GameManager instance;
    public int vidas;
    public int puntuacion;
    private void Awake()
    {
        instance = this;
    }
    
}
