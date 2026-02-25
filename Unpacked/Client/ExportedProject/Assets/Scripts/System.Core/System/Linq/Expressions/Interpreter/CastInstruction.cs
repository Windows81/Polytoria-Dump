namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000227")]
internal abstract class CastInstruction : Instruction
{
	[Token(Token = "0x2000229")]
	private abstract class CastInstructionNoT : CastInstruction
	{
		[Token(Token = "0x200022A")]
		private sealed class Ref : CastInstructionNoT
		{

			[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
			[CallerCount(Count = 55)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A31")]
			public Ref(Type t) { }

			[Address(RVA = "0x15E29B0", Offset = "0x15E1BB0", Length = "0x22")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000A32")]
			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		[Token(Token = "0x200022B")]
		private sealed class Value : CastInstructionNoT
		{

			[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
			[CallerCount(Count = 55)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A33")]
			public Value(Type t) { }

			[Address(RVA = "0x15EC600", Offset = "0x15EB800", Length = "0x3E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000A34")]
			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003B4")]
		private readonly Type _t; //Field offset: 0x10

		[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2D")]
		protected CastInstructionNoT(Type t) { }

		[Token(Token = "0x6000A30")]
		protected abstract void ConvertNull(InterpretedFrame frame) { }

		[Address(RVA = "0x15CE2C0", Offset = "0x15CD4C0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A2E")]
		public static CastInstruction Create(Type t) { }

		[Address(RVA = "0x15CE380", Offset = "0x15CD580", Length = "0x19E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TypeUtils), Member = "HasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "HasIdentityPrimitiveOrNullableConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000A2F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000228")]
	private sealed class CastInstructionT : CastInstruction
	{

		[Address(RVA = "0x80BFB0", Offset = "0x80B1B0", Length = "0x7")]
		[CallerCount(Count = 19)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2C")]
		public CastInstructionT`1() { }

		[Address(RVA = "0x968D00", Offset = "0x967F00", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A2B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003A5")]
	private static CastInstruction s_Boolean; //Field offset: 0x0
	[Token(Token = "0x40003A6")]
	private static CastInstruction s_Byte; //Field offset: 0x8
	[Token(Token = "0x40003A7")]
	private static CastInstruction s_Char; //Field offset: 0x10
	[Token(Token = "0x40003A8")]
	private static CastInstruction s_DateTime; //Field offset: 0x18
	[Token(Token = "0x40003A9")]
	private static CastInstruction s_Decimal; //Field offset: 0x20
	[Token(Token = "0x40003AA")]
	private static CastInstruction s_Double; //Field offset: 0x28
	[Token(Token = "0x40003AB")]
	private static CastInstruction s_Int16; //Field offset: 0x30
	[Token(Token = "0x40003AC")]
	private static CastInstruction s_Int32; //Field offset: 0x38
	[Token(Token = "0x40003AD")]
	private static CastInstruction s_Int64; //Field offset: 0x40
	[Token(Token = "0x40003AE")]
	private static CastInstruction s_SByte; //Field offset: 0x48
	[Token(Token = "0x40003AF")]
	private static CastInstruction s_Single; //Field offset: 0x50
	[Token(Token = "0x40003B0")]
	private static CastInstruction s_String; //Field offset: 0x58
	[Token(Token = "0x40003B1")]
	private static CastInstruction s_UInt16; //Field offset: 0x60
	[Token(Token = "0x40003B2")]
	private static CastInstruction s_UInt32; //Field offset: 0x68
	[Token(Token = "0x40003B3")]
	private static CastInstruction s_UInt64; //Field offset: 0x70

	[Token(Token = "0x17000213")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A26")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000215")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15CEDD0", Offset = "0x15CDFD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000A28")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000214")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A27")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A2A")]
	protected CastInstruction() { }

	[Address(RVA = "0x15CE520", Offset = "0x15CD720", Length = "0x864")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitCast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A29")]
	public static Instruction Create(Type t) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A26")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15CEDD0", Offset = "0x15CDFD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000A28")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A27")]
	public virtual int get_ProducedStack() { }

}

