namespace System.Runtime.CompilerServices;

[AttributeUsage(11148)]
[CLSCompliant(False)]
[Token(Token = "0x200047E")]
public sealed class TupleElementNamesAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001257")]
	private readonly String[] _transformNames; //Field offset: 0x10

	[Address(RVA = "0x13CD7C0", Offset = "0x13CC9C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600203E")]
	public TupleElementNamesAttribute(String[] transformNames) { }

}

