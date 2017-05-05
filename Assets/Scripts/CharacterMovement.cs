using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public WheelJoint2D left;
    public Rigidbody2D rb_left;
    public SpriteRenderer dogSprite;
    public WheelJoint2D right;
    public Rigidbody2D rb_right;
    private void Start()
    {
        rb_left = left.GetComponent<Rigidbody2D>();
        rb_right = right.GetComponent<Rigidbody2D>();    
    }
    public float torqueFactor;
    private void FixedUpdate()
    {
        var h = Input.GetAxis("Horizontal");
        
        rb_left.AddTorque(torqueFactor * -h);
        rb_right.AddTorque(torqueFactor * -h);


        if(h > 0)
            dogSprite.flipX = false;
        else if(h < 0)
            dogSprite.flipX = true;
    }

    
}
