# ExpressionAnimationRegression Readme

This is a min repro app to showcase a regression with ExpressionAnimation following cursor position. It no longer works when the main button is pressed.

### Repro steps

1. Change project to x64
2. Run ExpressionAnimationRegression.UWP
3. Mouse move around
4. Notice that the blue shape follows the cursor
5. Click, hold mouse down and move mouse around
6. Notice that the blue shape follows the cursor
7. Run ExpressionAnimationRegression.WinAppSDK
8. Move mouse around
9. Notice that the blue shape follows the cursor
10. Click, hold mouse down and move mouse around
11. Notice that the blue shape does NOT follow the cursor

You can see the code in the MainPage.xaml.cs in InitializeAnimation() on line 22.