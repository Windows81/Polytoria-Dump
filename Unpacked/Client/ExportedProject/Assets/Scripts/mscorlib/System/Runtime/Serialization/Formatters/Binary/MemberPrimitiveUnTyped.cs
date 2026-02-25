namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040C")]
internal sealed class MemberPrimitiveUnTyped
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001031")]
	internal InternalPrimitiveTypeE typeInformation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001032")]
	internal object value; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E14")]
	internal MemberPrimitiveUnTyped() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E19")]
	public void Dump() { }

	[Address(RVA = "0x139EBF0", Offset = "0x139DDF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E18")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1398BC0", Offset = "0x1397DC0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E15")]
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E16")]
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	[Address(RVA = "0x139EC30", Offset = "0x139DE30", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E17")]
	public override void Write(__BinaryWriter sout) { }

}

