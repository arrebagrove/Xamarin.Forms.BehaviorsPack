# Xamarin.Forms.BehaviorsPack

[Japanese](README-ja.md)

Xamarin.Forms.BehaviorsPack is Behavior class library for Xamarin.Forms.  
This library contains the following Behavior implementation.  

|Name|Overview|
|:--|:--|
|[EventToCommandBehavior](docs/EventToCommandBehavior-ja.md)|Execute ICommand when an event fires in UI Controls.|
|[DisplayActionSheetBehavior](docs/DisplayActionSheetBehavior-ja.md)|Display ActionSheet and execute ICommand corresponding to user operation.|
|[DisplayAlertBehavior](doc/DisplayAlertBehavior-ja.md)|Display Alert and execute ICommand corresponding to user operation.|

In addition, it contains abstract class that facilitates Behavior implementation.  

This library facilitates the implementation of interaction between View and ViewModel when MVVM pattern.  

## How to install  

Install from NuGet.  

```
> Install-Package Xamarin.Forms.BehaviorsPack
```

[https://www.nuget.org/packages/Xamarin.Forms.BehaviorsPack](https://www.nuget.org/packages/Xamarin.Forms.BehaviorsPack)

## Precondition  

In the sample code of this library, it is assumed that the library namespace is declared at the beginning of XAML.  

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:behaviorsPack="clr-namespace:Xamarin.Forms.BehaviorsPack;assembly=Xamarin.Forms.BehaviorsPack"
```

## How to Use  

* [EventToCommandBehavior](docs/EventToCommandBehavior.md)  
* [DisplayActionSheetBehavior](docs/DisplayActionSheetBehavior.md)  
* [DisplayAlertBehavior](doc/DisplayAlertBehavior.md)

* [ICommand execution common specification](CommandExecutionSpecifation.md)  