﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Slot : MonoBehaviour//, IPointerEnterHandler, IDragHandler
{
    #region Fields & Props

    private Item _MyItem;
    public Item MyItem
    {
        get { return _MyItem; }
        set { this._MyItem = value; }
    }

    public Sprite MySprite { get; set; }

    #endregion // Fields & Props

    #region Methods

    public void Start()
    {
        ((Inventory)GameObject.Find("PlayerWithCam(Clone)").GetComponent(typeof(Inventory))).GotItem += AddItem;
    }

    private void AddItem(Item p_Item)
    {
        if (this._MyItem != null && this._MyItem.GetType() == p_Item.GetType())
        {
            this.transform.GetChild(0).GetComponent<Text>().text = p_Item.Amount.ToString();

            if (this.transform.GetChild(1).GetComponent<Image>().sprite == null)
            {
                this.transform.GetChild(1).GetComponent<Image>().sprite = (Sprite)Resources.Load<Sprite>(p_Item._SpritePath);
                this.transform.GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 255);
            }
        }
    }

    //#region Drag & Drop
    //
    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    this.transform.parent.parent.parent.GetComponent<InventoryUI>().selectedSlot = this.transform;
    //}
    //
    //public void OnDrag(PointerEventData eventData)
    //{
    //    if (eventData.button == PointerEventData.InputButton.Left)
    //    {
    //        this.transform.GetChild(0).position = Input.mousePosition;
    //    }
    //}
    //
    //#endregion // Drag & Drop

    #endregion // Methods
}
