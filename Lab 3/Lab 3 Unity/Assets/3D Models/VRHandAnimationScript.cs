using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class VRHandAnimationScript : MonoBehaviour
{
    [Header("Input Actions")]
    public InputActionReference gripActionReference;
    public InputActionReference pinchActionReference;

    public Animator handAnimator;

    private void Awake()
    {
        handAnimator = GetComponent<Animator>();
        if (handAnimator == null)
        {
            Debug.LogError("Animator component not found on the GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (handAnimator == null) return;

        float gripValue = gripActionReference.action.ReadValue<float>();
        float pinchValue = pinchActionReference.action.ReadValue<float>();

        handAnimator.SetFloat("Grip", gripValue);
        handAnimator.SetFloat("Pinch", pinchValue);
    }
}
