using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactoranim : MonoBehaviour
{
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("Dance_01");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Dance_02");
        }

        
    }
}
