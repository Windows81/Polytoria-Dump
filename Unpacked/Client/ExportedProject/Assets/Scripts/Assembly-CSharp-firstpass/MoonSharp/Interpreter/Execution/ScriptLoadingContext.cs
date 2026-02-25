namespace MoonSharp.Interpreter.Execution;

[Token(Token = "0x2000145")]
internal class ScriptLoadingContext
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E3")]
	private Script <Script>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E4")]
	private BuildTimeScope <Scope>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004E5")]
	private SourceCode <Source>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004E6")]
	private bool <Anonymous>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40004E7")]
	private bool <IsDynamicExpression>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004E8")]
	private Lexer <Lexer>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x1700019C")]
	public bool Anonymous
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF6")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700019D")]
	public bool IsDynamicExpression
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF8")]
		 get { } //Length: 5
		[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700019E")]
	public Lexer Lexer
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFA")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700019A")]
	public BuildTimeScope Scope
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF2")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000199")]
	public private Script Script
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF0")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700019B")]
	public SourceCode Source
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF4")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF5")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFC")]
	public ScriptLoadingContext(Script s) { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF6")]
	public bool get_Anonymous() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF8")]
	public bool get_IsDynamicExpression() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFA")]
	public Lexer get_Lexer() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF2")]
	public BuildTimeScope get_Scope() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF0")]
	public Script get_Script() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF4")]
	public SourceCode get_Source() { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF7")]
	public void set_Anonymous(bool value) { }

	[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF9")]
	public void set_IsDynamicExpression(bool value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFB")]
	public void set_Lexer(Lexer value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF3")]
	public void set_Scope(BuildTimeScope value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF1")]
	private void set_Script(Script value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF5")]
	public void set_Source(SourceCode value) { }

}

