using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    private Keyboard keyboard;

    void Start()
    {
        anim = GetComponent<Animator>();
        keyboard = Keyboard.current; // Yeni sistemde klavye referansý
    }

    void Update()
    {
        if (keyboard == null) return;

        bool wPressed = keyboard.wKey.isPressed;
        bool shiftPressed = keyboard.leftShiftKey.isPressed || keyboard.rightShiftKey.isPressed;

        bool isWalking = wPressed && !shiftPressed;
        bool isRunning = wPressed && shiftPressed;

        anim.SetBool("IsWalking", isWalking);
        anim.SetBool("IsRunning", isRunning);
    }
}
