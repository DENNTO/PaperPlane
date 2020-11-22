using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    Rigidbody rigid;
    public float moveSpeed = 8f;

    public bool isFirstClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * moveSpeed;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            // 스페이스가 눌리면
            if (!isFirstClicked)
            {

                isFirstClicked = true;
            }
            

        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerCtrl player = other.GetComponent<PlayerCtrl>();

            if (player != null)
                player.Die();
        }
        else if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }


}
