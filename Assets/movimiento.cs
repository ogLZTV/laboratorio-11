using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public int direccionx = 1;
    public int direcciony = 1;
    public float speedx = 5;
    private SpriteRenderer renderizado;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        renderizado = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(direccionx * speedx, direcciony * speedx);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tag 2")
        {
            direcciony = direcciony * -1;
            renderizado.flipY = !renderizado.flipY;
        }
        if (collision.gameObject.tag == "tag 1")
        {

            renderizado.flipX = !renderizado.flipX;
            direccionx = direccionx * -1;
        }
    } 
}
