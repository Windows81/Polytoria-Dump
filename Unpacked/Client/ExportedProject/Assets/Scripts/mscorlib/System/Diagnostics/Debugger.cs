namespace System.Diagnostics;

[ComVisible(True)]
[Token(Token = "0x200057E")]
public sealed class Debugger
{
	[Token(Token = "0x4001765")]
	public static readonly string DefaultCategory; //Field offset: 0x0

	[Address(RVA = "0x143E0C0", Offset = "0x143D2C0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002834")]
	private static Debugger() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002833")]
	public static void NotifyOfCrossThreadDependency() { }

}

