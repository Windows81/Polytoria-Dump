namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000403")]
internal sealed class BinaryMethodCall
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001003")]
	private string methodName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001004")]
	private string typeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001005")]
	private Object[] args; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001006")]
	private object callContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001007")]
	private Type[] argTypes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001008")]
	private bool bArgsPrimitive; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001009")]
	private MessageEnum messageEnum; //Field offset: 0x3C

	[Address(RVA = "0x139ABE0", Offset = "0x1399DE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DEF")]
	public BinaryMethodCall() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DEE")]
	internal void Dump() { }

	[Address(RVA = "0x139A840", Offset = "0x1399A40", Length = "0x39C")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMethodCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOUtil), Member = "WriteStringWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 14)]
	[Token(Token = "0x6001DED")]
	internal void Write(__BinaryWriter sout) { }

}

