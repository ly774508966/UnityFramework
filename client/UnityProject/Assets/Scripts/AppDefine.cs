﻿using UnityEngine;

/// <summary>
/// 全局常量
/// </summary>
public static class AppConst
{
    /// <summary>
    /// 服务器IP
    /// </summary>
    public static string ServerIp = "192.168.1.58";

    /// <summary>
    /// 服务器端口
    /// </summary>
    public static int ServerPort = 7000;

    /// <summary>
    /// 限帧（-1： 不限制）
    /// </summary>
    public static int FrameRate = 30;
    
    /// <summary>
    /// 垂直同步
    /// </summary>
    public static int VSyncCount = 0;

    /// <summary>
    /// 调试模式-用于内部测试
    /// </summary>
    public static bool IsDebugMode = true;


    /// <summary>
    /// 资源目录路径（流文件夹）
    /// </summary>
    public static string AssetDirName = "StreamingAssets";

    /// <summary>
    /// 约定分辨率
    /// </summary>
    public static Vector2 ReferenceResolution = new Vector2(640, 1136);


    public static string UserId = string.Empty;
    public static string AppName = "HDXX";
    public static string AppPrefix = AppName + "_";

}

/// <summary>
/// 管理器名
/// </summary>
public struct ManagerName
{
    public const string LSharp = "LSharpManager";
    public const string Game = "GameController";
    public const string Timer = "TimerManager";
    public const string Music = "MusicManager";
    public const string Panel = "PanelManager";
    public const string Network = "NetworkManager";
    public const string Asset = "AssetLoadManager";
    public const string Croutine = "CroutineManager";
    public const string Scene = "SceneManager";
    public const string Gesture = "GestureManager";
    public const string ResourcesUpdate = "ResourcesUpdateManager";
}
