﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using OpenCvSharp;
using OpenCvSharp.Utilities;

#pragma warning disable 1591

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// P/Invoke methods of OpenCV 2.x C++ interface
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    internal static partial class CppInvoke
    {
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_SVD_new1")]
        public static extern IntPtr core_SVD_new();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_SVD_new2")]
        public static extern IntPtr core_SVD_new(IntPtr src, int flags);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_SVD_delete(IntPtr obj);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_SVD_operatorThis(IntPtr obj, IntPtr src, int flags);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_SVD_backSubst(IntPtr obj, IntPtr rhs, IntPtr dst);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_SVD_static_compute1")]
        public static extern void core_SVD_static_compute(IntPtr src, IntPtr w, IntPtr u, IntPtr vt, int flags);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_SVD_static_compute2")]
        public static extern void core_SVD_static_compute(IntPtr src, IntPtr w, int flags);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_SVD_static_backSubst(IntPtr w, IntPtr u, IntPtr vt, IntPtr rhs, IntPtr dst);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_SVD_static_solveZ(IntPtr src, IntPtr dst);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_SVD_u(IntPtr obj);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_SVD_w(IntPtr obj);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_SVD_vt(IntPtr obj);

    }
}