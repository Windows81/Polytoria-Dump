namespace TMPro;

[Extension]
[Token(Token = "0x200001E")]
public static class TMPro_ExtensionMethods
{

	[Address(RVA = "0x189EC70", Offset = "0x189DE70", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000128")]
	public static string ArrayToString(Char[] chars) { }

	[Address(RVA = "0x1825420", Offset = "0x1824620", Length = "0x38")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600012F")]
	public static bool Compare(Color a, Color b) { }

	[Address(RVA = "0x189EE60", Offset = "0x189E060", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000137")]
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Address(RVA = "0x189ED50", Offset = "0x189DF50", Length = "0x35")]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_faceColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_outlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600012D")]
	public static bool Compare(Color32 a, Color32 b) { }

	[Address(RVA = "0x189ED90", Offset = "0x189DF90", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000138")]
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

	[Address(RVA = "0x189ED20", Offset = "0x189DF20", Length = "0x24")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600012E")]
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Address(RVA = "0x18243C0", Offset = "0x18235C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000130")]
	public static bool CompareRGB(Color a, Color b) { }

	[Address(RVA = "0x768B00", Offset = "0x767D00", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600012C")]
	public static int FindInstanceID(List<T> list, T target) { }

	[Address(RVA = "0x189EFA0", Offset = "0x189E1A0", Length = "0x44")]
	[CalledBy(Type = typeof(TMP_Text), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "FillSpriteVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	[Extension]
	[Token(Token = "0x6000134")]
	internal static Color32 GammaToLinear(Color32 c) { }

	[Address(RVA = "0x189EEF0", Offset = "0x189E0F0", Length = "0xA8")]
	[CalledBy(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000135")]
	private static byte GammaToLinear(byte value) { }

	[Address(RVA = "0x189F080", Offset = "0x189E280", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x600012B")]
	public static string IntToString(Int32[] unicodes, int start, int length) { }

	[Address(RVA = "0x189EFF0", Offset = "0x189E1F0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x6000129")]
	public static string IntToString(Int32[] unicodes) { }

	[Address(RVA = "0x189F180", Offset = "0x189E380", Length = "0x2E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Extension]
	[Token(Token = "0x6000136")]
	public static Color MinAlpha(Color c1, Color c2) { }

	[Address(RVA = "0x189F1B0", Offset = "0x189E3B0", Length = "0xDE")]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000131")]
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Address(RVA = "0x189F290", Offset = "0x189E490", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000126")]
	internal static int TagToInt(string s) { }

	[Address(RVA = "0x189F1B0", Offset = "0x189E3B0", Length = "0xDE")]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000132")]
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Address(RVA = "0x189F340", Offset = "0x189E540", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000133")]
	public static Color32 Tint(Color32 c1, float tint) { }

	[Address(RVA = "0x189F420", Offset = "0x189E620", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x6000127")]
	public static Int32[] ToIntArray(string text) { }

	[Address(RVA = "0x189F4C0", Offset = "0x189E6C0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x600012A")]
	internal static string UintToString(List<UInt32> unicodes) { }

}

