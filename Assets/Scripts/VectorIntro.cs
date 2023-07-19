using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorIntro : MonoBehaviour
{
    public float speed;

    public void MovePos(Vector3 step)
    {
        transform.position += step * speed * Time.deltaTime;
    }
}
