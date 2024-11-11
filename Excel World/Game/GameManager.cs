using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Excel_World.Game;
public static class GameManager
{
    private static Stopwatch stopwatch; // 用于记录帧时间
    private static bool isRunning = false; // 控制更新循环是否运行

    public static double DeltaTime { get; private set; } // 每帧的时间间隔
    public static double FixedDeltaTime { get; private set; } = 1.0 / 30.0; // 固定更新间隔，30次/秒

    public static Project Project;
    static GameManager()
    {
        stopwatch = new Stopwatch();
        Project = new Project();
    }

    public static void Start()
    {
        if (isRunning) return;

        isRunning = true;
        stopwatch.Start();

        // 使用 Task 在后台启动 Update 和 FixedUpdate 循环
        Task.Run(UpdateLoop);
        Task.Run(FixedUpdateLoop);
    }

    public static void Finish()
    {
        if (!isRunning) return;

        isRunning = false;
        stopwatch.Stop();

        Debug.WriteLine("GameManager has finished.");
    }

    private static void UpdateLoop()
    {
        while (isRunning)
        {
            DeltaTime = stopwatch.Elapsed.TotalSeconds;
            stopwatch.Restart();

            Project.Update((float)DeltaTime);

            // 控制帧率（例如60帧/秒）
            Thread.Sleep(16);
        }
    }

    private static void FixedUpdateLoop()
    {
        while (isRunning)
        {
            Project.FixedUpdate((float)DeltaTime);

            // 等待固定时间间隔
            Thread.Sleep((int)(FixedDeltaTime * 1000));
        }
    }
}