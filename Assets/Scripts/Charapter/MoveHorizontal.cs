using UnityEngine;

namespace CrazyEight
{
	public class MoveHorizontal : MonoBehaviour
	{
		private InputControll _input;

        private float _directionVector;
        private float _speed =6.0f;

        private void Start()
        {
            _input = transform.GetComponent<InputControll>();
        }

        private void Update()
        {
            _directionVector = _input.InputHorizontal;
            transform.Translate(Vector3.right * (_directionVector * _speed) * Time.deltaTime);
        }
    }
}
