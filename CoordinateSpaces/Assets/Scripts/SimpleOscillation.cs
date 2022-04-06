using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleOscillation : MonoBehaviour
{

    [SerializeField] 
    GameObject prefab;

    [SerializeField] 
    [Range(0,5)] 
    float period;

    [SerializeField] 
    [Range(0,5)] 
    float amplitude;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float factor = Time.time;
        float x = amplitude * Mathf.Sin(2 * Mathf.PI * factor);
        transform.position = new Vector3(x, transform.position.x, transform.position.z);
        
    }
}
