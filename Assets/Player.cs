using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;


    // Update is called once per frame
    void Update()
    {
        // this is for PC
        //movement = Input.GetAxisRaw("Horizontal");

        // this is for android
        Touch touch = Input.GetTouch(0);
        Vector3 touchpos = Camera.main.ScreenToWorldPoint(touch.position);
        movement = touchpos.x + touchpos.y;
    }
    void FixedUpdate()
    {
        // this is for PC
        //transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.deltaTime * moveSpeed);

        // this is for android
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Game");
    }
}
