namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000156")]
internal abstract class LeftShiftInstruction : Instruction
{
	[Token(Token = "0x200015B")]
	private sealed class LeftShiftByte : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073A")]
		public LeftShiftByte() { }

		[Address(RVA = "0x15B8570", Offset = "0x15B7770", Length = "0x1B8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000739")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000158")]
	private sealed class LeftShiftInt16 : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000734")]
		public LeftShiftInt16() { }

		[Address(RVA = "0x15B8BE0", Offset = "0x15B7DE0", Length = "0x130")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000733")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000159")]
	private sealed class LeftShiftInt32 : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000736")]
		public LeftShiftInt32() { }

		[Address(RVA = "0x15B8D20", Offset = "0x15B7F20", Length = "0x12A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000735")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200015A")]
	private sealed class LeftShiftInt64 : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000738")]
		public LeftShiftInt64() { }

		[Address(RVA = "0x15B8E50", Offset = "0x15B8050", Length = "0x1B5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000737")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000157")]
	private sealed class LeftShiftSByte : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000732")]
		public LeftShiftSByte() { }

		[Address(RVA = "0x15B9010", Offset = "0x15B8210", Length = "0x1B8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000731")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200015C")]
	private sealed class LeftShiftUInt16 : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073C")]
		public LeftShiftUInt16() { }

		[Address(RVA = "0x15B91D0", Offset = "0x15B83D0", Length = "0x130")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600073B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200015D")]
	private sealed class LeftShiftUInt32 : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073E")]
		public LeftShiftUInt32() { }

		[Address(RVA = "0x15B9310", Offset = "0x15B8510", Length = "0x1B2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600073D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200015E")]
	private sealed class LeftShiftUInt64 : LeftShiftInstruction
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000740")]
		public LeftShiftUInt64() { }

		[Address(RVA = "0x15B94D0", Offset = "0x15B86D0", Length = "0x1B5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600073F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40002A5")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x40002A6")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x40002A7")]
	private static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x40002A8")]
	private static Instruction s_Int64; //Field offset: 0x18
	[Token(Token = "0x40002A9")]
	private static Instruction s_Byte; //Field offset: 0x20
	[Token(Token = "0x40002AA")]
	private static Instruction s_UInt16; //Field offset: 0x28
	[Token(Token = "0x40002AB")]
	private static Instruction s_UInt32; //Field offset: 0x30
	[Token(Token = "0x40002AC")]
	private static Instruction s_UInt64; //Field offset: 0x38

	[Token(Token = "0x17000194")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600072C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000196")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15B8BB0", Offset = "0x15B7DB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600072E")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000195")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600072D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600072F")]
	private LeftShiftInstruction() { }

	[Address(RVA = "0x15B8730", Offset = "0x15B7930", Length = "0x460")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000730")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600072C")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15B8BB0", Offset = "0x15B7DB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600072E")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600072D")]
	public virtual int get_ProducedStack() { }

}

