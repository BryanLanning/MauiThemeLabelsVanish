using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiThemeLabelsVanish.Services.Theme;

public class ThemeChangedMessage : ValueChangedMessage<string>
{
    public ThemeChangedMessage(string value) : base(value) { }
}
