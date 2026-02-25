namespace MoonSharp.Interpreter;

[Token(Token = "0x200005D")]
public class InterpreterException : Exception
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000215")]
	private int <InstructionPtr>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000216")]
	private IList<WatchItem> <CallStack>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000217")]
	private string <DecoratedMessage>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000218")]
	private bool <DoNotDecorateMessage>k__BackingField; //Field offset: 0xA8

	[Token(Token = "0x170000C4")]
	public internal IList<WatchItem> CallStack
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BF")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C0")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170000C5")]
	public internal string DecoratedMessage
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C1")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C2")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170000C6")]
	public bool DoNotDecorateMessage
	{
		[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C3")]
		 get { } //Length: 8
		[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C4")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000C3")]
	public internal int InstructionPtr
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BD")]
		 get { } //Length: 7
		[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BE")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x2FDCF0", Offset = "0x2FCEF0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005B9")]
	protected InterpreterException(Exception ex, string message) { }

	[Address(RVA = "0x2FDC70", Offset = "0x2FCE70", Length = "0x7C")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BA")]
	protected InterpreterException(Exception ex) { }

	[Address(RVA = "0x2FDAC0", Offset = "0x2FCCC0", Length = "0x59")]
	[CallerCount(Count = 82)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BB")]
	protected InterpreterException(string message) { }

	[Address(RVA = "0x2FDD60", Offset = "0x2FCF60", Length = "0xA2")]
	[CallerCount(Count = 46)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005BC")]
	protected InterpreterException(string format, Object[] args) { }

	[Address(RVA = "0x2FDB30", Offset = "0x2FCD30", Length = "0x139")]
	[CalledBy(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceRef), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(SourceRef), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyntaxErrorException), Member = "DecorateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "FillDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpreterException), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicModule), Member = "error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SourceRef), Member = "FormatLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005C5")]
	internal void DecorateMessage(Script script, SourceRef sref, int ip = -1) { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BF")]
	public IList<WatchItem> get_CallStack() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C1")]
	public string get_DecoratedMessage() { }

	[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C3")]
	public bool get_DoNotDecorateMessage() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BD")]
	public int get_InstructionPtr() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C6")]
	public override void Rethrow() { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C0")]
	internal void set_CallStack(IList<WatchItem> value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C2")]
	internal void set_DecoratedMessage(string value) { }

	[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C4")]
	public void set_DoNotDecorateMessage(bool value) { }

	[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BE")]
	internal void set_InstructionPtr(int value) { }

}

