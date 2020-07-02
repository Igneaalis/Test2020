using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Vector3 RotateAmount;
    bool RotateX, RotateY, RotateZ, mouseDragging, touchDragging;
    Rigidbody rb;
    private Touch touch;
    private Vector2 beginTouchPosition, direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody> (); 
    }

    private void OnMouseDrag() {
        mouseDragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Rotate X"))
        {
            RotateX = true;
            
        } else if (Input.GetButtonUp("Rotate X"))
        {
            RotateX = false;
        }
        if (Input.GetButtonDown("Rotate Y"))
        {
            RotateY = true;
        } else if (Input.GetButtonUp("Rotate Y"))
        {
            RotateY = false;
        }
        if (Input.GetButtonDown("Rotate Z"))
        {
            RotateZ = true;
        } else if (Input.GetButtonUp("Rotate Z"))
        {
            RotateZ = false;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseDragging = false;
        }
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    beginTouchPosition = touch.position;
                    break;

                case TouchPhase.Moved:
                    direction = touch.position - beginTouchPosition;
                    touchDragging = true;
                    break;
                case TouchPhase.Stationary: case TouchPhase.Ended:
                    touchDragging = false;
                    break;
            }
        }
    }

    void FixedUpdate() {
        if (RotateX)
        {
            transform.Rotate(RotateAmount.x * Time.fixedDeltaTime, 0, 0);
        }
        if (RotateY)
        {
            transform.Rotate(0, RotateAmount.y * Time.fixedDeltaTime, 0);
        }
        if (RotateZ)
        {
            transform.Rotate(0, 0, RotateAmount.z * Time.fixedDeltaTime);
        }
        if (mouseDragging)
        {
            float x = Input.GetAxis("Mouse X") * RotateAmount.x * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * RotateAmount.y * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down*x);
            rb.AddTorque(Vector3.right*y);
        }
        if (touchDragging)
        {
            float x = direction.x * Time.fixedDeltaTime;
            float y = direction.y * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down*x);
            rb.AddTorque(Vector3.right*y);
        }
    }
}
