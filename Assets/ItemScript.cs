using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    //private void DestroySelf()
    //{
    //    Destroy(gameObject);
    // }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Get");
        audioSource.Play();
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
 

    //private void OnTriggerEnter(Collider other)
    //{
    //    //ê⁄êGÇµÇΩèuä‘Ç…åƒÇŒÇÍÇÈ
    //    //Debug.Log("Enter");
    //    DestroySelf();
    //}
    //
    //private void OnTriggerStay(Collider other)
    //{
    //    //ê⁄êGÇµÇƒÇ¢ÇÈä‘Ç…åƒÇŒÇÍÇÈ
    //    Debug.Log("Stay");
    //}
    //
    //private void OnTriggerExit(Collider other)
    //{
    //    //ó£ÇÍÇΩÇ∆Ç´Ç…åƒÇŒÇÍÇÈ
    //    Debug.Log("Exit");
    //}

    


}
