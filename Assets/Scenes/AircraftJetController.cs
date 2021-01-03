using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftJetController : MonoBehaviour
{
    public int moveSpeed;
    public static bool isGameovered = false;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            //GameObject go = GameObject.FindGameObjectsWithTag("Bullet");
            //Destroy(go);
            //Destroy(BulletSpawnerCtrl.bulletPrefab);

            gameOverPanel.SetActive(true);
            isGameovered = true;
        }
    }
}
