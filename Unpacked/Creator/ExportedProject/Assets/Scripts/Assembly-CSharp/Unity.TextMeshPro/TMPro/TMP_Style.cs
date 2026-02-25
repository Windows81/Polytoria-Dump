namespace TMPro;

[Token(Token = "0x2000090")]
public class TMP_Style
{
	[Token(Token = "0x40004A4")]
	internal static TMP_Style k_NormalStyle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40004A5")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004A6")]
	private int m_HashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004A7")]
	private string m_OpeningDefinition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004A8")]
	private string m_ClosingDefinition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004A9")]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004AA")]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x38

	[Token(Token = "0x1700010C")]
	public int hashCode
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 4
		[Address(RVA = "0x18EDA90", Offset = "0x18ECC90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60004CC")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700010B")]
	public string name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C9")]
		 get { } //Length: 5
		[Address(RVA = "0x18EDAA0", Offset = "0x18ECCA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60004CA")]
		 set { } //Length: 62
	}

	[Token(Token = "0x1700010A")]
	public static TMP_Style NormalStyle
	{
		[Address(RVA = "0x18ED9B0", Offset = "0x18ECBB0", Length = "0xD6")]
		[CalledBy(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60004C8")]
		 get { } //Length: 214
	}

	[Token(Token = "0x1700010E")]
	public string styleClosingDefinition
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000110")]
	public UInt32[] styleClosingTagArray
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700010D")]
	public string styleOpeningDefinition
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700010F")]
	public UInt32[] styleOpeningTagArray
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CF")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x18ED8F0", Offset = "0x18ECAF0", Length = "0xB6")]
	[CalledBy(Type = typeof(TMP_Style), Member = "get_NormalStyle", ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Style), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004D1")]
	internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CB")]
	public int get_hashCode() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C9")]
	public string get_name() { }

	[Address(RVA = "0x18ED9B0", Offset = "0x18ECBB0", Length = "0xD6")]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004C8")]
	public static TMP_Style get_NormalStyle() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CE")]
	public string get_styleClosingDefinition() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D0")]
	public UInt32[] get_styleClosingTagArray() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CD")]
	public string get_styleOpeningDefinition() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CF")]
	public UInt32[] get_styleOpeningTagArray() { }

	[Address(RVA = "0x18ED740", Offset = "0x18EC940", Length = "0x1A6")]
	[CalledBy(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004D2")]
	public void RefreshStyle() { }

	[Address(RVA = "0x18EDA90", Offset = "0x18ECC90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004CC")]
	public void set_hashCode(int value) { }

	[Address(RVA = "0x18EDAA0", Offset = "0x18ECCA0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004CA")]
	public void set_name(string value) { }

}

