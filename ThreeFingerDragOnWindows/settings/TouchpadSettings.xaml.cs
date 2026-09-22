using System;
using System.Linq;
using ThreeFingerDragOnWindows.utils;

namespace ThreeFingerDragOnWindows.settings;

public sealed partial class TouchpadSettings {

    public TouchpadSettings(){
        InitializeComponent();
        if(App.Instance.HandlerWindow == null || !App.Instance.HandlerWindow.TouchpadInitialized){
            Loader.Visibility = Microsoft.UI.Xaml.Visibility.Visible;
            TouchpadStatus.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
            ContactsDebug.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
        } else{
            OnTouchpadInitialized();
        }
    }

    public void UpdateContactsText(string text){
        ContactsDebug.Title = "输入：\n" + text;
    }

    public void OnTouchpadInitialized(){
        Loader.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
        TouchpadStatus.Visibility = Microsoft.UI.Xaml.Visibility.Visible;
        
        if(App.Instance.HandlerWindow.TouchpadExists){
            if(App.Instance.HandlerWindow.InputReceiverInstalled) {
                string deviceInfosString = String.Join("\n", TouchpadHelper.GetAllDeivceInfos().Select(deviceInfo => deviceInfo.ToString()));
                TouchpadStatus.Title = "触控板存在且已注册！\n" + deviceInfosString;
                TouchpadStatus.Severity = Microsoft.UI.Xaml.Controls.InfoBarSeverity.Success;
                ContactsDebug.Visibility = Microsoft.UI.Xaml.Visibility.Visible;
            } else{
                TouchpadStatus.Title = "触控板存在，但无法安装输入接收器！";
                TouchpadStatus.Severity = Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning;
                ContactsDebug.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
            } 
        } else{
            TouchpadStatus.Title = "未检测到触控板，请确保你使用的是兼容 Windows 精确式触控板（Windows Precision）的触控板。";
            TouchpadStatus.Severity = Microsoft.UI.Xaml.Controls.InfoBarSeverity.Error;
            ContactsDebug.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
        }
    }

}