using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medallas : MonoBehaviour
{
    public Text puntos;
    public int medallas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = medallas.ToString();
        
    }

    public void agarrar()
    {
        medallas += 1;
    }
}
