using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Player : MonoBehaviour
{
    PhotonView view;
    public bool canmove = false;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                canmove = !canmove;
            }
            Movement();
        }

    }


    public void Movement()
    {
        if (canmove)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
