namespace System.Security;

[Token(Token = "0x20002C1")]
internal sealed class SecurityDocument
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C11")]
	internal Byte[] m_data; //Field offset: 0x10

	[Address(RVA = "0x1330900", Offset = "0x132FB00", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016F2")]
	public SecurityDocument(int numData) { }

	[Address(RVA = "0x132FED0", Offset = "0x132F0D0", Length = "0x142")]
	[CalledBy(Type = typeof(SecurityDocument), Member = "AppendString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SecurityDocument), Member = "GuaranteeSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016F4")]
	public void AddString(string str, ref int position) { }

	[Address(RVA = "0x1330020", Offset = "0x132F220", Length = "0xE4")]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016F8")]
	public void AddToken(byte b, ref int position) { }

	[Address(RVA = "0x1330110", Offset = "0x132F310", Length = "0x9D")]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016F5")]
	public void AppendString(string str, ref int position) { }

	[Address(RVA = "0x13301B0", Offset = "0x132F3B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60016F6")]
	public static int EncodedStringSize(string str) { }

	[Address(RVA = "0x13301D0", Offset = "0x132F3D0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[Token(Token = "0x60016FA")]
	public SecurityElement GetElement(int position, bool bCreate) { }

	[Address(RVA = "0x13301F0", Offset = "0x132F3F0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[Token(Token = "0x60016F9")]
	public SecurityElement GetRootElement() { }

	[Address(RVA = "0x1330220", Offset = "0x132F420", Length = "0x3A7")]
	[CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringMaker&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60016F7")]
	public string GetString(ref int position, bool bCreate) { }

	[Address(RVA = "0x13305D0", Offset = "0x132F7D0", Length = "0xA2")]
	[CalledBy(Type = typeof(SecurityDocument), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60016F3")]
	public void GuaranteeSize(int size) { }

	[Address(RVA = "0x1330680", Offset = "0x132F880", Length = "0x275")]
	[CalledBy(Type = typeof(SecurityDocument), Member = "GetRootElement", ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(SecurityDocument), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(Parser), Member = "GetTopElement", ReturnType = typeof(SecurityElement))]
	[CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SecurityElement), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecurityElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SecurityElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60016FB")]
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

