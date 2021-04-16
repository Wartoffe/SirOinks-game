
using UnityEngine;

public class MoveOinks : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    public float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        Vector2 moveDirection = new Vector2(xDirection, yDirection).normalized;


        //Move(moveDirection);
        transform.position += (Vector3)moveDirection*speed;
    }

    private void Move(Vector3 direction)
    {
        Vector3 currentPosition = transform.position;
        currentPosition += direction * speed * Time.deltaTime;
        transform.position = currentPosition;
    }
}
