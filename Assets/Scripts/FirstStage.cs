using UnityEngine;

public class FirstStage : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Transform _transform;
    private Vector3 _position;
    private float _defaultAngle;
    private float _zAngle;

    float _deltaAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        _rigidbody2D.linearVelocity = new Vector2(2, 0);
        _zAngle = 0f;
        _defaultAngle = 0f;
    }

    private void Update()
    {
        _position = _transform.position;
        _defaultAngle = _zAngle;
        _zAngle = Mathf.Asin(Mathf.Clamp(Input.acceleration.z, -1, 1));
        _deltaAngle = _zAngle - _defaultAngle;
        if (_deltaAngle != 0f)
        {
            Vector2 gravityDirection = new Vector2(-Mathf.Sin(_zAngle), -Mathf.Cos(_zAngle));
            // Rigidbody2Dに重力を適用
            _rigidbody2D.gravityScale = 1; // 重力の大きさを設定
            _rigidbody2D.AddForce(Physics2D.gravity.magnitude * _rigidbody2D.mass * gravityDirection -
                                  _rigidbody2D.linearVelocity);
        }
    }

    public void ResetAngle()
    {
        _defaultAngle = _zAngle;
    }
}