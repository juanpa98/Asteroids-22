using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    public int asteroides_min = 2;
    public int asteroides_max = 8;
    public float limitY = 10;
    public float limitX = 6;
    public GameObject asteroide;
    // Start is called before the first frame update
    void Start()
    {
        int asteroides = Random.Range(asteroides_min, asteroides_max);
        for (int i = 0; i < asteroides; i++)
        {
            Debug.Log("instancion del asteroides:" + i);
            Vector3 posicion = new Vector3(Random.Range(-limitX, limitX), Random.Range(-limitY, limitY));
            Vector3 rotation = new Vector3(0, 0, Random.Range(0f, 360f));
            Instantiate(asteroide, posicion, Quaternion.Euler(rotation));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
