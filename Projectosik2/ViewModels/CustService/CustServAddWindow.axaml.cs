﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Projectosik2.ViewModels.CustService;

public partial class CustServAddWindow : Window
{
    public CustServAddWindow()
    {
        InitializeComponent();
    }

    private void SaveBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}