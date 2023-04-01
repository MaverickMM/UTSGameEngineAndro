using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    [SerializeField] float swipeThreshold = 50f;
    [SerializeField] float swipeTimeThreshold = 0.3f;
    [SerializeField] float speed = 5f;
    [SerializeField] float leftLimit = -5f;
    [SerializeField] float rightLimit = 5f;

    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;
    private float swipeStartTime;
    private float swipeEndTime;
    private float swipeTime;
    private bool canMove = false;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fingerDownPosition = touch.position;
                fingerUpPosition = touch.position;
                swipeStartTime = Time.time;

                // Check if touch started on this object
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                if (hit.collider != null && hit.collider.gameObject == gameObject)
                {
                    canMove = true;
                }
            }
            else if (touch.phase == TouchPhase.Moved && canMove)
            {
                fingerUpPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended && canMove)
            {
                canMove = false;
                swipeEndTime = Time.time;
                swipeTime = swipeEndTime - swipeStartTime;
                Vector2 swipeDelta = fingerUpPosition - fingerDownPosition;
                if (Mathf.Abs(swipeDelta.x) > swipeThreshold && swipeTime < swipeTimeThreshold)
                {
                    if (swipeDelta.x < 0 && transform.position.x > leftLimit)
                    {
                        transform.position += Vector3.left * Time.deltaTime * speed;
                        Debug.Log("Swipe left");
                    }
                    else if (swipeDelta.x > 0 && transform.position.x < rightLimit)
                    {
                        transform.position += Vector3.right * Time.deltaTime * speed;
                        Debug.Log("Swipe right");
                    }
                }
            }
        }
    }
}