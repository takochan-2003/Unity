using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{

    private Rigidbody rb;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private float jumpPower;
    private Vector3 clickPosition;
    private bool isCanJump;
    void Update()
    {
        

       



        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if(isCanJump && Input.GetMouseButtonUp(0))
        {
            //�N���b�N�������W�Ɨ��������W�̍������擾
            Vector3 dist = clickPosition - Input.mousePosition;
            jumpPower=(
            (clickPosition.x/10 - Input.mousePosition.x / 10) * (clickPosition.x / 10 - Input.mousePosition.x / 10) +
            (clickPosition.y/10 - Input.mousePosition.y / 10) * (clickPosition.y / 10 - Input.mousePosition.y / 10) +
            (clickPosition.z/10 - Input.mousePosition.z / 10) * (clickPosition.z / 10 - Input.mousePosition.z / 10))/10;

            if(jumpPower<=5.0f)
            {
                jumpPower = 5.0f;
            }
            if (jumpPower >= 20.0f)
            {
                jumpPower = 20.0f;
            }

            //�N���b�N�ƃ����[�X���������W�Ȃ�Ζ���
            if (dist.sqrMagnitude == 0) { return; }
            //������W�������AJumpPower���������킹���l���ړ��ʂƂ���B
            rb.velocity = dist.normalized * jumpPower;
            //rb.velocity += Z;
            audioSource.Play();
        }
        if (isCanJump==false&&Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, -20, 0);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //�Փ˂����u�ԂɌĂ΂��
       // Debug.Log("�Փ˂���");

    }

    private void OnCollisionStay(Collision collision)
    {
        //�Փ˂��Ă���ԂɌĂ΂��
       // Debug.Log("�ڐG��");
        //isCanJump = true;
        ContactPoint[] contacts = collision.contacts;
        Vector3 otherNormal = contacts[0].normal;
     
        Vector3 upVector = new Vector3(0, 1, 0);

        float dotUN = Vector3.Dot(upVector, otherNormal);
        float dotDeg = Mathf.Acos(dotUN) * Mathf.Rad2Deg;

        if (dotDeg <= 45)
        {
            isCanJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //���ꂽ�Ƃ��ɌĂ΂��
       // Debug.Log("���E����");
        isCanJump = false;
       
    }
}
