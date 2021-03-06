using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 10f;
   // public string velocity;
    //public Text VelocityText;
  //  private static float velociti; // Not a spelling error, its a play on words (if you know you know).
   // public Text velocityText;



    // Start is called before the first frame update
    private void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            Debug.Log(direction); //output direction to console.
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;
            Debug.Log(direction.x);
            Debug.Log(direction.y);

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
              // velocity = GetComponent<Rigidbody>().velocity.magnitude.ToString();
               //VelocityText.text = velocity.ToString();
               //Debug.Log(velocity);
        }
    }
}
