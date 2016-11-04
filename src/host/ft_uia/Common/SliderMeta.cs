//----------------------------------------------------------------------------------------------------------------------
// <copyright file="SliderMeta.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>Range Value Slider metadata information helper class.</summary>
//----------------------------------------------------------------------------------------------------------------------
namespace Conhost.UIA.Tests.Common
{
    using System;
    using System.Globalization;
    
    using WEX.Logging.Interop;
    using OpenQA.Selenium.Appium;

    public struct SliderMeta
    {
        /// <summary>
        /// When testing a slider, this is the position we expect to set it to.
        /// </summary>
        public enum ExpectedPosition
        {
            Maximum,
            Minimum
        }

        public AppiumWebElement Slider { get; private set; }
        public string ValueName { get; private set; }
        public bool IsV2Property { get; private set; }
        public NativeMethods.Wtypes.PROPERTYKEY? PropKey { get; private set; }


        public SliderMeta(AppiumWebElement slider, string valueName, bool isV2Property, NativeMethods.Wtypes.PROPERTYKEY? propKey)
            : this()
        {
            this.Slider = slider;
            this.ValueName = valueName;
            this.IsV2Property = isV2Property;
            this.PropKey = propKey;
        }

        public void SetToMaximum()
        {
            return;
        }

        public void SetToMinimum()
        {
            return;
        }

        public int GetMaximum()
        {
            return 100;
        }

        public int GetMinimum()
        {
            return 30;
        }
    }
}