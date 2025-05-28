using UnityEngine;
using UnityEngine.UI;

public class GradiantFromFill : MonoBehaviour
{
    [SerializeField] private Gradient gradient;

    private Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Apply();
    }

    //ContextMenu adds an item to the right-clcik menu of the component
    [ContextMenu("Apply")]
    public void Apply()
    {
        if (image == null)
        {
            image = GetComponent<Image>();
        }

        image.color = gradient.Evaluate(image.fillAmount);
    }

    // OnValidate runs whenether this component is updated/changed in the inspector
    private void OnValidate()
    {
        Apply();
    }
}
