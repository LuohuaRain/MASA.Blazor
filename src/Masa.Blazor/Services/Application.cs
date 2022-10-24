﻿using System.ComponentModel;
using BlazorComponent.Applicationable;

namespace Masa.Blazor;

public class Application : BlazorComponent.Services.IApplication, INotifyPropertyChanged
{
    private double _bar;
    private double _top;
    private double _left;
    private double _insetFooter;
    private double _right;
    private double _bottom;
    private double _footer;
    private bool _isBooted;

    public double Bar
    {
        get => _bar;
        internal set
        {
            if (_bar != value)
            {
                _bar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bar)));
            }
        }
    }

    public double Top
    {
        get => _top;
        internal set
        {
            if (_top != value)
            {
                _top = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Top)));
            }
        }
    }

    public double Left
    {
        get => _left;
        internal set
        {
            if (_left != value)
            {
                _left = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Left)));
            }
        }
    }

    public double InsetFooter
    {
        get => _insetFooter;
        internal set
        {
            if (_insetFooter != value)
            {
                _insetFooter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(InsetFooter)));
            }
        }
    }

    public double Right
    {
        get => _right;
        internal set
        {
            if (_right != value)
            {
                _right = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Right)));
            }
        }
    }

    public double Bottom
    {
        get => _bottom;
        internal set
        {
            if (_bottom != value)
            {
                _bottom = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bottom)));
            }
        }
    }

    public double Footer
    {
        get => _footer;
        internal set
        {
            if (_footer != value)
            {
                _footer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Footer)));
            }
        }
    }

    public bool IsBooted
    {
        get => _isBooted;
        internal set
        {
            if (_isBooted != value)
            {
                _isBooted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsBooted)));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void Update(TargetProp prop, double value)
    {
        switch (prop)
        {
            case TargetProp.Bar:
                Bar = value;
                break;
            case TargetProp.Top:
                Top = value;
                break;
            case TargetProp.Right:
                Right = value;
                break;
            case TargetProp.Bottom:
                Bottom = value;
                break;
            case TargetProp.Left:
                Left = value;
                break;
            case TargetProp.Footer:
                Footer = value;
                break;
            case TargetProp.InsetFooter:
                InsetFooter = value;
                break;
            case TargetProp.Unset:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(prop), prop, null);
        }
    }
}
