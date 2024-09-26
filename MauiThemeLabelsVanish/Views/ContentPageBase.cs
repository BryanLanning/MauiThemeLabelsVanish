using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiThemeLabelsVanish.Views;

public abstract class ContentPageBase : ContentPage
{
    // This allows the DI container to new-up a parameterless constructor.
    protected ContentPageBase() { }
}
