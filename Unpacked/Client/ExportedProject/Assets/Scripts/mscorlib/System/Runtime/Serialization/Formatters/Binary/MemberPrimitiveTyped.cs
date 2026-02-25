namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000408")]
internal sealed class MemberPrimitiveTyped
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001017")]
	internal InternalPrimitiveTypeE primitiveTypeEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001018")]
	internal object value; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFF")]
	internal MemberPrimitiveTyped() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E03")]
	public void Dump() { }

	[Address(RVA = "0x139EB00", Offset = "0x139DD00", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E02")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1398BC0", Offset = "0x1397DC0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E00")]
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	[Address(RVA = "0x139EB70", Offset = "0x139DD70", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001E01")]
	public override void Write(__BinaryWriter sout) { }

}

