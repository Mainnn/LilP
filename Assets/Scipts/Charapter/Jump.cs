using UnityEngine;

namespace CrazyEight
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jump : MonoBehaviour
    {
        private Coliciont _coliciont;
        private InputControll _input;
        private Rigidbody2D _rigidbody;

        private float _forceJump = 150;

        private void Start()
        {
            _coliciont = transform.GetComponent<Coliciont>();
            _input = transform.GetComponent<InputControll>();
            _rigidbody = transform.GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if ((_input.InputJump > 0) && (_coliciont.IsGround == true))
            {
                JumpCharapter(_forceJump);
            }
        }

        private void JumpCharapter(float force)
        {
            _rigidbody.AddForce(Vector2.up * force);
        }
    }
}
