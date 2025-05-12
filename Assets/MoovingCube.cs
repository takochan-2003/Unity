using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [Header("�K�v�ȃR���|�[�l���g��o�^")]
    [SerializeField]
    Rigidbody rigidBody = null;

    [Header("��{�ݒ�")]
    [SerializeField]
    Vector3 speed = new Vector3 (1,0,0);

    List<Rigidbody> rigidBodies = new();

    void FixedUpdate()
    {
        MovePlatform();
        AddVelocity();
    }

    void OnTriggerEnter(Collider other)
    {
        rigidBodies.Add(other.gameObject.GetComponent<Rigidbody>());
    }

    void OnTriggerExit(Collider other)
    {
        rigidBodies.Remove(other.gameObject.GetComponent<Rigidbody>());
    }

    void MovePlatform()
    {
        rigidBody.MovePosition(transform.position + Time.fixedDeltaTime * speed);
    }

    void AddVelocity()
    {
        if (rigidBody.velocity.sqrMagnitude <= 0.01f)
        {
            return;
        }

        for (int i = 0; i < rigidBodies.Count; i++)
        {
            rigidBodies[i].AddForce(rigidBody.velocity, ForceMode.VelocityChange);
        }
    }

    

}