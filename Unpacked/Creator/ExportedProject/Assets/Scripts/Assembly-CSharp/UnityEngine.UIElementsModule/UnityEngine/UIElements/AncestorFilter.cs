namespace UnityEngine.UIElements;

[Token(Token = "0x2000178")]
internal class AncestorFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000746")]
	private CountingBloomFilter m_CountingBloomFilter; //Field offset: 0x10
	[FieldOffset(Offset = "0x4010")]
	[Token(Token = "0x4000747")]
	private Stack<Int32> m_HashStack; //Field offset: 0x4010

	[Address(RVA = "0x1C308B0", Offset = "0x1C2FAB0", Length = "0x82")]
	[CalledBy(Type = typeof(StyleMatchingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B46")]
	public AncestorFilter() { }

	[Address(RVA = "0x1C304D0", Offset = "0x1C2F6D0", Length = "0x7B")]
	[CalledBy(Type = typeof(AncestorFilter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B47")]
	private void AddHash(int hash) { }

	[Address(RVA = "0x1C30550", Offset = "0x1C2F750", Length = "0x67")]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "TestSelectorLinkedList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(StyleMatchingContext), typeof(SelectorMatchRecord&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FastLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.String, UnityEngine.UIElements.StyleComplexSelector>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(StyleMatchingContext), typeof(string), typeof(SelectorMatchRecord&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B48")]
	public bool IsCandidate(StyleComplexSelector complexSel) { }

	[Address(RVA = "0x1C305C0", Offset = "0x1C2F7C0", Length = "0xDC")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B4A")]
	public void PopElement() { }

	[Address(RVA = "0x1C306A0", Offset = "0x1C2F8A0", Length = "0x205")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(AncestorFilter), Member = "AddHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000B49")]
	public void PushElement(VisualElement element) { }

}

