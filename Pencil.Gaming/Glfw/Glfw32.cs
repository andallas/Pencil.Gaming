// License: ../LICENSE.TXT

using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static class Glfw32 {
        private const string lib = "natives32/glfw.dll";

        [DllImport(Glfw32.lib)]
        internal static extern int glfwInit();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwTerminate();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport(Glfw32.lib)]
        internal static extern int glfwOpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, int mode);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwOpenWindowHint(int target, int hint);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwCloseWindow();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwGetWindowSize(out int width, out int height);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetWindowSize(int width, int height);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetWindowPos(int x, int y);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwIconifyWindow();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwRestoreWindow();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSwapBuffers();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSwapInterval(int interval);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetWindowParam(int param);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetWindowSizeCallback(GlfwWindowSizeFun cbfun);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetWindowCloseCallback(GlfwWindowCloseFun cbfun);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetWindowRefreshCallback(GlfwWindowRefreshFun cbfun);

        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetVideoModes([MarshalAs(UnmanagedType.LPArray)] GlfwVidMode[] list, int maxcount);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwGetDesktopMode(out GlfwVidMode mode);

        [DllImport(Glfw32.lib)]
        internal static extern void glfwPollEvents();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwWaitEvents();
        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetKey(int key);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetMouseButton(int button);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwGetMousePos(out int xpos, out int ypos);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetMousePos(int xpos, int ypos);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetMouseWheel();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetMouseWheel(int pos);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetKeyCallback(GlfwKeyFun cbfun);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetCharCallback(GlfwCharFun cbfun);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetMouseButtonCallback(GlfwMouseButtonFun cbfun);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetMousePosCallback(GlfwMousePosFun cbfun);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetMouseWheelCallback(GlfwMouseWheelFun cbfun);

        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetJoystickParam(int joy, int param);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetJoystickPos(int joy, [MarshalAs(UnmanagedType.LPArray)] float[] pos, int numaxes);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwGetJoystickButtons(int joy, [MarshalAs(UnmanagedType.LPArray)] byte[] buttons, int numbuttons);

        [DllImport(Glfw32.lib)]
        internal static extern double glfwGetTime();
        [DllImport(Glfw32.lib)]
        internal static extern void glfwSetTime(double time);

        [DllImport(Glfw32.lib)]
        internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        [DllImport(Glfw32.lib)]
        internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwGetGLVersion(out int major, out int minor, out int rev);

        [DllImport(Glfw32.lib)]
        internal static extern void glfwEnable(int token);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwDisable(int token);

        [DllImport(Glfw32.lib)]
        internal static extern int glfwReadImage([MarshalAs(UnmanagedType.LPStr)] string name, out GlfwImage img, int flags);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwReadMemoryImage(IntPtr data, long size, ref GlfwImage img, int flags);
        [DllImport(Glfw32.lib)]
        internal static extern void glfwFreeImage(ref GlfwImage img);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwLoadTexture2D([MarshalAs(UnmanagedType.LPStr)] string name, int flags);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwLoadMemoryTexture2D(IntPtr data, long size, int flags);
        [DllImport(Glfw32.lib)]
        internal static extern int glfwLoadTextureImage2D(ref GlfwImage img, int flags);
    }
}

