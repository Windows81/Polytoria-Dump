namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021F")]
internal abstract class NullableMethodCallInstruction : Instruction
{
	[Token(Token = "0x2000224")]
	private sealed class EqualsClass : NullableMethodCallInstruction
	{

		[Token(Token = "0x17000212")]
		public virtual int ConsumedStack
		{
			[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A1F")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A21")]
		public EqualsClass() { }

		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A1F")]
		public virtual int get_ConsumedStack() { }

		[Address(RVA = "0x15D1C90", Offset = "0x15D0E90", Length = "0xDD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A20")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000226")]
	private sealed class GetHashCodeClass : NullableMethodCallInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A25")]
		public GetHashCodeClass() { }

		[Address(RVA = "0x15D3E90", Offset = "0x15D3090", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A24")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000221")]
	private sealed class GetValue : NullableMethodCallInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A19")]
		public GetValue() { }

		[Address(RVA = "0x15D4010", Offset = "0x15D3210", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Peek", ReturnType = typeof(object))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A18")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000222")]
	private sealed class GetValueOrDefault : NullableMethodCallInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003A4")]
		private readonly Type _defaultValueType; //Field offset: 0x10

		[Address(RVA = "0x15D3FB0", Offset = "0x15D31B0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A1A")]
		public GetValueOrDefault(MethodInfo mi) { }

		[Address(RVA = "0x15D3F50", Offset = "0x15D3150", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Peek", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A1B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000223")]
	private sealed class GetValueOrDefault1 : NullableMethodCallInstruction
	{

		[Token(Token = "0x17000211")]
		public virtual int ConsumedStack
		{
			[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000A1C")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A1E")]
		public GetValueOrDefault1() { }

		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A1C")]
		public virtual int get_ConsumedStack() { }

		[Address(RVA = "0x15D3EF0", Offset = "0x15D30F0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A1D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000220")]
	private sealed class HasValue : NullableMethodCallInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A17")]
		public HasValue() { }

		[Address(RVA = "0x15D4080", Offset = "0x15D3280", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A16")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000225")]
	private sealed class ToStringClass : NullableMethodCallInstruction
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A23")]
		public ToStringClass() { }

		[Address(RVA = "0x15E6410", Offset = "0x15E5610", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A22")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400039E")]
	private static NullableMethodCallInstruction s_hasValue; //Field offset: 0x0
	[Token(Token = "0x400039F")]
	private static NullableMethodCallInstruction s_value; //Field offset: 0x8
	[Token(Token = "0x40003A0")]
	private static NullableMethodCallInstruction s_equals; //Field offset: 0x10
	[Token(Token = "0x40003A1")]
	private static NullableMethodCallInstruction s_getHashCode; //Field offset: 0x18
	[Token(Token = "0x40003A2")]
	private static NullableMethodCallInstruction s_getValueOrDefault1; //Field offset: 0x20
	[Token(Token = "0x40003A3")]
	private static NullableMethodCallInstruction s_toString; //Field offset: 0x28

	[Token(Token = "0x1700020E")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A10")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000210")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x15DF350", Offset = "0x15DE550", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000A12")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700020F")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A11")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A13")]
	private NullableMethodCallInstruction() { }

	[Address(RVA = "0x15DEF40", Offset = "0x15DE140", Length = "0x405")]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitNullableCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodCallExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(IArgumentProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A14")]
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	[Address(RVA = "0x15DEEA0", Offset = "0x15DE0A0", Length = "0x9A")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A15")]
	public static Instruction CreateGetValue() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A10")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x15DF350", Offset = "0x15DE550", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000A12")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A11")]
	public virtual int get_ProducedStack() { }

}

