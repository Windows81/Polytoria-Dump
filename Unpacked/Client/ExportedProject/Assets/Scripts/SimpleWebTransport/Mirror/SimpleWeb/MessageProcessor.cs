namespace Mirror.SimpleWeb;

[Token(Token = "0x2000018")]
public static class MessageProcessor
{

	[Address(RVA = "0x1556D40", Offset = "0x1555F40", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006C")]
	public static bool Finished(Byte[] buffer) { }

	[Address(RVA = "0x1556D70", Offset = "0x1555F70", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000067")]
	private static byte FirstLengthByte(Byte[] buffer) { }

	[Address(RVA = "0x1556DA0", Offset = "0x1555FA0", Length = "0x1F4")]
	[CalledBy(Type = typeof(MessageProcessor), Member = "GetPayloadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MessageProcessor), Member = "ValidateHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(bool)}, ReturnType = "Mirror.SimpleWeb.ReceiveLoop+Header")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000071")]
	private static int GetMessageLength(Byte[] buffer, int offset, byte lenByte) { }

	[Address(RVA = "0x1556FA0", Offset = "0x15561A0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006A")]
	public static int GetOpcode(Byte[] buffer) { }

	[Address(RVA = "0x1556FD0", Offset = "0x15561D0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageProcessor), Member = "GetMessageLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006B")]
	public static int GetPayloadLength(Byte[] buffer) { }

	[Address(RVA = "0x1557010", Offset = "0x1556210", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000069")]
	public static bool NeedToReadLongLength(Byte[] buffer) { }

	[Address(RVA = "0x1557040", Offset = "0x1556240", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000068")]
	public static bool NeedToReadShortLength(Byte[] buffer) { }

	[Address(RVA = "0x1557070", Offset = "0x1556270", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000073")]
	private static void ThrowIfBadOpCode(int opcode, bool finished, bool opCodeContinuation) { }

	[Address(RVA = "0x1557180", Offset = "0x1556380", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000074")]
	private static void ThrowIfLengthZero(int msglen) { }

	[Address(RVA = "0x15571E0", Offset = "0x15563E0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000072")]
	private static void ThrowIfMaskNotExpected(bool hasMask, bool expectMask) { }

	[Address(RVA = "0x1557290", Offset = "0x1556490", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000075")]
	public static void ThrowIfMsgLengthTooLong(int msglen, int maxLength) { }

	[Address(RVA = "0x15573C0", Offset = "0x15565C0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006E")]
	public static void ToggleMask(Byte[] src, int sourceOffset, int messageLength, Byte[] maskBuffer, int maskOffset) { }

	[Address(RVA = "0x1557470", Offset = "0x1556670", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006F")]
	public static void ToggleMask(Byte[] src, int sourceOffset, ArrayBuffer dst, int messageLength, Byte[] maskBuffer, int maskOffset) { }

	[Address(RVA = "0x15572F0", Offset = "0x15564F0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000070")]
	public static void ToggleMask(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int messageLength, Byte[] maskBuffer, int maskOffset) { }

	[Address(RVA = "0x1557560", Offset = "0x1556760", Length = "0x2AB")]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(bool)}, ReturnType = "Mirror.SimpleWeb.ReceiveLoop+Header")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MessageProcessor), Member = "GetMessageLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006D")]
	public static void ValidateHeader(Byte[] buffer, int maxLength, bool expectMask, bool opCodeContinuation = false) { }

}

