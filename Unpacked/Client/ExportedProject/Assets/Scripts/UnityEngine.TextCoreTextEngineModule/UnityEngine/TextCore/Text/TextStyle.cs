namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200003C")]
public class TextStyle
{
	[Token(Token = "0x4000181")]
	internal static TextStyle k_NormalStyle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000182")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000183")]
	private int m_HashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000184")]
	private string m_OpeningDefinition; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000185")]
	private string m_ClosingDefinition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000186")]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000187")]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000188")]
	internal UInt32[] m_OpeningTagUnicodeArray; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000189")]
	internal UInt32[] m_ClosingTagUnicodeArray; //Field offset: 0x48

	[Token(Token = "0x1700004E")]
	public int hashCode
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000198")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000050")]
	public UInt32[] styleClosingTagArray
	{
		[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700004F")]
	public UInt32[] styleOpeningTagArray
	{
		[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000199")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1A6CCB0", Offset = "0x1A6BEB0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextStyle), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600019B")]
	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000198")]
	public int get_hashCode() { }

	[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019A")]
	public UInt32[] get_styleClosingTagArray() { }

	[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000199")]
	public UInt32[] get_styleOpeningTagArray() { }

	[Address(RVA = "0x1A6CA90", Offset = "0x1A6BC90", Length = "0x21E")]
	[CalledBy(Type = typeof(TextStyle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600019C")]
	public void RefreshStyle() { }

}

