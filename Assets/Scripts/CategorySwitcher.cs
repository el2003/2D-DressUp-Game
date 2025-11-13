using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CategorySwitcher : MonoBehaviour
{
    public TextMeshProUGUI categoryLabel;

    [Header("Category Grids")]
    public GameObject hairGrid;
    public GameObject eyesGrid;
    public GameObject browsGrid;
    public GameObject mouthGrid;
    public GameObject blushGrid;
    public GameObject topsGrid;
    public GameObject bottomsGrid;
    public GameObject dressesGrid;
    public GameObject shoesGrid;
    public GameObject accessoriesGrid;
    public GameObject petsGrid;
    public GameObject backgroundsGrid;

    [Header("Category Buttons")]
    public Button HairsButton;
    public Button EyesButton;
    public Button EyebrowsButton;
    public Button MouthButton;
    public Button BlushButton;
    public Button TopsButton;
    public Button BottomsButton;
    public Button DressButton;
    public Button ShoesButton;
    public Button AccessoriesButton;
    public Button PetsButton;
    public Button BackgroundsButton;

    void Start()
    {
        HairsButton.onClick.AddListener(() => ShowGrid("Hair"));
        EyesButton.onClick.AddListener(() => ShowGrid("Eyes"));
        EyebrowsButton.onClick.AddListener(() => ShowGrid("Brows"));
        MouthButton.onClick.AddListener(() => ShowGrid("Mouth"));
        BlushButton.onClick.AddListener(() => ShowGrid("Blush"));
        TopsButton.onClick.AddListener(() => ShowGrid("Tops"));
        BottomsButton.onClick.AddListener(() => ShowGrid("Bottoms"));
        DressButton.onClick.AddListener(() => ShowGrid("Dresses"));
        ShoesButton.onClick.AddListener(() => ShowGrid("Shoes"));
        AccessoriesButton.onClick.AddListener(() => ShowGrid("Accessories"));
        PetsButton.onClick.AddListener(() => ShowGrid("Pets"));
        BackgroundsButton.onClick.AddListener(() => ShowGrid("Backgrounds"));

        ShowGrid("Hair");
    }

    void ShowGrid(string category)
    {
        hairGrid.SetActive(false);
        eyesGrid.SetActive(false);
        browsGrid.SetActive(false);
        mouthGrid.SetActive(false);
        blushGrid.SetActive(false);
        topsGrid.SetActive(false);
        bottomsGrid.SetActive(false);
        dressesGrid.SetActive(false);
        shoesGrid.SetActive(false);
        accessoriesGrid.SetActive(false);
        petsGrid.SetActive(false);
        backgroundsGrid.SetActive(false);

        switch (category)
        {
            case "Hair": hairGrid.SetActive(true); break;
            case "Eyes": eyesGrid.SetActive(true); break;
            case "Brows": browsGrid.SetActive(true); break;
            case "Mouth": mouthGrid.SetActive(true); break;
            case "Blush": blushGrid.SetActive(true); break;
            case "Tops": topsGrid.SetActive(true); break;
            case "Bottoms": bottomsGrid.SetActive(true); break;
            case "Dresses": dressesGrid.SetActive(true); break;
            case "Shoes": shoesGrid.SetActive(true); break;
            case "Accessories": accessoriesGrid.SetActive(true); break;
            case "Pets": petsGrid.SetActive(true); break;
            case "Backgrounds": backgroundsGrid.SetActive(true); break;
        }
        if (categoryLabel != null)
        {
            categoryLabel.text = category;
        }
    }
}
