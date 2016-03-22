﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessorTestBase.cs" company="James Jackson-South">
//   Copyright © James Jackson-South and contributors.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessorCore.Tests
{
    using System.Collections.Generic;

    using Xunit;

    /// <summary>
    /// The processor test base.
    /// </summary>
    public abstract class ProcessorTestBase
    {
        /// <summary>
        /// The collection of image files to test against.
        /// </summary>
        public static readonly List<string> Files = new List<string>
        {
            //"TestImages/Formats/Jpg/Floorplan.jpeg", // Perf: Enable for local testing only
            "TestImages/Formats/Jpg/Calliphora.jpg",
            //"TestImages/Formats/Jpg/fb.jpg", // Perf: Enable for local testing only
            //"TestImages/Formats/Jpg/progress.jpg", // Perf: Enable for local testing only
            //"TestImages/Formats/Jpg/gamma_dalai_lama_gray.jpg", // Perf: Enable for local testing only
            "TestImages/Formats/Bmp/Car.bmp",
            //"TestImages/Formats/Png/blur.png", // Perf: Enable for local testing only
            //"TestImages/Formats/Png/indexed.png", // Perf: Enable for local testing only
            "TestImages/Formats/Png/splash.png",
            "TestImages/Formats/Gif/rings.gif",
            //"TestImages/Formats/Gif/giphy.gif" // Perf: Enable for local testing only
        };
        
        protected void ProgressUpdate(object sender, ProgressEventArgs e)
        {
            Assert.InRange(e.RowsProcessed, 1, e.TotalRows);
        }
    }
}
