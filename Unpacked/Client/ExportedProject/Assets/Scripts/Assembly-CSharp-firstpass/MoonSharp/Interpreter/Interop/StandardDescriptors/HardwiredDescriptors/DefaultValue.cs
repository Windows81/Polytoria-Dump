namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors;

[Token(Token = "0x200011A")]
public sealed class DefaultValue
{
	[Token(Token = "0x4000471")]
	public static readonly DefaultValue Instance; //Field offset: 0x0

	[Address(RVA = "0x353BC0", Offset = "0x352DC0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A9D")]
	private static DefaultValue() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9C")]
	public DefaultValue() { }

}

