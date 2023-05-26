using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        if (!isPinned)
        {
            // here if we use transform.position it will give Vector3 Object we don't want
            // and if we use rb.position it will give Vector2 Position
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.IncreasePinCount();
            // for rotating fast after each pin attached
            col.GetComponent<Rotator>().speed *= .999f;
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
