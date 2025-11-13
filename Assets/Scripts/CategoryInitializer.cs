using UnityEngine;
using UnityEngine.UI;

public class CategoryInitializer : MonoBehaviour
{
    public string categoryName; // e.g. "Hair", "Eyes", etc.
    public PartChanger partChanger; // drag your Character/PartChanger here

    void Start()
    {
        // Go through all buttons in this grid
        Button[] buttons = GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            PartButton partButton = button.GetComponent<PartButton>();

            if (partButton != null)
            {
                partButton.categoryName = categoryName;
                partButton.partChanger = partChanger;
            }
            else
            {
                Debug.LogWarning($"No PartButton found on {button.name}");
            }

            // Assign click event automatically
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => partButton.OnClick());
        }
    }
}
