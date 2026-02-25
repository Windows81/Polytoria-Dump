namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D0")]
internal sealed class SetArrayItemInstruction : Instruction
{
	[Token(Token = "0x40001BA")]
	internal static readonly SetArrayItemInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700011D")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004ED")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700011E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A87D0", Offset = "0x15A79D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004EE")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x15A8760", Offset = "0x15A7960", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F0")]
	private static SetArrayItemInstruction() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EC")]
	private SetArrayItemInstruction() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004ED")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A87D0", Offset = "0x15A79D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004EE")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x15A86B0", Offset = "0x15A78B0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(ConvertHelper), Member = "ToInt32NoNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60004EF")]
	public virtual int Run(InterpretedFrame frame) { }

}

