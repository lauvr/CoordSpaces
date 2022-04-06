using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinDrawer : MonoBehaviour
{
    [SerializeField]
    GameObject obj;

    [SerializeField]
    int samples = 50;

    [SerializeField]
    [Range(0,1)] float separation;

    [SerializeField]
    [Range(0, 20)] float amplitud;

    [SerializeField]
    [Range(0, 100)] float period;

    List<GameObject> objects = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {   
        for (int i = 0; i < samples; i++)
        {
            GameObject child = Instantiate(obj, transform);
            objects.Add(child);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < samples; i++)
        {
            var obj = objects[i];
            float x = separation * i;
            float y = amplitud * Mathf.Sin(2.0f * Mathf.PI * x / period + Time.time);
            obj.transform.localPosition = new Vector3(x, y);
        }
        
    }
}
