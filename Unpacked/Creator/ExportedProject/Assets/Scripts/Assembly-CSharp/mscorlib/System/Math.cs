namespace System;

[Token(Token = "0x200010C")]
public static class Math
{
	[Token(Token = "0x4000430")]
	private static double doubleRoundLimit; //Field offset: 0x0
	[Token(Token = "0x4000431")]
	private static Double[] roundPower10Double; //Field offset: 0x8

	[Address(RVA = "0x14A3470", Offset = "0x14A2670", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000868")]
	private static Math() { }

	[Address(RVA = "0x14A27F0", Offset = "0x14A19F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000855")]
	public static float Abs(float value) { }

	[Address(RVA = "0x14A2800", Offset = "0x14A1A00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000854")]
	public static double Abs(double value) { }

	[Address(RVA = "0x14A27A0", Offset = "0x14A19A0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[Token(Token = "0x6000838")]
	public static int Abs(int value) { }

	[Address(RVA = "0x14A2750", Offset = "0x14A1950", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[Token(Token = "0x6000839")]
	public static long Abs(long value) { }

	[Address(RVA = "0x14A2810", Offset = "0x14A1A10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B010")]
	[Token(Token = "0x6000856")]
	public static double Acos(double d) { }

	[Address(RVA = "0x14A2820", Offset = "0x14A1A20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B2D0")]
	[Token(Token = "0x6000857")]
	public static double Asin(double d) { }

	[Address(RVA = "0x14A2840", Offset = "0x14A1A40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B560")]
	[Token(Token = "0x6000858")]
	public static double Atan(double d) { }

	[Address(RVA = "0x14A2830", Offset = "0x14A1A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B7B0")]
	[Token(Token = "0x6000859")]
	public static double Atan2(double y, double x) { }

	[Address(RVA = "0x14A2850", Offset = "0x14A1A50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Token(Token = "0x600085A")]
	public static double Ceiling(double a) { }

	[Address(RVA = "0x14A2910", Offset = "0x14A1B10", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x600083C")]
	public static int Clamp(int value, int min, int max) { }

	[Address(RVA = "0x14A2860", Offset = "0x14A1A60", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600083D")]
	public static float Clamp(float value, float min, float max) { }

	[Address(RVA = "0x14A29B0", Offset = "0x14A1BB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
	[Token(Token = "0x600085B")]
	public static double Cos(double d) { }

	[Address(RVA = "0x14A29C0", Offset = "0x14A1BC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C3B0")]
	[Token(Token = "0x600085C")]
	public static double Cosh(double value) { }

	[Address(RVA = "0x14A29D0", Offset = "0x14A1BD0", Length = "0x17")]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "System.Char*"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.IPAddressParser", Member = "FormatIPv4AddressNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Char*", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "U8Xml.Internal.XXHash32", Member = "ComputeHashShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "U8Xml.Internal.XXHash32", Member = "ComputeHashFull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600083B")]
	public static int DivRem(int a, int b, out int result) { }

	[Address(RVA = "0x14A29F0", Offset = "0x14A1BF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C7A0")]
	[Token(Token = "0x600085D")]
	public static double Exp(double d) { }

	[Address(RVA = "0x14A2A00", Offset = "0x14A1C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Token(Token = "0x600085E")]
	public static double Floor(double d) { }

	[Address(RVA = "0x14A2A10", Offset = "0x14A1C10", Length = "0x1C1")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "rshift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "rrotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "lrotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "bnot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "lshift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "arshift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "Bitwise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.CallbackArguments", "System.Func`3<UInt32, UInt32, UInt32>"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.Bit32Module", Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "MoonSharp.Interpreter.Execution.VM.Processor", Member = "ExecMod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Execution.VM.Instruction", typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.Expressions.BinaryOperatorExpression", Member = "EvalArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(double))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.MathModule+<>c", Member = "<fmod>b__20_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F9E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600083E")]
	public static double IEEERemainder(double x, double y) { }

	[Address(RVA = "0x14A2C00", Offset = "0x14A1E00", Length = "0xFC")]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator", Member = "GetLog2OfNextPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.MathModule+<>c", Member = "<log>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "Unity.IntegerTime.DiscreteTime", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.Half", Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half", "System.Half"}, ReturnType = "System.Half")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.BloomRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.uint4", Member = "op_OnesComplement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint4"}, ReturnType = "Unity.Mathematics.uint4")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F4B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600083F")]
	public static double Log(double a, double newBase) { }

	[Address(RVA = "0x14A2BF0", Offset = "0x14A1DF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F4B0")]
	[Token(Token = "0x600085F")]
	public static double Log(double d) { }

	[Address(RVA = "0x14A2BE0", Offset = "0x14A1DE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028FCA0")]
	[Token(Token = "0x6000860")]
	public static double Log10(double d) { }

	[Address(RVA = "0x14A2D20", Offset = "0x14A1F20", Length = "0x2B")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.MathModule+<>c", Member = "<max>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "GetNumberOfDecimalsForMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateFloatDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "HSVPicker.HSVUtil", Member = "ConvertRgbToHsv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = "HSVPicker.HsvColor")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000840")]
	public static double Max(double val1, double val2) { }

	[Address(RVA = "0x14A2D00", Offset = "0x14A1F00", Length = "0x8")]
	[CallerCount(Count = 128)]
	[NonVersionable]
	[Token(Token = "0x6000841")]
	public static int Max(int val1, int val2) { }

	[Address(RVA = "0x14A2D70", Offset = "0x14A1F70", Length = "0xB")]
	[CalledBy(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[NonVersionable]
	[Token(Token = "0x6000842")]
	public static long Max(long val1, long val2) { }

	[Address(RVA = "0x14A2D50", Offset = "0x14A1F50", Length = "0x18")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Half", Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half", "System.Half"}, ReturnType = "System.Half")]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_pointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "CombineScissorRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rect", "UnityEngine.Rect"}, ReturnType = "UnityEngine.Rect")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", "UnityEngine.Rect", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnMouseDown", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "ComputeVerticalBlurMargins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FilterFunction"}, ReturnType = "UnityEngine.UIElements.PostProcessingMargins")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "ComputeHorizontalBlurMargins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FilterFunction"}, ReturnType = "UnityEngine.UIElements.PostProcessingMargins")]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", "System.Collections.Generic.List`1<Column>", "System.Collections.Generic.List`1<Column>", typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.GenericDropdownMenu", Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.GenericDropdownMenu", Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.LayoutElementResizer", Member = "UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "KeepInScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rect"}, ReturnType = "UnityEngine.Rect")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.LensDistortionRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 36)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000843")]
	public static float Max(float val1, float val2) { }

	[Address(RVA = "0x14A2D10", Offset = "0x14A1F10", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshHandle", typeof(uint), typeof(uint), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"kcp2k.KcpConfig"}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.Kcp", Member = "SetWindowSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000844")]
	public static uint Max(uint val1, uint val2) { }

	[Address(RVA = "0x14A2DE0", Offset = "0x14A1FE0", Length = "0x18")]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "CombineScissorRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rect", "UnityEngine.Rect"}, ReturnType = "UnityEngine.Rect")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", "UnityEngine.Rect", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TabView", Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.GeometryChangedEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnMouseDown", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToMaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToMinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column", typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToMinWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.ColumnLayout", Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Column>", typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.GenericDropdownMenu", Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.LensDistortionRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Half", Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half", "System.Half"}, ReturnType = "System.Half")]
	[CalledBy(Type = "Mirror.Utils", Member = "KeepInScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rect"}, ReturnType = "UnityEngine.Rect")]
	[CallerCount(Count = 27)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000848")]
	public static float Min(float val1, float val2) { }

	[Address(RVA = "0x14A2DA0", Offset = "0x14A1FA0", Length = "0x2B")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.MathModule+<>c", Member = "<min>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "HSVPicker.HSVUtil", Member = "ConvertRgbToHsv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = "HSVPicker.HsvColor")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000845")]
	public static double Min(double val1, double val2) { }

	[Address(RVA = "0x14A2D80", Offset = "0x14A1F80", Length = "0x8")]
	[CallerCount(Count = 154)]
	[NonVersionable]
	[Token(Token = "0x6000846")]
	public static int Min(int val1, int val2) { }

	[Address(RVA = "0x14A2D90", Offset = "0x14A1F90", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshHandle", typeof(uint), typeof(uint), "Unity.Collections.NativeSlice`1<Vertex>&", "Unity.Collections.NativeSlice`1<UInt16>&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"kcp2k.KcpConfig", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.Kcp", Member = "Flush", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000849")]
	public static uint Min(uint val1, uint val2) { }

	[Address(RVA = "0x14A2DD0", Offset = "0x14A1FD0", Length = "0xB")]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "RunSchedulerLoop", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.FixedSizeReadStream+<ProcessReadAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Crypto.Digests.KeccakDigest", Member = "Squeeze", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Collision", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ContactPairHeader&", "UnityEngine.ContactPair&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.ContactPair", Member = "ExtractContactsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ContactPoint[]", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[NonVersionable]
	[Token(Token = "0x6000847")]
	public static long Min(long val1, long val2) { }

	[Address(RVA = "0x14A2E00", Offset = "0x14A2000", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214CD0")]
	[Token(Token = "0x6000867")]
	private static double ModF(double x, Double* intptr) { }

	[Address(RVA = "0x14A2E10", Offset = "0x14A2010", Length = "0x5")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214CE0")]
	[Token(Token = "0x6000861")]
	public static double Pow(double x, double y) { }

	[Address(RVA = "0x14A2E80", Offset = "0x14A2080", Length = "0x296")]
	[CalledBy(Type = "UnityEngine.CharacterInfo", Member = "get_advance", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.FontEngine", Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = "UnityEngine.TextCore.LowLevel.FontEngineError")]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.FontEngine", Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(float), typeof(int)}, ReturnType = "UnityEngine.TextCore.LowLevel.FontEngineError")]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.FontEngine", Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = "UnityEngine.TextCore.LowLevel.FontEngineError")]
	[CalledBy(Type = "System.Half", Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half", typeof(int), typeof(MidpointRounding)}, ReturnType = "System.Half")]
	[CalledBy(Type = "System.Half", Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half", typeof(int)}, ReturnType = "System.Half")]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "DiscardLeastSignificantDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.Half", Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half", typeof(MidpointRounding)}, ReturnType = "System.Half")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.StringModule", Member = "AdjustIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DynValue", typeof(int)}, ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "SliderLerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.Mathf", Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214CD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600084E")]
	public static double Round(double value, int digits, MidpointRounding mode) { }

	[Address(RVA = "0x14A3120", Offset = "0x14A2320", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Token(Token = "0x600084D")]
	public static double Round(double value, MidpointRounding mode) { }

	[Address(RVA = "0x14A3180", Offset = "0x14A2380", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Token(Token = "0x600084B")]
	public static double Round(double a) { }

	[Address(RVA = "0x14A3190", Offset = "0x14A2390", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x600084A")]
	public static decimal Round(decimal d) { }

	[Address(RVA = "0x14A2E20", Offset = "0x14A2020", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600084C")]
	public static double Round(double value, int digits) { }

	[Address(RVA = "0x14A32A0", Offset = "0x14A24A0", Length = "0x11")]
	[CalledBy(Type = "System.Threading.Timer+TimerComparer", Member = "System.Collections.IComparer.Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Threading.Timer+TimerComparer", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer), typeof(Timer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000850")]
	public static int Sign(long value) { }

	[Address(RVA = "0x14A32C0", Offset = "0x14A24C0", Length = "0x85")]
	[CalledBy(Type = "Battlehub.UIControls.LayoutElementResizer", Member = "UnityEngine.EventSystems.IDragHandler.OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000851")]
	public static int Sign(float value) { }

	[Address(RVA = "0x14A3210", Offset = "0x14A2410", Length = "0x88")]
	[CalledBy(Type = typeof(Math), Member = "IEEERemainder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600084F")]
	public static int Sign(double value) { }

	[Address(RVA = "0x14A3350", Offset = "0x14A2550", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
	[Token(Token = "0x6000862")]
	public static double Sin(double a) { }

	[Address(RVA = "0x14A3360", Offset = "0x14A2560", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D130")]
	[Token(Token = "0x6000863")]
	public static double Sinh(double value) { }

	[Address(RVA = "0x14A3370", Offset = "0x14A2570", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000864")]
	public static double Sqrt(double d) { }

	[Address(RVA = "0x14A3390", Offset = "0x14A2590", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D560")]
	[Token(Token = "0x6000865")]
	public static double Tan(double a) { }

	[Address(RVA = "0x14A33A0", Offset = "0x14A25A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028DD00")]
	[Token(Token = "0x6000866")]
	public static double Tanh(double value) { }

	[Address(RVA = "0x14A33B0", Offset = "0x14A25B0", Length = "0x4E")]
	[CalledBy(Type = typeof(Math), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Math), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[StackTraceHidden]
	[Token(Token = "0x600083A")]
	private static void ThrowAbsOverflow() { }

	[Address(RVA = "0x6FFAD0", Offset = "0x6FECD0", Length = "0xA9")]
	[CalledBy(Type = typeof(Math), Member = "Clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000853")]
	private static void ThrowMinMaxException(T min, T max) { }

	[Address(RVA = "0x14A3400", Offset = "0x14A2600", Length = "0x66")]
	[CalledBy(Type = "System.Half", Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Half"}, ReturnType = "System.Half")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214CD0")]
	[Token(Token = "0x6000852")]
	public static double Truncate(double d) { }

}

