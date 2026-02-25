namespace System.Xml;

[Token(Token = "0x20000B0")]
internal class Ucs4Decoder1234 : Ucs4Decoder
{

	[Address(RVA = "0x16B4220", Offset = "0x16B3420", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007EB")]
	public Ucs4Decoder1234() { }

	[Address(RVA = "0x16B3F00", Offset = "0x16B3100", Length = "0x310")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlCharType), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007EA")]
	internal virtual int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

}

