using UnityEngine;

public class rotate_x: MonoBehaviour
{
    //Rotation Variables
    public Touch current_position_touch;
    private float rotation_modify = 0.1f; //control speed of rotation

    //Method to update the timer and user information every frame
    void Update()
    {
        if (Input.touchCount > 0)

            current_position_touch = Input.GetTouch(0);

             if (current_position_touch.phase == TouchPhase.Moved)
             {

            Quaternion rotationY = Quaternion.Euler(0f, -current_position_touch.deltaPosition.x * rotation_modify, 0f);

            transform.rotation = rotationY * transform.rotation;
             } 
    }
}
