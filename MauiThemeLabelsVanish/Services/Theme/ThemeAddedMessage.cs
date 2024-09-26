
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiThemeLabelsVanish.Services.Theme;

public class ThemeAddedMessage : ValueChangedMessage<string>
{
    public ThemeAddedMessage(string value) : base(value) { }
}
