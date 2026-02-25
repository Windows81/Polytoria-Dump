namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C4")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class InvokeMeasureFunctionDelegate : MulticastDelegate
{

	[Address(RVA = "0x1BA82E0", Offset = "0x1BA74E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002952")]
	public InvokeMeasureFunctionDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x1BA82C0", Offset = "0x1BA74C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002953")]
	public override void Invoke(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result) { }

}

