﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    #region Fields & Props

    private static int _ID;
    public static int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }

    private static string _Name;
    public static string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    private int _Amount;
    public int Amount
    {
        get { return _Amount; }
        set { _Amount = value; }
    }

    #endregion // Fields & Props

    #region Methods

    void Start()
    {

    }

    void Update()
    {

    }

    #endregion // Methods

    #region Events

    #endregion // Events
}
