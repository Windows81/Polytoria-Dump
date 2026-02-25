namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000127")]
internal sealed class StoreStaticFieldInstruction : FieldInstruction
{

	[Token(Token = "0x17000174")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600061A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000173")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A8960", Offset = "0x15A7B60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000619")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000618")]
	public StoreStaticFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061A")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A8960", Offset = "0x15A7B60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000619")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15A8910", Offset = "0x15A7B10", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600061B")]
	public virtual int Run(InterpretedFrame frame) { }

}

