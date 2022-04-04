using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Cover : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("isDisappear", true);
            anim.SetBool("isReappear", false);
        }
        else
        {
            anim.SetBool("isDisappear", false);
            anim.SetBool("isReappear", true);
        }
    }
}