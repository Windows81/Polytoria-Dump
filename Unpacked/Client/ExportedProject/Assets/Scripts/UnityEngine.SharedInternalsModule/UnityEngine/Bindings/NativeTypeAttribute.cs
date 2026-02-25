namespace UnityEngine.Bindings;

[AttributeUsage(28)]
[Token(Token = "0x2000011")]
[VisibleToOtherModules]
internal class NativeTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000016")]
	private string <Header>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000017")]
	private string <IntermediateScriptingStructName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000018")]
	private CodegenOptions <CodegenOptions>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700000F")]
	public override CodegenOptions CodegenOptions
	{
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000023")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000D")]
	public override string Header
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000E")]
	public string IntermediateScriptingStructName
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1A19A30", Offset = "0x1A18C30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	public NativeTypeAttribute() { }

	[Address(RVA = "0x1A199C0", Offset = "0x1A18BC0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	public NativeTypeAttribute(CodegenOptions codegenOptions) { }

	[Address(RVA = "0x1A198A0", Offset = "0x1A18AA0", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000026")]
	public NativeTypeAttribute(string header) { }

	[Address(RVA = "0x1A199F0", Offset = "0x1A18BF0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	public override void set_CodegenOptions(CodegenOptions value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000021")]
	public override void set_Header(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000022")]
	public void set_IntermediateScriptingStructName(string value) { }

}

