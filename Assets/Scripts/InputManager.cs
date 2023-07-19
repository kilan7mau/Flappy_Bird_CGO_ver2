using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public VectorIntro vector;

    private void Update()
    {
        InputAxis();
    }
    public void InputAxis()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");

        vector.MovePos(new Vector3(horiz, vert, 0));
    }
}
