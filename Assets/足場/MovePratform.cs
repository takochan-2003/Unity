using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePratform : MonoBehaviour
{

    int flag = 0;

    float exchange = 0.01f;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            flag = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1)
        {
            exchange = 0.06f;
            gameObject.transform.Translate(exchange, 0, 0);
        }
    }
}
