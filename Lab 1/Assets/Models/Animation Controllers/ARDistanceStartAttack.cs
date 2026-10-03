using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class ARDistanceStartAttack : MonoBehaviour
{
    public Animator cactusAnimator;
    public Animator zombieAnimator;
    public Transform cactusTransform;
    public Transform zombieTransform;
    private bool isCactusTracked = false;
    private bool isZombieTracked = false;

    public void OnCactusFound() => isCactusTracked = true;
    public void OnZombieFound() => isZombieTracked = true;

    public void OnCactusLost() => isCactusTracked = false;
    public void OnZombieLost() => isZombieTracked = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cactusAnimator == null || zombieAnimator == null) return;

        float distance = Vector3.Distance(zombieTransform.position, cactusTransform.position);

            if (isCactusTracked && isZombieTracked)
            {

                if (cactusTransform != null && zombieTransform != null && distance <= 0.25f)
                {

                    cactusAnimator.SetTrigger("TrStartAttack");
                    zombieAnimator.SetTrigger("TrStartAttack");

            }
            }
    }
}
