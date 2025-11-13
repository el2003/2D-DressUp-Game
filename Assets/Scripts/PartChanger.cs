using UnityEngine;
using UnityEngine.UI;

public class PartChanger : MonoBehaviour
{
    [Header("Character Layers")]
    public Image backgroundsImage;
    public Image petsImage;
    public Image accessoriesImage;
    public Image shoesImage;
    public Image dressesImage;
    public Image bottomsImage;
    public Image topsImage;
    public Image bodyImage;       // neck-down body
    public Image faceImage;       // head/face base
    public Image blushImage;
    public Image mouthImage;
    public Image browsImage;
    public Image eyesImage;
    public Image hairImage;

    // 🧍 Base Layers
    public void ChangeBody(Sprite newBody)
    {
        if (bodyImage != null)
            bodyImage.sprite = newBody;
    }

    public void ChangeFace(Sprite newFace)
    {
        if (faceImage != null)
            faceImage.sprite = newFace;
    }

    // 👀 Facial Features
    public void ChangeEyes(Sprite newEyes)
    {
        if (eyesImage != null)
            eyesImage.sprite = newEyes;
    }

    public void ChangeBrows(Sprite newBrows)
    {
        if (browsImage != null)
            browsImage.sprite = newBrows;
    }

    public void ChangeMouth(Sprite newMouth)
    {
        if (mouthImage != null)
            mouthImage.sprite = newMouth;
    }

    public void ChangeBlush(Sprite newBlush)
    {
        if (blushImage != null)
            blushImage.sprite = newBlush;
    }

    // 💇 Hair
    public void ChangeHair(Sprite newHair)
    {
        if (hairImage != null)
            hairImage.sprite = newHair;
    }

    // 👕 Clothing
    public void ChangeTops(Sprite newTop)
    {
        if (topsImage != null)
            topsImage.sprite = newTop;
    }

    public void ChangeBottoms(Sprite newBottom)
    {
        if (bottomsImage != null)
            bottomsImage.sprite = newBottom;
    }

    public void ChangeDresses(Sprite newDress)
    {
        if (dressesImage != null)
            dressesImage.sprite = newDress;
    }

    public void ChangeShoes(Sprite newShoes)
    {
        if (shoesImage != null)
            shoesImage.sprite = newShoes;
    }

    // 🎀 Extras
    public void ChangeAccessories(Sprite newAccessory)
    {
        if (accessoriesImage != null)
            accessoriesImage.sprite = newAccessory;
    }

    public void ChangePets(Sprite newPet)
    {
        if (petsImage != null)
            petsImage.sprite = newPet;
    }

    public void ChangeBackground(Sprite newBackground)
    {
        if (backgroundsImage != null)
            backgroundsImage.sprite = newBackground;
    }
}
