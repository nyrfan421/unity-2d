using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Turn : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public float angle = 90; // 角度：Inspector で指定
    public int maxCount = 100; // 頻度：Inspector で指定

    int count = 0; // カウンター用

    // Start is called before the first frame update
    void Start()
    {
        count = 0; // カウンターのリセット
    }

    void FixedUpdate()
    {
        count = count + 1;
        if (count == maxCount) {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}
