using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static class GlfwDelegates {
        [DllImport("glfw")]
        internal static extern int glfwInit();
        [DllImport("glfw")]
        internal static extern void glfwTerminate();
        [DllImport("glfw")]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport("glfw")]
        internal static extern int glfwOpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, int mode);
        [DllImport("glfw")]
        internal static extern void glfwOpenWindowHint(int target, int hint);
        [DllImport("glfw")]
        internal static extern void glfwCloseWindow();
        [DllImport("glfw")]
        internal static extern void glfwSetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);
        [DllImport("glfw")]
        internal static extern void glfwGetWindowSize(out int width, out int height);
        [DllImport("glfw")]
        internal static extern void glfwSetWindowSize(int width, int height);
        [DllImport("glfw")]
        internal static extern void glfwSetWindowPos(int x, int y);
        [DllImport("glfw")]
        internal static extern void glfwIconifyWindow();
        [DllImport("glfw")]
        internal static extern void glfwRestoreWindow();
        [DllImport("glfw")]
        internal static extern void glfwSwapBuffers();
        [DllImport("glfw")]
        internal static extern void glfwSwapInterval(int interval);
        [DllImport("glfw")]
        internal static extern int glfwGetWindowParam(int param);
        [DllImport("glfw")]
        internal static extern void glfwSetWindowSizeCallback(/*GLFWwindowsizefun*/IntPtr cbfun);
        [DllImport("glfw")]
        internal static extern void glfwSetWindowCloseCallback(/*GLFWwindowclosefun*/IntPtr cbfun);
        [DllImport("glfw")]
        internal static extern void glfwSetWindowRefreshCallback(/*GLFWwindowrefreshfun*/IntPtr cbfun);

        [DllImport("glfw")]
        internal static extern int glfwGetVideoModes(/*GLFWvidmode **/IntPtr list, int maxcount);
        [DllImport("glfw")]
        internal static extern void glfwGetDesktopMode(/*GLFWvidmode **/IntPtr mode);

        [DllImport("glfw")]
        internal static extern void glfwPollEvents();
        [DllImport("glfw")]
        internal static extern void glfwWaitEvents();
        [DllImport("glfw")]
        internal static extern int glfwGetKey(int key);
        [DllImport("glfw")]
        internal static extern int glfwGetMouseButton(int button);
        [DllImport("glfw")]
        internal static extern void glfwGetMousePos(out int xpos, out int ypos);
        [DllImport("glfw")]
        internal static extern void glfwSetMousePos(int xpos, int ypos);
        [DllImport("glfw")]
        internal static extern int glfwGetMouseWheel();
        [DllImport("glfw")]
        internal static extern void glfwSetMouseWheel(int pos);
        [DllImport("glfw")]
        internal static extern void glfwSetKeyCallback(/*GLFWkeyfun*/IntPtr cbfun);
        [DllImport("glfw")]
        internal static extern void glfwSetCharCallback(/*GLFWcharfun*/IntPtr cbfun);
        [DllImport("glfw")]
        internal static extern void glfwSetMouseButtonCallback(/*GLFWmousebuttonfun*/IntPtr cbfun);
        [DllImport("glfw")]
        internal static extern void glfwSetMousePosCallback(/*GLFWmouseposfun*/IntPtr cbfun);
        [DllImport("glfw")]
        internal static extern void glfwSetMouseWheelCallback(/*GLFWmousewheelfun*/IntPtr cbfun);

        [DllImport("glfw")]
        internal static extern int glfwGetJoystickParam(int joy, int param);
        [DllImport("glfw")]
        internal static extern int glfwGetJoystickPos(int joy, float[] pos, int numaxes);
        [DllImport("glfw")]
        internal static extern int glfwGetJoystickButtons(int joy, byte[] buttons, int numbuttons);

        [DllImport("glfw")]
        internal static extern double glfwGetTime();
        [DllImport("glfw")]
        internal static extern void glfwSetTime(double time);
        [DllImport("glfw")]
        internal static extern void glfwSleep(double time);

        [DllImport("glfw")]
        internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        [DllImport("glfw")]
        internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
        [DllImport("glfw")]
        internal static extern void glfwGetGLVersion(out int major, out int minor, out int rev);

        [DllImport("glfw")]
        internal static extern /*GLFWthread*/IntPtr glfwCreateThread(/*GLFWthreadfun*/IntPtr fun, IntPtr arg);
        [DllImport("glfw")]
        internal static extern void glfwDestroyThread(/*GLFWthread*/IntPtr ID);
        [DllImport("glfw")]
        internal static extern int glfwWaitThread(/*GLFWthread*/IntPtr ID, int waitmode);
        [DllImport("glfw")]
        internal static extern /*GLFWthread*/IntPtr glfwGetThreadID();
        [DllImport("glfw")]
        internal static extern /*GLFWmutex*/IntPtr glfwCreateMutex();
        [DllImport("glfw")]
        internal static extern void glfwDestroyMutex(/*GLFWmutex*/IntPtr mutex);
        [DllImport("glfw")]
        internal static extern void glfwLockMutex(/*GLFWmutex*/IntPtr mutex);
        [DllImport("glfw")]
        internal static extern void glfwUnlockMutex(/*GLFWmutex*/IntPtr mutex);
        [DllImport("glfw")]
        internal static extern /*GLFWcond*/IntPtr glfwCreateCond();
        [DllImport("glfw")]
        internal static extern void glfwDestroyCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw")]
        internal static extern void glfwWaitCond(/*GLFWcond*/IntPtr cond, /*GLFWmutex*/IntPtr mutex, double timeout);
        [DllImport("glfw")]
        internal static extern void glfwSignalCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw")]
        internal static extern void glfwBroadcastCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw")]
        internal static extern int glfwGetNumberOfProcessors();

        [DllImport("glfw")]
        internal static extern void glfwEnable(int token);
        [DllImport("glfw")]
        internal static extern void glfwDisable(int token);

        [DllImport("glfw")]
        internal static extern int glfwReadImage([MarshalAs(UnmanagedType.LPStr)] string name, /*GLFWimage **/IntPtr img, int flags);
        [DllImport("glfw")]
        internal static extern int glfwReadMemoryImage([MarshalAs(UnmanagedType.LPStr)] string data, long size, /*GLFWimage **/IntPtr img, int flags);
        [DllImport("glfw")]
        internal static extern void glfwFreeImage(/*GLFWimage **/IntPtr img);
        [DllImport("glfw")]
        internal static extern int glfwLoadTexture2D([MarshalAs(UnmanagedType.LPStr)] string name, int flags);
        [DllImport("glfw")]
        internal static extern int glfwLoadMemoryTexture2D(IntPtr data, long size, int flags);
        [DllImport("glfw")]
        internal static extern int glfwLoadTextureImage2D(/*GLFWimage **/IntPtr img, int flags);
    }
}

