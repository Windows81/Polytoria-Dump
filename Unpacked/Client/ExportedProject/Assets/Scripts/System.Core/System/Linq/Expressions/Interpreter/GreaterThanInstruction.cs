namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000128")]
internal abstract class GreaterThanInstruction : Instruction
{
	[Token(Token = "0x200012E")]
	private sealed class GreaterThanByte : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600062B")]
		public GreaterThanByte(object nullValue) { }

		[Address(RVA = "0x15AD890", Offset = "0x15ACA90", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600062C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012B")]
	private sealed class GreaterThanChar : GreaterThanInstruction
	{

		[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000625")]
		public GreaterThanChar(object nullValue) { }

		[Address(RVA = "0x15A2CD0", Offset = "0x15A1ED0", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000626")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000133")]
	private sealed class GreaterThanDouble : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000635")]
		public GreaterThanDouble(object nullValue) { }

		[Address(RVA = "0x15ADA10", Offset = "0x15ACC10", Length = "0x171")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000636")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012A")]
	private sealed class GreaterThanInt16 : GreaterThanInstruction
	{

		[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000623")]
		public GreaterThanInt16(object nullValue) { }

		[Address(RVA = "0x15A3B50", Offset = "0x15A2D50", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000624")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012C")]
	private sealed class GreaterThanInt32 : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000627")]
		public GreaterThanInt32(object nullValue) { }

		[Address(RVA = "0x15ADB90", Offset = "0x15ACD90", Length = "0x163")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000628")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012D")]
	private sealed class GreaterThanInt64 : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000629")]
		public GreaterThanInt64(object nullValue) { }

		[Address(RVA = "0x15ADD00", Offset = "0x15ACF00", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600062A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000129")]
	private sealed class GreaterThanSByte : GreaterThanInstruction
	{

		[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000621")]
		public GreaterThanSByte(object nullValue) { }

		[Address(RVA = "0x15A3C20", Offset = "0x15A2E20", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000622")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000132")]
	private sealed class GreaterThanSingle : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000633")]
		public GreaterThanSingle(object nullValue) { }

		[Address(RVA = "0x15AFCF0", Offset = "0x15AEEF0", Length = "0x170")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000634")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012F")]
	private sealed class GreaterThanUInt16 : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600062D")]
		public GreaterThanUInt16(object nullValue) { }

		[Address(RVA = "0x15AFE70", Offset = "0x15AF070", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600062E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000130")]
	private sealed class GreaterThanUInt32 : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600062F")]
		public GreaterThanUInt32(object nullValue) { }

		[Address(RVA = "0x15AFFE0", Offset = "0x15AF1E0", Length = "0x163")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000630")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000131")]
	private sealed class GreaterThanUInt64 : GreaterThanInstruction
	{

		[Address(RVA = "0x15ADA00", Offset = "0x15ACC00", Length = "0x8")]
		[CallerCount(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000631")]
		public GreaterThanUInt64(object nullValue) { }

		[Address(RVA = "0x15B0150", Offset = "0x15AF350", Length = "0x165")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000632")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400021F")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x4000220")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x4000221")]
	private static Instruction s_Char; //Field offset: 0x10
	[Token(Token = "0x4000222")]
	private static Instruction s_Int32; //Field offset: 0x18
	[Token(Token = "0x4000223")]
	private static Instruction s_Int64; //Field offset: 0x20
	[Token(Token = "0x4000224")]
	private static Instruction s_Byte; //Field offset: 0x28
	[Token(Token = "0x4000225")]
	private static Instruction s_UInt16; //Field offset: 0x30
	[Token(Token = "0x4000226")]
	private static Instruction s_UInt32; //Field offset: 0x38
	[Token(Token = "0x4000227")]
	private static Instruction s_UInt64; //Field offset: 0x40
	[Token(Token = "0x4000228")]
	private static Instruction s_Single; //Field offset: 0x48
	[Token(Token = "0x4000229")]
	private static Instruction s_Double; //Field offset: 0x50
	[Token(Token = "0x400022A")]
	private static Instruction s_liftedToNullSByte; //Field offset: 0x58
	[Token(Token = "0x400022B")]
	private static Instruction s_liftedToNullInt16; //Field offset: 0x60
	[Token(Token = "0x400022C")]
	private static Instruction s_liftedToNullChar; //Field offset: 0x68
	[Token(Token = "0x400022D")]
	private static Instruction s_liftedToNullInt32; //Field offset: 0x70
	[Token(Token = "0x400022E")]
	private static Instruction s_liftedToNullInt64; //Field offset: 0x78
	[Token(Token = "0x400022F")]
	private static Instruction s_liftedToNullByte; //Field offset: 0x80
	[Token(Token = "0x4000230")]
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x88
	[Token(Token = "0x4000231")]
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x90
	[Token(Token = "0x4000232")]
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x98
	[Token(Token = "0x4000233")]
	private static Instruction s_liftedToNullSingle; //Field offset: 0xA0
	[Token(Token = "0x4000234")]
	private static Instruction s_liftedToNullDouble; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021E")]
	private readonly object _nullValue; //Field offset: 0x10

	[Token(Token = "0x17000175")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600061C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000177")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15A3B20", Offset = "0x15A2D20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600061E")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000176")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600061D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061F")]
	private GreaterThanInstruction(object nullValue) { }

	[Address(RVA = "0x15A2DA0", Offset = "0x15A1FA0", Length = "0xD20")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitGreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(void))]
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
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000620")]
	public static Instruction Create(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061C")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15A3B20", Offset = "0x15A2D20", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600061E")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061D")]
	public virtual int get_ProducedStack() { }

}

