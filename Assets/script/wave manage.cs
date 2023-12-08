using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavemanage : MonoBehaviour
{
    public static wavemanage instance;
    public float amplitude = 1f;
    public float length = 2f;
    public float speed = 1f;
    public float offset = 0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }
        else if (instance != this)
        {
            Debug.LogWarning("More than one instance of wave manager found!");
            Destroy(this);
        }
        
    }

    private void Update()
    {
        offset += Time.deltaTime * speed;
        
    }
    public float GetWaveHeight(float _x)
    {
        return amplitude * Mathf.Sin(_x / length + offset);
    }
}
