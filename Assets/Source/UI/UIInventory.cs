using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private UIInventoryItem item;

    [SerializeField]
    private RectTransform contentPanel;

    List<UIInventoryItem> inventoryItems = new List<UIInventoryItem>();

    public void InitializeInventoryUI(int inventorySize)
    {
        for (int i = 0; i < inventorySize; i++)
        {
            UIInventoryItem uiItem = Instantiate(item, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            inventoryItems.Add(uiItem);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    { 
        gameObject.SetActive(false); 
    }
}
