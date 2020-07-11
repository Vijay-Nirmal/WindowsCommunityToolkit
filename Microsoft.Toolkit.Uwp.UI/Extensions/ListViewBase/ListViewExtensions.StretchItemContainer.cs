// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Microsoft.Toolkit.Uwp.UI.Extensions
{
    /// <summary>
    /// Provides attached dependency properties for the <see cref="Windows.UI.Xaml.Controls.ListViewBase"/>
    /// </summary>
    public static partial class ListViewExtensions
    {
        /// <summary>
        /// Attached <see cref="DependencyProperty"/> for setting the container content stretch direction on the <see cref="Windows.UI.Xaml.Controls.ListViewBase"/>
        /// </summary>
        public static readonly DependencyProperty StretchItemContainerDirectionProperty = DependencyProperty.RegisterAttached("StretchItemContainerDirection", typeof(StretchDirection), typeof(ListViewExtensions), new PropertyMetadata(null, OnStretchItemContainerDirectionPropertyChanged));

        /// <summary>
        /// Gets the stretch <see cref="StretchDirection"/> associated with the specified <see cref="Windows.UI.Xaml.Controls.ListViewBase"/>
        /// </summary>
        /// <param name="obj">The <see cref="Windows.UI.Xaml.Controls.ListViewBase"/> to get the associated <see cref="StretchDirection"/> from</param>
        /// <returns>The <see cref="StretchDirection"/> associated with the <see cref="Windows.UI.Xaml.Controls.ListViewBase"/></returns>
        public static StretchDirection GetStretchItemContainerDirection(Windows.UI.Xaml.Controls.ListViewBase obj)
        {
            return (StretchDirection)obj.GetValue(StretchItemContainerDirectionProperty);
        }

        /// <summary>
        /// Sets the stretch <see cref="StretchDirection"/> associated with the specified <see cref="Windows.UI.Xaml.Controls.ListViewBase"/>
        /// </summary>
        /// <param name="obj">The <see cref="Windows.UI.Xaml.Controls.ListViewBase"/> to associate the <see cref="StretchDirection"/> with</param>
        /// <param name="value">The <see cref="StretchDirection"/> for binding to the <see cref="Windows.UI.Xaml.Controls.ListViewBase"/></param>
        public static void SetStretchItemContainerDirection(Windows.UI.Xaml.Controls.ListViewBase obj, StretchDirection value)
        {
            obj.SetValue(StretchItemContainerDirectionProperty, value);
        }
    }
}
