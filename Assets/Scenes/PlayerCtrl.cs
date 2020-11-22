using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    private Rigidbody rigid;
    public float moveSpeed = 1000f;
    private bool IsJumping;

    Vector3 moveVec;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        IsJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        moveVec.x = Input.GetAxis("Horizontal");
        moveVec.z = Input.GetAxis("Vertical");
        moveVec.y = 0f;

        rigid.velocity = moveVec * moveSpeed;

    }


    public void Die()
    {
        gameObject.SetActive(false);
    }
    void collisonPrevent()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
