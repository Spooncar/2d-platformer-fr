using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forstatement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        test();
        
    }

    void test()
    {
        for (int i = 1; i < 10; i += 2)
        {
            Debug.Log(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
