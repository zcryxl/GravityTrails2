using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{ 
    public float yForce;
    private Rigidbody2D enemyRigidbody;
    public int maximumXPosition;
    public int minimumXPosition;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(0, yForce);
            enemyRigidbody.AddForce(jumpForce);
        }

        if (collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(collision.gameObject);
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
