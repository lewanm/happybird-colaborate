using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDelTubo : MonoBehaviour
{
    Transform tubeTransform;
    public float velocity = 0.05f;

    void Start()
    {
        tubeTransform = gameObject.GetComponent<Transform>();
    }    

    void Update()
    {
        tubeTransform.position -= new Vector3 (1,0,0) * velocity * Time.deltaTime;
    }
}
