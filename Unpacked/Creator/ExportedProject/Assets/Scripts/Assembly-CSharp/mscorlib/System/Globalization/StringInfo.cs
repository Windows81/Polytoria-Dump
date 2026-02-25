namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200055C")]
public class StringInfo
{
	[FieldOffset(Offset = "0x10")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016A8")]
	private string m_str; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016A9")]
	private Int32[] m_indexes; //Field offset: 0x18

	[Token(Token = "0x170005C0")]
	private Int32[] Indexes
	{
		[Address(RVA = "0x13FAA00", Offset = "0x13F9C00", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002707")]
		private get { } //Length: 72
	}

	[Token(Token = "0x170005C2")]
	public int LengthInTextElements
	{
		[Address(RVA = "0x13FAA50", Offset = "0x13F9C50", Length = "0x5A")]
		[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600270A")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170005C1")]
	public string String
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002708")]
		 get { } //Length: 5
		[Address(RVA = "0x13FAAB0", Offset = "0x13F9CB0", Length = "0xA1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002709")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x13FA920", Offset = "0x13F9B20", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002701")]
	public StringInfo() { }

	[Address(RVA = "0x13FA870", Offset = "0x13F9A70", Length = "0xAD")]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002702")]
	public StringInfo(string value) { }

	[Address(RVA = "0x13FA430", Offset = "0x13F9630", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ComVisible(False)]
	[Token(Token = "0x6002705")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x13FAA00", Offset = "0x13F9C00", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002707")]
	private Int32[] get_Indexes() { }

	[Address(RVA = "0x13FAA50", Offset = "0x13F9C50", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270A")]
	public int get_LengthInTextElements() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002708")]
	public string get_String() { }

	[Address(RVA = "0x13FA4C0", Offset = "0x13F96C0", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "IsCombiningCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeCategory)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600270B")]
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002706")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13FA5D0", Offset = "0x13F97D0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[OnDeserialized]
	[Token(Token = "0x6002704")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x13FA610", Offset = "0x13F9810", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[OnDeserializing]
	[Token(Token = "0x6002703")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x13FA630", Offset = "0x13F9830", Length = "0x238")]
	[CalledBy(Type = typeof(StringInfo), Member = "get_Indexes", ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(StringInfo), Member = "get_LengthInTextElements", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "IsCombiningCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeCategory)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270C")]
	public static Int32[] ParseCombiningCharacters(string str) { }

	[Address(RVA = "0x13FAAB0", Offset = "0x13F9CB0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002709")]
	public void set_String(string value) { }

}

