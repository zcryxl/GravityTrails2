using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public Text collectableCounter;
    public Vector3 offset;
    public GameObject objectThrown;
    public int throwableCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {
            Instantiate(objectThrown, transform.position, transform.rotation);
            offset = new Vector3 (1, 0, 0);
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            throwableCounter -= 1;
        }
         collectableCounter.text = ("" + throwableCounter + "");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;
            Destroy(collision.gameObject);
            
        }
    }
}
