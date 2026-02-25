namespace System.Diagnostics;

[AttributeUsage(384, AllowMultiple = False)]
[ComVisible(True)]
[Token(Token = "0x200057B")]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001760")]
	private DebuggerBrowsableState state; //Field offset: 0x10

	[Address(RVA = "0x143DED0", Offset = "0x143D0D0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600282E")]
	public DebuggerBrowsableAttribute(DebuggerBrowsableState state) { }

}

