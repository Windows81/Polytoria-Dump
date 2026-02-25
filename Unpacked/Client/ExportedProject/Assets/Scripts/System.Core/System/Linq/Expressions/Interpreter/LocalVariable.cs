namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A2")]
internal sealed class LocalVariable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000323")]
	public readonly int Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000324")]
	private int _flags; //Field offset: 0x14

	[Token(Token = "0x170001C7")]
	public bool InClosure
	{
		[Address(RVA = "0x15D73E0", Offset = "0x15D65E0", Length = "0x8")]
		[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
		[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001C6")]
	public bool IsBoxed
	{
		[Address(RVA = "0x15D73F0", Offset = "0x15D65F0", Length = "0x7")]
		[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
		[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60008B4")]
		 get { } //Length: 7
		[Address(RVA = "0x15D7400", Offset = "0x15D6600", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60008B5")]
		 set { } //Length: 25
	}

	[Address(RVA = "0x15D73A0", Offset = "0x15D65A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008B7")]
	internal LocalVariable(int index, bool closure) { }

	[Address(RVA = "0x15D73E0", Offset = "0x15D65E0", Length = "0x8")]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008B6")]
	public bool get_InClosure() { }

	[Address(RVA = "0x15D73F0", Offset = "0x15D65F0", Length = "0x7")]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60008B4")]
	public bool get_IsBoxed() { }

	[Address(RVA = "0x15D7400", Offset = "0x15D6600", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60008B5")]
	public void set_IsBoxed(bool value) { }

	[Address(RVA = "0x15D72C0", Offset = "0x15D64C0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60008B8")]
	public virtual string ToString() { }

}

