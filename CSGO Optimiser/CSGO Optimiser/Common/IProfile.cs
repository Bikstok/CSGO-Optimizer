﻿
namespace Common
{
    public interface IProfile
    {
        string Name { get; set; }
        string Config { get; set; }
        string Crosshair { get; set; }
        string Autoexec { get; set; }
        string VideoSettings { get; set; }
        string LaunchOptions { get; set; }
        string NvidiaProfile { get; set; }
        bool DisabledMouseAcc { get; set; }
        bool DisabledIngameMouseAcc { get; set; }
        bool DisabledCapsLock { get; set; }
        bool DisabledVisualThemes { get; set; }
        string FolderPath { get; set; }
    }
}
