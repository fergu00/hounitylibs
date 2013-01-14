﻿// Author: Daniele Giardini
// Copyright (c) 2012 Daniele Giardini - Holoville - http://www.holoville.com
// Created: 2012/11/22 13:59

using UnityEngine;

namespace Holoville.HO2DToolkit
{
    /// <summary>
    /// Interface to add to the tk2dBaseSprite class in order to use the HO2DToolkit library.
    /// </summary>
    public interface IHOtk2dSprite : IHOtk2dBase
    {
        /// <summary>
        /// Sprite id
        /// </summary>
        int spriteId { get; set; }
        /// <summary>
        /// Color
        /// </summary>
        Color color { get; set; }
        /// <summary>
        /// Scale
        /// </summary>
        Vector3 scale { get; set; }
        /// <summary>
        /// GameObject
        /// </summary>
        GameObject gameObject { get; }
        /// <summary>
        /// Transform
        /// </summary>
        Transform transform { get; }
    }
}