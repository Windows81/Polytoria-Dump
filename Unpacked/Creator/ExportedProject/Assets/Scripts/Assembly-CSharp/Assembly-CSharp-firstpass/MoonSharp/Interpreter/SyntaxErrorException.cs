namespace MoonSharp.Interpreter;

[Token(Token = "0x2000061")]
public class SyntaxErrorException : InterpreterException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000219")]
	private Token <Token>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400021A")]
	private bool <IsPrematureStreamTermination>k__BackingField; //Field offset: 0xB8

	[Token(Token = "0x170000C8")]
	public bool IsPrematureStreamTermination
	{
		[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000610")]
		 get { } //Length: 8
		[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000611")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000C7")]
	internal Token Token
	{
		[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600060E")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600060F")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x3100B0", Offset = "0x30F2B0", Length = "0x44")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(InterpreterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000612")]
	internal SyntaxErrorException(Token t, string format, Object[] args) { }

	[Address(RVA = "0x310160", Offset = "0x30F360", Length = "0x7C")]
	[CalledBy(Type = typeof(LexerUtils), Member = "UnescapeLuaString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FunctionCallExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptLoadingContext), typeof(Expression), typeof(Token)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SymbolRefExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(ScriptLoadingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000613")]
	internal SyntaxErrorException(Token t, string message) { }

	[Address(RVA = "0x310100", Offset = "0x30F300", Length = "0x57")]
	[CalledBy(Type = typeof(BreakStatement), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteCode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterpreterException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpreterException), Member = "DecorateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceRef), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000614")]
	internal SyntaxErrorException(Script script, SourceRef sref, string format, Object[] args) { }

	[Address(RVA = "0x3101E0", Offset = "0x30F3E0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpreterException), Member = "DecorateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceRef), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000615")]
	internal SyntaxErrorException(Script script, SourceRef sref, string message) { }

	[Address(RVA = "0x310270", Offset = "0x30F470", Length = "0xC1")]
	[CalledBy(Type = typeof(SyntaxErrorException), Member = "Rethrow", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000616")]
	private SyntaxErrorException(SyntaxErrorException syntaxErrorException) { }

	[Address(RVA = "0x30FF70", Offset = "0x30F170", Length = "0x53")]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadDynamicExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode)}, ReturnType = typeof(DynamicExprExpression))]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Loader_Fast), Member = "LoadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceCode), typeof(ByteCode), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Token), Member = "GetSourceRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(InterpreterException), Member = "DecorateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceRef), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000617")]
	internal void DecorateMessage(Script script) { }

	[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000610")]
	public bool get_IsPrematureStreamTermination() { }

	[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600060E")]
	internal Token get_Token() { }

	[Address(RVA = "0x30FFD0", Offset = "0x30F1D0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyntaxErrorException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000618")]
	public virtual void Rethrow() { }

	[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000611")]
	public void set_IsPrematureStreamTermination(bool value) { }

	[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600060F")]
	private void set_Token(Token value) { }

}

