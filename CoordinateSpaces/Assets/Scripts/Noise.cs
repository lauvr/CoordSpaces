using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour
{
    [SerializeField]
    float periodX;
    [SerializeField]
    float amplitudeX;

    [SerializeField]
    float periody;
    [SerializeField]
    float amplitudey;

    // Start is called before the first frame update
    void Start()
    {

       periodX = Random.Range(-5, 5);
       amplitudeX = Random.Range(-5, 5);

       periody = Random.Range(-5, 5);
       amplitudey = Random.Range(-5, 5);

    }

    // Update is called once per frame
    void Update()
    {
        float factor = Time.time;
        float x = amplitudeX * Mathf.Sin(2 * Mathf.PI * factor);
        float y = amplitudey * Mathf.Sin(2 * Mathf.PI * factor);
        transform.position = new Vector3(x, y, transform.position.z);
        
    }
}
