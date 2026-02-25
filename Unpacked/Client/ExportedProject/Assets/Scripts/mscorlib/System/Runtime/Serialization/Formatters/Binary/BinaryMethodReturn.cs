namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000404")]
internal sealed class BinaryMethodReturn
{
	[Token(Token = "0x4001011")]
	private static object instanceOfVoid; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400100A")]
	private object returnValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400100B")]
	private Object[] args; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100C")]
	private object callContext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400100D")]
	private Type[] argTypes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400100E")]
	private bool bArgsPrimitive; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400100F")]
	private MessageEnum messageEnum; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001010")]
	private Type returnType; //Field offset: 0x38

	[Address(RVA = "0x139AED0", Offset = "0x139A0D0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DF0")]
	private static BinaryMethodReturn() { }

	[Address(RVA = "0x139AF90", Offset = "0x139A190", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DF1")]
	internal BinaryMethodReturn() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF3")]
	public void Dump() { }

	[Address(RVA = "0x139ABF0", Offset = "0x1399DF0", Length = "0x2DC")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMethodReturn", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOUtil), Member = "WriteStringWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6001DF2")]
	public override void Write(__BinaryWriter sout) { }

}

