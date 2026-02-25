namespace TMPro;

[Token(Token = "0x20000AD")]
public class TMP_TextParsingUtilities
{
	[Token(Token = "0x4000656")]
	private static readonly TMP_TextParsingUtilities s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000657")]
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; //Field offset: 0x0
	[Token(Token = "0x4000658")]
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; //Field offset: 0x0
	[Token(Token = "0x4000659")]
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x8
	[Token(Token = "0x400065A")]
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x10

	[Token(Token = "0x17000192")]
	public static TMP_TextParsingUtilities instance
	{
		[Address(RVA = "0x18F1EB0", Offset = "0x18F10B0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000695")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x18D0F10", Offset = "0x18D0110", Length = "0xCFB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B1550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 347)]
	[Token(Token = "0x6000694")]
	private static TMP_TextParsingUtilities() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A5")]
	public TMP_TextParsingUtilities() { }

	[Address(RVA = "0x18F1810", Offset = "0x18F0A10", Length = "0xC")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600069E")]
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	[Address(RVA = "0x18F1EB0", Offset = "0x18F10B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000695")]
	public static TMP_TextParsingUtilities get_instance() { }

	[Address(RVA = "0x18F1880", Offset = "0x18F0A80", Length = "0xD4")]
	[CalledBy(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Style), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000696")]
	public static int GetHashCode(string s) { }

	[Address(RVA = "0x18F1820", Offset = "0x18F0A20", Length = "0x57")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000697")]
	public static int GetHashCodeCaseSensitive(string s) { }

	[Address(RVA = "0x18F1960", Offset = "0x18F0B60", Length = "0x108")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006A0")]
	internal static bool IsBaseGlyph(uint c) { }

	[Address(RVA = "0x18F1A70", Offset = "0x18F0C70", Length = "0xCB")]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006A4")]
	internal static bool IsCJK(uint c) { }

	[Address(RVA = "0x18F1B40", Offset = "0x18F0D40", Length = "0x44")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600069F")]
	internal static bool IsDiacriticalMark(uint c) { }

	[Address(RVA = "0x18F1C10", Offset = "0x18F0E10", Length = "0x77")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A1")]
	internal static bool IsEmoji(uint c) { }

	[Address(RVA = "0x18F1B90", Offset = "0x18F0D90", Length = "0x77")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A2")]
	internal static bool IsEmojiPresentationForm(uint c) { }

	[Address(RVA = "0x18F1C90", Offset = "0x18F0E90", Length = "0x51")]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006A3")]
	internal static bool IsHangul(uint c) { }

	[Address(RVA = "0x18F1CF0", Offset = "0x18F0EF0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600069C")]
	public static bool IsHighSurrogate(uint c) { }

	[Address(RVA = "0x18F1D10", Offset = "0x18F0F10", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600069D")]
	public static bool IsLowSurrogate(uint c) { }

	[Address(RVA = "0x18F1D30", Offset = "0x18F0F30", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000698")]
	public static char ToLowerASCIIFast(char c) { }

	[Address(RVA = "0x18F1D90", Offset = "0x18F0F90", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600069B")]
	public static uint ToLowerASCIIFast(uint c) { }

	[Address(RVA = "0x18F1E50", Offset = "0x18F1050", Length = "0x57")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000699")]
	public static char ToUpperASCIIFast(char c) { }

	[Address(RVA = "0x18F1DF0", Offset = "0x18F0FF0", Length = "0x5D")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_Text+TextBackingContainer", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600069A")]
	public static uint ToUpperASCIIFast(uint c) { }

}

