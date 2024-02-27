# ItemsRepeaterOutsideRenderingBugSample
A sample app that reproduces [issue#8028](https://github.com/microsoft/microsoft-ui-xaml/issues/8028) on the WinUI 3 repo.

According to the [answer](https://github.com/microsoft/microsoft-ui-xaml/issues/8028#issuecomment-1965517637) from the WinUI 3 team, this is due to a known DWM limitation which is unlikely to be fixed. Replacing the `ScrollViewer` with a `ScrollView` gets around the DWM limitation.
