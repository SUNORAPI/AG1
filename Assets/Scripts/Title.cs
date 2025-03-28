using UnityEngine;
public class Title : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    private Vector3 _circlePosition;
    private Vector3 _firstPosition;
    private Transform _circleTransform;
    private Rigidbody2D _circleRigidbody2D;
    private void Start()
    {
        _circleTransform = circle.GetComponent<Transform>();
        _circleRigidbody2D = _circleTransform.GetComponent<Rigidbody2D>();
        _circlePosition = _circleTransform.position;
        _firstPosition = _circlePosition;
    }

    // Update is called once per frame
    void Update()
    {
        _circlePosition = _circleTransform.position;
        if (_circlePosition.y < -10)
        {
            _circleTransform.position = _firstPosition;
            _circleRigidbody2D.linearVelocity = Vector2.zero;
            _circleRigidbody2D.angularVelocity = 0f;
        }
    }
}
