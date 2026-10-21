using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        Keyboard kb = Keyboard.current;
        if (kb == null) return;

        Vector3 direction = Vector3.zero;

        if (kb.upArrowKey.isPressed) direction += Vector3.forward;
        if (kb.downArrowKey.isPressed) direction += Vector3.back;
        if (kb.leftArrowKey.isPressed) direction += Vector3.left;
        if (kb.rightArrowKey.isPressed) direction += Vector3.right;

        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}