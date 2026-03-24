using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace prgPMR.WPF.Infrastructure.Converters;

/// <summary>True → Visible, False → Collapsed</summary>
[ValueConversion(typeof(bool), typeof(Visibility))]
public class BoolToVisibilityConverter : IValueConverter
{
    public static readonly BoolToVisibilityConverter Instance = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is true ? Visibility.Visible : Visibility.Collapsed;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => value is Visibility.Visible;
}

/// <summary>True → Collapsed, False → Visible (inverse)</summary>
[ValueConversion(typeof(bool), typeof(Visibility))]
public class InverseBoolToVisibilityConverter : IValueConverter
{
    public static readonly InverseBoolToVisibilityConverter Instance = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is true ? Visibility.Collapsed : Visibility.Visible;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => value is Visibility.Collapsed;
}

/// <summary>Null → Collapsed, non-null → Visible</summary>
[ValueConversion(typeof(object), typeof(Visibility))]
public class NullToVisibilityConverter : IValueConverter
{
    public static readonly NullToVisibilityConverter Instance = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is null ? Visibility.Collapsed : Visibility.Visible;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotSupportedException();
}

/// <summary>DateOnly? → formatted string, DBNull/null → empty string</summary>
public class DateOnlyConverter : IValueConverter
{
    public static readonly DateOnlyConverter Instance = new();
    private const string Format = "MM/dd/yyyy";

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is DateOnly d ? d.ToString(Format) : string.Empty;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => value is string s && DateOnly.TryParse(s, out var d) ? d : (DateOnly?)null;
}
