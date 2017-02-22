﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Item
{
    #region Fields & Props

    public override string _SpritePath { get; protected set; }

    #endregion // Fields & Props

    #region Methods

    public override void Start()
    {
        this._SpritePath = @"";
        base.Start();
    }

    #endregion // Methods
}
