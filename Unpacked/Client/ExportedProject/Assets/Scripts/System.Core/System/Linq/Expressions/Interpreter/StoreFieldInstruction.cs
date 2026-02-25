namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000126")]
internal sealed class StoreFieldInstruction : FieldInstruction
{

	[Token(Token = "0x17000172")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000616")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000171")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A88E0", Offset = "0x15A7AE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000615")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000614")]
	public StoreFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000616")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A88E0", Offset = "0x15A7AE0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000615")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15A8870", Offset = "0x15A7A70", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000617")]
	public virtual int Run(InterpretedFrame frame) { }

}

