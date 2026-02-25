namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200022C")]
internal sealed class CastToEnumInstruction : CastInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003B5")]
	private readonly Type _t; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A35")]
	public CastToEnumInstruction(Type t) { }

	[Address(RVA = "0x15CF2B0", Offset = "0x15CE4B0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A36")]
	public virtual int Run(InterpretedFrame frame) { }

}

