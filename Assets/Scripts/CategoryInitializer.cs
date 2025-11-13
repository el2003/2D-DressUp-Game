using UnityEngine;
using UnityEngine.UI;

public class CategoryInitializer : MonoBehaviour
{
    public string categoryName;
    public PartChanger partChanger;

    void Start()
    {
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
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => partButton.OnClick());
        }
    }
}
