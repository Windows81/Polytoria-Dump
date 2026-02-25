namespace U8Xml.Internal;

[Token(Token = "0x2000023")]
internal static class DataOffsetHelper
{

	[Address(RVA = "0x1807080", Offset = "0x1806280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BE")]
	private static bool CheckContainsMemory(Byte* dataHead, int dataLen, Byte* targetHead, int targetLen) { }

	[Address(RVA = "0x18071F0", Offset = "0x18063F0", Length = "0x1FA")]
	[CalledBy(Type = typeof(XmlParser), Member = "NewFormatException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(int), typeof(string)}, ReturnType = typeof(FormatException))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	public static Nullable<DataLinePosition> GetLinePosition(Byte* dataHead, int dataLen, Byte* target) { }

	[Address(RVA = "0x18070A0", Offset = "0x18062A0", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BD")]
	private static DataLinePosition GetLinePositionPrivate(Byte* dataHead, int dataLen, Byte* target) { }

}

