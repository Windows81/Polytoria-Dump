namespace System.Globalization;

[Token(Token = "0x2000566")]
internal class CodePageDataItem
{
	[Token(Token = "0x40016F3")]
	private static readonly Char[] sep; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016EE")]
	internal int m_dataIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40016EF")]
	internal int m_uiFamilyCodePage; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016F0")]
	internal string m_webName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016F1")]
	internal string m_headerName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016F2")]
	internal uint m_flags; //Field offset: 0x28

	[Token(Token = "0x170005E8")]
	public string HeaderName
	{
		[Address(RVA = "0x1426540", Offset = "0x1425740", Length = "0xCC")]
		[CalledBy(Type = typeof(Encoding), Member = "get_HeaderName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CodePageDataItem), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60027B1")]
		 get { } //Length: 204
	}

	[Token(Token = "0x170005E7")]
	public string WebName
	{
		[Address(RVA = "0x1426610", Offset = "0x1425810", Length = "0xC9")]
		[CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CodePageDataItem), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60027B0")]
		 get { } //Length: 201
	}

	[Address(RVA = "0x14263F0", Offset = "0x14255F0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027B2")]
	private static CodePageDataItem() { }

	[Address(RVA = "0x1426480", Offset = "0x1425680", Length = "0xBA")]
	[CalledBy(Type = typeof(EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CodePageDataItem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027AE")]
	internal CodePageDataItem(int dataIndex) { }

	[Address(RVA = "0x1426330", Offset = "0x1425530", Length = "0xB0")]
	[CalledBy(Type = typeof(CodePageDataItem), Member = "get_WebName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CodePageDataItem), Member = "get_HeaderName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027AF")]
	internal static string CreateString(string pStrings, uint index) { }

	[Address(RVA = "0x1426540", Offset = "0x1425740", Length = "0xCC")]
	[CalledBy(Type = typeof(Encoding), Member = "get_HeaderName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePageDataItem), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027B1")]
	public string get_HeaderName() { }

	[Address(RVA = "0x1426610", Offset = "0x1425810", Length = "0xC9")]
	[CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePageDataItem), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027B0")]
	public string get_WebName() { }

}

