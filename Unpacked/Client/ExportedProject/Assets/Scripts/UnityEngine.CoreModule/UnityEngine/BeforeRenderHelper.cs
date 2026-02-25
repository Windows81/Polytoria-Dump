namespace UnityEngine;

[Token(Token = "0x200009E")]
internal static class BeforeRenderHelper
{
	[Token(Token = "0x200009F")]
	private struct OrderBlock
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D0")]
		internal int order; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D1")]
		internal UnityAction callback; //Field offset: 0x8

	}

	[Token(Token = "0x40001CF")]
	private static List<OrderBlock> s_OrderBlocks; //Field offset: 0x0

	[Address(RVA = "0x191EC40", Offset = "0x191DE40", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000347")]
	private static BeforeRenderHelper() { }

	[Address(RVA = "0x191EAA0", Offset = "0x191DCA0", Length = "0x190")]
	[CalledBy(Type = typeof(Application), Member = "InvokeOnBeforeRender", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000346")]
	public static void Invoke() { }

}

