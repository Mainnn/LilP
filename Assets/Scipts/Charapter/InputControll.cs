using System;
using UnityEngine;

namespace CrazyEight
{
	public class InputControll : MonoBehaviour
	{
		[SerializeField] private Joystick _jotstik;
        private float _inputHorizontal;

        private Vector2 _startPosition;
        private float _direction;
        private float _inputJumpPC;

        public float InputHorizontal { get; private set; }
        public float InputJump { get; private set; }

        private void Update()
        {
#if UNITY_EDITOR
            _inputHorizontal = Input.GetAxis("Vertical");
            _inputHorizontal = Input.GetAxis("Horizontal");
            InputJump = _inputJumpPC > 0 ? 1f : 0;

#elif UNITY_ANDROID
            _inputHorizontal = _jotstik.Horizontal;
            GetTouchInput();
#endif
            InputHorizontal = _inputHorizontal > 0.01f || _inputHorizontal < -0.01f ? _inputHorizontal : 0;

        }

        private void  GetTouchInput()
        {
            Touch touch = Input.GetTouch(0);
            if (Input.touchCount >0 )
            {
                    switch (touch.phase)
                    {
                        case TouchPhase.Moved:
                        Debug.Log(touch.position.y +" :::::<Lol >::::" + touch.position.x);
                        Debug.Log(Camera.main.pixelWidth);
                            _direction = touch.position.y > _startPosition.y ? 1f : 0;
                            InputJump = _direction;
                            break;
                        default:
                            _startPosition = touch.position;
                            _direction = 0f;
                            InputJump = _direction;
                            break;
                    }
            }

        }
    }
}