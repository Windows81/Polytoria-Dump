namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[Token(Token = "0x200003D")]
public class TextStyleSheet : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400018A")]
	private List<TextStyle> m_StyleList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018B")]
	private Dictionary<Int32, TextStyle> m_StyleLookupDictionary; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400018C")]
	private object styleLookupLock; //Field offset: 0x28

	[Token(Token = "0x17000051")]
	internal List<TextStyle> styles
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019D")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x1A6C9D0", Offset = "0x1A6BBD0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A3")]
	public TextStyleSheet() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019D")]
	internal List<TextStyle> get_styles() { }

	[Address(RVA = "0x1A6C4C0", Offset = "0x1A6B6C0", Length = "0x11A")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600019F")]
	public TextStyle GetStyle(int hashCode) { }

	[Address(RVA = "0x1A6C5E0", Offset = "0x1A6B7E0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001A0")]
	public TextStyle GetStyle(string name) { }

	[Address(RVA = "0x1A6C680", Offset = "0x1A6B880", Length = "0x33E")]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextStyle))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TextStyle))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "RefreshStyles", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextStyle), Member = "RefreshStyle", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60001A2")]
	private void LoadStyleDictionaryInternal() { }

	[Address(RVA = "0x1A6C9C0", Offset = "0x1A6BBC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A1")]
	public void RefreshStyles() { }

	[Address(RVA = "0x1A6C9C0", Offset = "0x1A6BBC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600019E")]
	private void Reset() { }

}

