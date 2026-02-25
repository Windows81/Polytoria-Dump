namespace System.Runtime.CompilerServices;

[AttributeUsage(1036, AllowMultiple = True, Inherited = False)]
[Token(Token = "0x200049D")]
internal sealed class TypeDependencyAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400128B")]
	private string typeName; //Field offset: 0x10

	[Address(RVA = "0x13CE0C0", Offset = "0x13CD2C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020A8")]
	public TypeDependencyAttribute(string typeName) { }

}

