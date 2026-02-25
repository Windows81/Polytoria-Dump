namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
[Token(Token = "0x200006D")]
public class DebugInfoExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BF")]
	private readonly SymbolDocumentInfo <Document>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700005B")]
	public SymbolDocumentInfo Document
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600026F")]
		 get { } //Length: 5
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x1700005A")]
	public override int EndLine
	{
		[Address(RVA = "0x1594FD0", Offset = "0x15941D0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600026E")]
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x1700005C")]
	public override bool IsClear
	{
		[Address(RVA = "0x1595000", Offset = "0x1594200", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000270")]
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000059")]
	public override int StartLine
	{
		[Address(RVA = "0x1595030", Offset = "0x1594230", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600026D")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600026F")]
	public SymbolDocumentInfo get_Document() { }

	[Address(RVA = "0x1594FD0", Offset = "0x15941D0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600026E")]
	public override int get_EndLine() { }

	[Address(RVA = "0x1595000", Offset = "0x1594200", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000270")]
	public override bool get_IsClear() { }

	[Address(RVA = "0x1595030", Offset = "0x1594230", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600026D")]
	public override int get_StartLine() { }

}

