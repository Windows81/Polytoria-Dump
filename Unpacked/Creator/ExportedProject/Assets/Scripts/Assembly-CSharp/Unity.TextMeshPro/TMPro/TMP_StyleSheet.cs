namespace TMPro;

[ExcludeFromPreset]
[Token(Token = "0x2000091")]
public class TMP_StyleSheet : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004AB")]
	private List<TMP_Style> m_StyleList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AC")]
	private Dictionary<Int32, TMP_Style> m_StyleLookupDictionary; //Field offset: 0x20

	[Token(Token = "0x17000111")]
	internal List<TMP_Style> styles
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D3")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x18ED6C0", Offset = "0x18EC8C0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60004D9")]
	public TMP_StyleSheet() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D3")]
	internal List<TMP_Style> get_styles() { }

	[Address(RVA = "0x18ED2E0", Offset = "0x18EC4E0", Length = "0x86")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D5")]
	public TMP_Style GetStyle(int hashCode) { }

	[Address(RVA = "0x18ED220", Offset = "0x18EC420", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D6")]
	public TMP_Style GetStyle(string name) { }

	[Address(RVA = "0x18ED370", Offset = "0x18EC570", Length = "0x335")]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "RefreshStyles", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Style), Member = "RefreshStyle", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60004D8")]
	private void LoadStyleDictionaryInternal() { }

	[Address(RVA = "0x18ED6B0", Offset = "0x18EC8B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D7")]
	public void RefreshStyles() { }

	[Address(RVA = "0x18ED6B0", Offset = "0x18EC8B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D4")]
	private void Reset() { }

}

