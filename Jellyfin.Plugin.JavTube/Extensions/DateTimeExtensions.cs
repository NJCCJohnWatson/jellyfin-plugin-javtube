namespace Jellyfin.Plugin.JavTube.Extensions;

internal static class DateTimeExtensions
{
    public static DateTime? GetValidDateTime(this DateTime dateTime)
    {
        return dateTime.Year > 1 ? dateTime : null;
    }

    public static int? GetValidYear(this DateTime dateTime)
    {
        return dateTime.GetValidDateTime()?.Year;
    }
}