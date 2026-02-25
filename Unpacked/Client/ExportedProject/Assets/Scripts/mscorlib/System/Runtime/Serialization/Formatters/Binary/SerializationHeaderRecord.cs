namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x20003FF")]
internal sealed class SerializationHeaderRecord
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF6")]
	internal int binaryFormatterMajorVersion; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000FF7")]
	internal int binaryFormatterMinorVersion; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF8")]
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000FF9")]
	internal int topId; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FFA")]
	internal int headerId; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000FFB")]
	internal int majorVersion; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FFC")]
	internal int minorVersion; //Field offset: 0x28

	[Address(RVA = "0x13AA3C0", Offset = "0x13A95C0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DDA")]
	internal SerializationHeaderRecord() { }

	[Address(RVA = "0x13AA3D0", Offset = "0x13A95D0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DDB")]
	internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DDF")]
	public void Dump() { }

	[Address(RVA = "0x11EFCF0", Offset = "0x11EEEF0", Length = "0x6D")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DDD")]
	private static int GetInt32(Byte[] buffer, int index) { }

	[Address(RVA = "0x13AA090", Offset = "0x13A9290", Length = "0x24F")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001DDE")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x13AA2E0", Offset = "0x13A94E0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001DDC")]
	public override void Write(__BinaryWriter sout) { }

}

