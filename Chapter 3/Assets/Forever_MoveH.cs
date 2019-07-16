using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveH : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float speed = 5;

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        this.transform.Translate(speed / 50, 0, 0);
    }
}
