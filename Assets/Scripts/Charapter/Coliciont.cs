using UnityEngine;

namespace CrazyEight
{
	[RequireComponent(typeof(Collider2D))]
	public class Coliciont : MonoBehaviour
	{
        private bool _isGround;

        public  bool IsGround => _isGround;

        private void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<Ground>(out Ground ground))
            {
                _isGround = true;
                Debug.Log("true");
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<Ground>(out Ground ground))
            {
                _isGround = false;
                Debug.Log("false");
            }
        }

    }
}
