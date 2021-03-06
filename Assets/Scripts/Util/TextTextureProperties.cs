﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cyber.Util {

    /// <summary>
    /// Text texture properties. See <see cref="TextTextureRenderer"/>.
    /// </summary>
    [System.Serializable]
    public struct TextTextureProperties {

        /// <summary>
        /// The text.
        /// </summary>
        public string Text;

        /// <summary>
        /// The offset on the x-axis in pixels.
        /// </summary>
        public int OffsetX;

        /// <summary>
        /// The offset on the y-axis in pixels.
        /// </summary>
        public int OffsetY;

        /// <summary>
        /// Whether the text is centered or not.
        /// </summary>
        public bool Centered;

        /// <summary>
        /// The offset on the y-axis in pixels.
        /// </summary>
        public Color Background;

        /// <summary>
        /// The size of the font.
        /// </summary>
        public int FontSize;

        /// <summary>
        /// The width of the texture.
        /// </summary>
        public int Width;

        /// <summary>
        /// The height of the texture.
        /// </summary>
        public int Height;

        /// <summary>
        /// Creates new properties for a specified kind of text. See 
        /// <see cref="TextTextureRenderer"/> for usage.
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="offsetX">Offset x.</param>
        /// <param name="offsetY">Offset y.</param>
        /// <param name="centered">If set to <c>true</c> centered.</param>
        /// <param name="background">Background.</param>
        /// <param name="fontSize">Font size.</param>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public TextTextureProperties(string text, int offsetX = 0, 
                int offsetY = 0, bool centered = false, 
                Color background = new Color(), int fontSize = 32, 
                int width = 256, int height = 256) {
            Text = text;
            OffsetX = offsetX;
            OffsetY = offsetY;
            Centered = centered;
            Background = background;
            FontSize = fontSize;
            Width = width;
            Height = height;
        }
    }
}