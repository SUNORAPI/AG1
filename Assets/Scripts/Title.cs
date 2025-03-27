using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] GameObject Circle;
    private Vector3 circlePosition;
    private Vector3 firstPosition;
    private void Start()
    {
        circlePosition = Circle.GetComponent<Transform>().position;
        firstPosition = circlePosition;
    }

    // Update is called once per frame
    void Update()
    {
        circlePosition = Circle.GetComponent<Transform>().position;
        if (circlePosition.y < -10)
        {
            Circle.GetComponent<Transform>().position = firstPosition;
            Circle.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            Circle.GetComponent<Rigidbody2D>().angularVelocity = 0f;
        }
    }
}
