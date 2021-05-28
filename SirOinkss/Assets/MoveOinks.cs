using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOinks : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private PolygonCollider2D playercollider;
    private void Start()
    {
        //[SerializeField] private LayerMask platformsLayerMask;
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        playercollider = transform.GetComponent<PolygonCollider2D>();
    }

    
    
    void Update()
    {

        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 50f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }

        /*float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
        Vector2 moveDirection = new Vector2(xDirection, yDirection).normalized;
        transform.position += (Vector3)moveDirection*speed;*/

    }

    private void FixedUpdate()
    {
        float moveSpeed = 20f;
        rigidbody2d.constraints = RigidbodyConstraints2D.FreezeRotation;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
           
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            rigidbody2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(playercollider.bounds.center, playercollider.bounds.size, 0f, Vector2.down * .1f);
        //RaycastHit2D raycastHit2d = Physics2D.BoxCast(playercollider.bounds.center, playercollider.bounds.size, 0f, Vector2.down , .1f, platformsLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }


}
