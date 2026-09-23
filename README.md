[![Microsoft Store Badge](https://img.shields.io/badge/Microsoft%20Store-005FB8?logo=microsoftstore&logoColor=fff&style=flat)](https://apps.microsoft.com/detail/9MSX91WQCM2V?)
[![Release](https://img.shields.io/github/v/release/clementgre/ThreeFingerDragOnWindows?label=Download%20version)](https://github.com/clementgre/ThreeFingerDragOnWindows/releases/latest)
[![TotalDownloads](https://img.shields.io/github/downloads/clementgre/ThreeFingerDragOnWindows/total)](https://github.com/clementgre/ThreeFingerDragOnWindows/releases/latest)
[![LatestDownloads](https://img.shields.io/github/downloads/clementgre/ThreeFingerDragOnWindows/latest/total)](https://github.com/clementgre/ThreeFingerDragOnWindows/releases/latest)

## Overview

ThreeFingerDragOnWindows aims to bring the macOS-style three-finger dragging functionality to Windows Precision touchpads.

With a simple touchpad gesture, this app allows you to drag windows and select text (by emulating a cursor drag by holding down the left mouse button).

ThreeFingerDragOnWindows 旨在将 macOS 风格的三指拖拽功能带到 Windows Precision 触摸板上。

只需简单的触摸板手势，这款应用就能拖动窗口和选择文本（通过模拟按住左键的光标拖拽）。



## Preview
<p align="center">
  <img src='https://raw.githubusercontent.com/ClementGre/ThreeFingerDragOnWindows/main/ThreeFingerDragOnWindows/Assets/Screenshot-1.png' alt="App screenshot: Touchpad tab" width='700'>
  <img src='https://raw.githubusercontent.com/ClementGre/ThreeFingerDragOnWindows/main/ThreeFingerDragOnWindows/Assets/Screenshot-2.png' alt="App screenshot: Three Finger Drag tab" width='700'>
  <img src='https://raw.githubusercontent.com/ClementGre/ThreeFingerDragOnWindows/main/ThreeFingerDragOnWindows/Assets/Screenshot-3.png' alt="App screenshot: Other Settings tab" width='700'>
</p>

## Installation

If the installation fails, your computer might need to have the Windows App SDK redistributable installed. You can download it from this page: [https://learn.microsoft.com/en-us/windows/apps/windows-app-sdk/downloads](https://learn.microsoft.com/en-us/windows/apps/windows-app-sdk/downloads).

安装
如果安装失败，你的电脑可能需要安装Windows App SDK可再分发软件。你可以从这个页面下载：https://learn.microsoft.com/en-us/windows/apps/windows-app-sdk/downloads。

## How to use

Make sure to disable the "Tap twice and drag to multi-select" behaviour and all of the default 3-finger swipe behaviour
via ``Touchpad settings`` in Windows preferences for the drag to work without interferences.

To open the configuration pane, click the ThreeFingerDragOnWindows tray icon on the Windows taskbar.

如何使用
确保禁用“点击两下后拖动多选”行为和所有默认的三指滑动行为 通过Windows偏好设置，拖曳功能会不受干扰地使用。Touchpad settings

要打开配置面板，请点击Windows任务栏上的ThreeFingerDragOnWindows托盘图标。

## Build and Execute

The app can be built and run in Microsoft Visual Studio or Jetbrains Rider.

建造与执行
该应用可以在 Microsoft Visual Studio 或 Jetbrains Rider 中构建和运行。

## Libraries used

The app is a WinUI 3 app, that uses the [Microsoft.UI.Xaml](https://docs.microsoft.com/en-us/windows/apps/winui/winui3/) library.

使用的库
该应用是 WinUI 3 应用，使用 Microsoft.UI.Xaml 库。

Other libraries used:
- [emoacht/RawInput.Touchpad](https://github.com/emoacht/RawInput.Touchpad) Allows to get the raw input of the touchpad (included in the source code as TouchpadHelper.cs).
- [HavenDV/H.NotifyIcon](https://github.com/HavenDV/H.NotifyIcon) API for Windows taskbar tray icon in a WinUI app.
- [dahall/TaskScheduler](https://github.com/dahall/TaskScheduler) API for Windows TaskScheduler (used for the skipUAC).

其他使用的库：

emoacht/RawInput.Touchpad允许获取触摸板的原始输入（源代码中包含在TouchpadHelper.cs中）。
HavenDV/H.NotifyIconWindows 任务栏托盘图标在 WinUI 应用中。
dahall/任务调度器Windows 任务调度器的 API（用于 skipUAC）。

<a href="https://apps.microsoft.com/detail/9msx91wqcm2v?mode=direct">
	<img src="https://get.microsoft.com/images/fr%20dark.svg" width="200"/>
</a>
