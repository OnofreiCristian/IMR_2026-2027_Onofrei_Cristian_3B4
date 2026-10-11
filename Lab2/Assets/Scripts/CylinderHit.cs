using UnityEngine;

public class CylinderHit : MonoBehaviour
{

    [Header("Point Settings")]
    public int pointValue = 10;

    [Header("Point Settings")]
    public Color hitColor = Color.red;

    private bool isHit = false;
    private Renderer cylinderRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cylinderRenderer = GetComponent<Renderer>();
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (isHit) return;

        if (collision.gameObject.CompareTag("Ball"))
        {
            isHit = true;

            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(pointValue);
            }

            if(cylinderRenderer != null)
            {
                cylinderRenderer.material.color = hitColor;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
