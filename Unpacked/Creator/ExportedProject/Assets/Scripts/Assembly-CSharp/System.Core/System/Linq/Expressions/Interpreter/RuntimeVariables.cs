namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000206")]
internal sealed class RuntimeVariables : IRuntimeVariables
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000387")]
	private readonly IStrongBox[] _boxes; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009BC")]
	private RuntimeVariables(IStrongBox[] boxes) { }

	[Address(RVA = "0x15E3880", Offset = "0x15E2A80", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009BD")]
	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }

}

