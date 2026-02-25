namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C3")]
internal static class LayoutProcessor
{
	[Token(Token = "0x40014E6")]
	private static ILayoutProcessor s_Processor; //Field offset: 0x0

	[Address(RVA = "0x1BAEEB0", Offset = "0x1BAE0B0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002951")]
	private static LayoutProcessor() { }

	[Address(RVA = "0x1BAED70", Offset = "0x1BADF70", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002950")]
	public static void CalculateLayout(LayoutNode node, float parentWidth, float parentHeight, LayoutDirection parentDirection) { }

}

