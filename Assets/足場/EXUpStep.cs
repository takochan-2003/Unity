using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXUpStep : MonoBehaviour
{
    // Start is called before the first frame update

    float top;

    float bottom;

    float exchange = 0.01f;
    void Start()
    {
        top = gameObject.transform.position.y + 8f;
        bottom = gameObject.transform.position.y - 8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > top)
        {
            exchange = -0.60f;
        }
        if (gameObject.transform.position.y < bottom)
        {
            exchange = 0.60f;
        }
        gameObject.transform.Translate(0, exchange, 0);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // �G�ꂽobj�̐e���ړ����ɂ���
            other.transform.SetParent(transform);
        }
    }

    /// <summary>
    /// �ړ����̃R���C�_�[��obj���痣�ꂽ���̏���
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // �G�ꂽobj�̐e���Ȃ���
            other.transform.SetParent(null);
        }
    }

}
