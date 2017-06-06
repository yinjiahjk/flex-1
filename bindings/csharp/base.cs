// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See the LICENSE.txt file in the project root
// for the license information.

// This file was generated by generate_base.rb. Do not edit manually.

using System;
using System.Runtime.InteropServices;

public enum FlexAlign : int {
    Auto = 0,
    Stretch = 1,
    Center = 2,
    Start = 3,
    End = 4,
    SpaceBetween = 5,
    SpaceAround = 6,
    SpaceEvenly = 7,
}

public enum FlexDirection : int {
    Row = 0,
    RowReverse = 1,
    Column = 2,
    ColumnReverse = 3,
}

public enum FlexPosition : int {
    Relative = 0,
    Absolute = 1,
}

public enum FlexWrap : int {
    Nowrap = 0,
    Wrap = 1,
    WrapReverse = 2,
}

public class FlexNativeFunctions {
    private const string dll_name = "flex";
    [DllImport(dll_name)] public static extern void flex_item_add (IntPtr arg1, IntPtr arg2);
    [DllImport(dll_name)] public static extern IntPtr flex_item_child (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern int flex_item_count (IntPtr arg1);
    [DllImport(dll_name)] public static extern IntPtr flex_item_delete (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_free (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_align_content (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_align_items (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_align_self (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_basis (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_bottom (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_direction (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_frame_height (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_frame_width (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_frame_x (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_frame_y (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_grow (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_height (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_justify_content (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_left (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_margin_bottom (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_margin_left (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_margin_right (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_margin_top (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_order (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_padding_bottom (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_padding_left (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_padding_right (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_padding_top (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_position (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_right (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_shrink (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_top (IntPtr arg1);
    [DllImport(dll_name)] public static extern float flex_item_get_width (IntPtr arg1);
    [DllImport(dll_name)] public static extern int flex_item_get_wrap (IntPtr arg1);
    [DllImport(dll_name)] public static extern void flex_item_insert (IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport(dll_name)] public static extern IntPtr flex_item_new ();
    [DllImport(dll_name)] public static extern IntPtr flex_item_parent (IntPtr arg1);
    [DllImport(dll_name)] public static extern IntPtr flex_item_root (IntPtr arg1);
    [DllImport(dll_name)] public static extern void flex_item_set_align_content (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_align_items (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_align_self (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_basis (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_bottom (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_direction (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_grow (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_height (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_justify_content (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_left (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_margin_bottom (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_margin_left (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_margin_right (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_margin_top (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_order (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_padding_bottom (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_padding_left (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_padding_right (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_padding_top (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_position (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_right (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_shrink (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_top (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_width (IntPtr arg1, float arg2);
    [DllImport(dll_name)] public static extern void flex_item_set_wrap (IntPtr arg1, int arg2);
    [DllImport(dll_name)] public static extern void flex_layout (IntPtr arg1);
}