namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200022D")]
internal sealed class CastReferenceToEnumInstruction : CastInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003B6")]
	private readonly Type _t; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A37")]
	public CastReferenceToEnumInstruction(Type t) { }

	[Address(RVA = "0x15CEE00", Offset = "0x15CE000", Length = "0x480")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(byte)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ulong)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(long)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(short)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(sbyte)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ushort)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A38")]
	public virtual int Run(InterpretedFrame frame) { }

}

