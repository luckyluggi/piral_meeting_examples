# Repro Steps
- `cd ./appshell` and run `npm i` and then `npm run build`
- `cd ../SuperCoolApp.Ui` and run `dotnet build`
- `cd ../Layout.Ui` and run `dotnet build`
- `cd ../piral~/SuperCoolApp.Ui` and run `npm start`

# Problems
1. If you uncomment the third line in `SuperCoolApp.Ui\Components\GenericComponent.razor` an error is shown in the browsers console. (Because the component has `@typeparam T` and `@attribute [PiralComponent]`)
2. If the 3rd Line in `SuperCoolApp.Ui\Components\GenericComponent.razor` is still commented we should still get the error, because `GenericComponent` inherits  `Framework\BaseComponent.cs` and `BaseComponent` already has `[PiralComponent set]`. So it looks like that the attribute is not inherited.
3. When the app loads the following error is shown in the browsers console: `Cannot provide a value for property '_jsService' on type 'SuperCoolApp.Ui.Pages.LoadOrder'. `. We need a way to always load the Layout pilet first.
4. The appshell shows a loading animation at start. This is implemented here `appshell\src\index.html`, but we need a way to wait for all pilets to be loaded and only then switch from loading animation to The loaded app view.
5. Here `SuperCoolApp.Ui\Pages\ExtensionPage.razor` The Extension should get Values passed in, but that does not work.
6. Here `SuperCoolApp.Ui\Pages\Logger.razor` we'd need a way to configure the ILogger to also log Debug Logs.