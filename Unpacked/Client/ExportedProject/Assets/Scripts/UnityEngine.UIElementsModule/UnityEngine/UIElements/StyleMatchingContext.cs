namespace UnityEngine.UIElements;

[Token(Token = "0x200052F")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleMatchingContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001128")]
	private List<StyleSheet> m_StyleSheetStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001129")]
	public StyleVariableContext variableContext; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400112A")]
	public VisualElement currentElement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400112B")]
	public Action<VisualElement, MatchResultInfo> processResult; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400112C")]
	public AncestorFilter ancestorFilter; //Field offset: 0x30

	[Token(Token = "0x170009B9")]
	public int styleSheetCount
	{
		[Address(RVA = "0x1B67780", Offset = "0x1B66980", Length = "0x3C")]
		[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600258B")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x1B67660", Offset = "0x1B66860", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AncestorFilter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600258C")]
	public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult) { }

	[Address(RVA = "0x1B674B0", Offset = "0x1B666B0", Length = "0xDC")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600258D")]
	public void AddStyleSheet(StyleSheet sheet) { }

	[Address(RVA = "0x1B67780", Offset = "0x1B66980", Length = "0x3C")]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600258B")]
	public int get_styleSheetCount() { }

	[Address(RVA = "0x1B67590", Offset = "0x1B66790", Length = "0x51")]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600258F")]
	public StyleSheet GetStyleSheetAt(int index) { }

	[Address(RVA = "0x1B675F0", Offset = "0x1B667F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600258E")]
	public void RemoveStyleSheetRange(int index, int count) { }

}

