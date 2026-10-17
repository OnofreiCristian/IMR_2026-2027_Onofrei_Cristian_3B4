using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimations : MonoBehaviour
{
    [SerializeField] private InputActionReference gripActionReference;

    [SerializeField] private InputActionReference triggerActionReference;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            Debug.LogError("Animator component not found on the GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
            return;

        float gripValue = gripActionReference.action.ReadValue<float>();
        float triggerValue = triggerActionReference.action.ReadValue<float>();

        animator.SetFloat("Grip", gripValue);
        animator.SetFloat("Trigger", triggerValue);
    }
}
