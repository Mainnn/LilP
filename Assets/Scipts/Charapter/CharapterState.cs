using UnityEngine;

namespace CrazyEight
{
	public class CharapterState : MonoBehaviour
	{
        private bool _isidle = true;
        private bool _isrun = false;
        private bool _isjump = false;
        private bool _isground = true;

        public bool isIdle => _isidle;
        public bool isRun => _isrun;
        public bool isJump => _isjump;
        public bool isGround => _isground;

        public void SetStayts(Stayt stayt)
        {
            switch (stayt)
            {
                case Stayt.Jump:
                    _isground = false;
                    _isjump = true;
                    _isidle = false;
                    _isrun = false;
                    break;
                case Stayt.Idle:
                    _isground = true;
                    _isjump = false;
                    _isidle = true;
                    _isrun = false;
                    break;

                case Stayt.Run:
                    _isground = true;
                    _isjump = false;
                    _isidle = false;
                    _isrun = true;
                    break;

                case Stayt.Ground:
                    _isground = true;
                    break;
            }
        }

    }
public  enum Stayt
    {
        Jump,
        Idle,
        Run,
        Ground
    }
}