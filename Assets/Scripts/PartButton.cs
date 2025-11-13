             using UnityEngine;
using UnityEngine.UI;

public class PartButton : MonoBehaviour
{
    [HideInInspector] public string categoryName;
    [HideInInspector] public PartChanger partChanger;
    public Sprite partSprite;

    public void OnClick()
    {
        if (partChanger == null || partSprite == null) return;

        switch (categoryName)
        {
            case "Hair":
                partChanger.ChangeHair(partSprite);
                break;
            case "Eyes":
                partChanger.ChangeEyes(partSprite);
                break;
            case "Brows":
                partChanger.ChangeBrows(partSprite);
                break;
            case "Mouth":
                partChanger.ChangeMouth(partSprite);
                break;
            case "Blush":
                partChanger.ChangeBlush(partSprite);
                break;
            case "Tops":
                partChanger.ChangeTops(partSprite);
                break;
            case "Bottoms":
                partChanger.ChangeBottoms(partSprite);
                break;
            case "Dresses":
                partChanger.ChangeDresses(partSprite);
                break;
            case "Shoes":
                partChanger.ChangeShoes(partSprite);
                break;
            case "Accessories":
                partChanger.ChangeAccessories(partSprite);
                break;
            case "Pets":
                partChanger.ChangePets(partSprite);
                break;
            case "Backgrounds":
                partChanger.ChangeBackground(partSprite);
                break;
            default:
                Debug.LogWarning($"Unknown category: {categoryName}");
                break;
        }
    }
}
