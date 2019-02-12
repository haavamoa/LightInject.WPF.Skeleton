# LightInject.WPF.Skeleton

## The flow of the application:

- The application starts
  - Hits `void OnStartup(StartupEventArgs e)` in `App.xaml.cs`

- The app create a new instance of `LightInject`s `ServiceContainer`.
  - Turns off `Property Injection`, because this will be troublesome when dealing with WPF.
  
- The app uses the `ServiceContainer` to register instances to the container with a `CompositionRoot`.
  
- `CompositionRoot` tells the container about the instance of `IShellViewModel` and the `MainWindow`
  
- When `CompositionRoot` has been registered, the app tries to get a intance of `MainWindow` and runs `.Show()` on it.

## Explanation

When the container creates the instance of `MainWindow`, it also has to create a instance of `ShellViewModel`. (Because this is a dependency of the `MainWindow`).
`MainWindow` uses the instance of `ShellViewModel` to:
    - Set its `DataContext`
    - Subscribe to the `MainWindow`s `Loaded` event, in order to run `ShellViewModel`s `Initialize` (Which is a `Task`).

## Result

When the app is loaded, one should see a `<TextBlock>` with the text: `ShellViewModel was initialized`.

### Notice

Remember to remove `StartupUri="MainWindow.xaml"` in `App.xaml`. If this is not removed, the `MainWindow` constructor will be called to early.