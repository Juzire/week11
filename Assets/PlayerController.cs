using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftControl)) 
        {
            playerAnim.SetBool("run", true);
        }

        
    }
}
