namespace System.Diagnostics;

[AttributeUsage(13, AllowMultiple = True)]
[ComVisible(True)]
[Token(Token = "0x200057C")]
public sealed class DebuggerTypeProxyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001761")]
	private string typeName; //Field offset: 0x10

	[Address(RVA = "0x143DFF0", Offset = "0x143D1F0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600282F")]
	public DebuggerTypeProxyAttribute(Type type) { }

}

