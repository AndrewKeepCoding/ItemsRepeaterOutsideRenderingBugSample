// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using System.Collections.Generic;

namespace ItemsRepeaterOutsideRenderingBugSample;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        List<int> items = new();

        for (int i = 0; i < this.ItemsCountControl.Value; i++)
        {
            items.Add(i);
        }

        this.ItemsRepeaterControl.ItemsSource = items;
    }
}