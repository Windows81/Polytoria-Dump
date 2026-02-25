namespace TMPro;

[Token(Token = "0x2000047")]
internal class TMP_DynamicFontAssetUtilities
{
	[Token(Token = "0x2000048")]
	internal struct FontReference
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D1")]
		public string familyName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D2")]
		public string styleName; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D3")]
		public int faceIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D4")]
		public string filePath; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D5")]
		public ulong hashCode; //Field offset: 0x20

		[Address(RVA = "0x1889060", Offset = "0x1888260", Length = "0x2FE")]
		[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "ToUpperFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000219")]
		public FontReference(string fontFilePath, string faceNameAndStyle, int index) { }

	}

	[Token(Token = "0x40001CD")]
	private static TMP_DynamicFontAssetUtilities s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CE")]
	private Dictionary<UInt64, FontReference> s_SystemFontLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CF")]
	private String[] s_SystemFontPaths; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D0")]
	private uint s_RegularStyleNameHashCode; //Field offset: 0x20

	[Address(RVA = "0x1891770", Offset = "0x1890970", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000218")]
	private static TMP_DynamicFontAssetUtilities() { }

	[Address(RVA = "0x18917E0", Offset = "0x18909E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000217")]
	public TMP_DynamicFontAssetUtilities() { }

	[Address(RVA = "0x1890CD0", Offset = "0x188FED0", Length = "0x66D")]
	[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReferenceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "GetFontFaces", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontEngine), Member = "UnloadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(FontReference)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Font), Member = "GetPathsToOSFonts", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000213")]
	private void InitializeSystemFontReferenceCache() { }

	[Address(RVA = "0x18916E0", Offset = "0x18908E0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReferenceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000214")]
	public static bool TryGetSystemFontReference(string familyName, out FontReference fontRef) { }

	[Address(RVA = "0x1891650", Offset = "0x1890850", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReferenceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000215")]
	public static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[Address(RVA = "0x1891340", Offset = "0x1890540", Length = "0x30A")]
	[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_DynamicFontAssetUtilities), Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, TMPro.TMP_DynamicFontAssetUtilities+FontReference>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(FontReference))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000216")]
	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out FontReference fontRef) { }

}

