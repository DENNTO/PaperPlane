using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public float offsetX = 0f;
    public float offsetY = 1f;
    public float offsetZ = -30f;
    Vector3 CameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        //CameraPosition.x = Player.transform.position.x + offsetX;
        //CameraPosition.y = Player.transform.position.y + offsetY;
        //CameraPosition.z = Player.transform.position.z + offsetZ;

        //transform.position = CameraPosition;
    }
}
