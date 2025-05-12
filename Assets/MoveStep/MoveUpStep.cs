using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpStep : MonoBehaviour
{
    // Start is called before the first frame update

    float top;

    float bottom;

    float exchange = 0.01f;
    void Start()
    {
        top = gameObject.transform.position.y + 3f;
        bottom = gameObject.transform.position.y - 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > top)
        {
            exchange = -0.08f;
        }
        if (gameObject.transform.position.y < bottom)
        {
            exchange = 0.08f;
        }
        gameObject.transform.Translate(0, exchange, 0);

    }



}
