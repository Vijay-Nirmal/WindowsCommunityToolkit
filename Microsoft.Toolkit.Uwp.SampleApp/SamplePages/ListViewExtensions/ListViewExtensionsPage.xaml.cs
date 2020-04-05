// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.ObjectModel;
using Microsoft.Toolkit.Uwp.UI.Extensions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    public sealed partial class ListViewExtensionsPage : Page, IXamlRenderListener
    {
        private ListView sampleListView;
        private TextBlock indexInput;
        private TextBlock itemPlacementInput;
        private TextBlock disableAnimationInput;
        private TextBlock scrollIfVisibileInput;
        private TextBlock additionalHorizontalOffsetInput;
        private TextBlock additionalVerticalOffsetInput;

        public ListViewExtensionsPage()
        {
            this.InitializeComponent();
            Load();
        }

        public void OnXamlRendered(FrameworkElement control)
        {
            sampleListView = control.FindChildByName("SampleListView") as ListView;
            indexInput = control.FindChildByName("IndexInput") as TextBlock;
            itemPlacementInput = control.FindChildByName("ItemPlacementInput") as TextBlock;
            disableAnimationInput = control.FindChildByName("DisableAnimationInput") as TextBlock;
            scrollIfVisibileInput = control.FindChildByName("ScrollIfVisibileInput") as TextBlock;
            additionalHorizontalOffsetInput = control.FindChildByName("AdditionalHorizontalOffsetInput") as TextBlock;
            additionalVerticalOffsetInput = control.FindChildByName("AdditionalVerticalOffsetInput") as TextBlock;

            if (sampleListView != null)
            {
                sampleListView.ItemsSource = GetOddEvenSource(201);
            }
        }

        private void Load()
        {
            SampleController.Current.RegisterNewCommand("Start Smooth Scroll", (sender, args) =>
            {
                var index = int.Parse(indexInput.Text);
                var itemPlacement = (ItemPlacement)Enum.Parse(typeof(ItemPlacement), itemPlacementInput.Text);
                var disableAnimation = bool.Parse(disableAnimationInput.Text);
                var scrollIfVisibile = bool.Parse(scrollIfVisibileInput.Text);
                var additionalHorizontalOffset = int.Parse(additionalHorizontalOffsetInput.Text);
                var additionalVerticalOffset = int.Parse(additionalVerticalOffsetInput.Text);
                sampleListView.SmoothScrollIntoViewWithIndex(index, itemPlacement, disableAnimation, scrollIfVisibile, additionalHorizontalOffset, additionalVerticalOffset);
            });
        }

        private ObservableCollection<string> GetOddEvenSource(int count)
        {
            var oddEvenSource = new ObservableCollection<string>();

            for (int number = 0; number < count; number++)
            {
                var item = (number % 2) == 0 ? $"{number} - Even" : $"{number} - Odd";
                oddEvenSource.Add(item);
            }

            return oddEvenSource;
        }
    }
}
