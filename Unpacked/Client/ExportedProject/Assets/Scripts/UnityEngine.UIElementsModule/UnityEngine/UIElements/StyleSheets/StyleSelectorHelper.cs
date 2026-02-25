namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000603")]
internal static class StyleSelectorHelper
{
	[Token(Token = "0x2000604")]
	private struct SelectorWorkItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001679")]
		public OrderedSelectorType type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400167A")]
		public string input; //Field offset: 0x8

		[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A76")]
		public SelectorWorkItem(OrderedSelectorType type, string input) { }

	}


	[Address(RVA = "0x1BC6810", Offset = "0x1BC5A10", Length = "0x3D2")]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(AncestorFilter), Member = "IsCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSelectorHelper), Member = "MatchesSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleSelector)}, ReturnType = typeof(MatchResultInfo))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015230")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002A74")]
	private static void FastLookup(IDictionary<String, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	[Address(RVA = "0x1BC6BF0", Offset = "0x1BC5DF0", Length = "0x85B")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015230")]
	[Calls(Type = typeof(StyleSelectorHelper), Member = "MatchRightToLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleComplexSelector), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AncestorFilter), Member = "IsCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSelectorHelper), Member = "FastLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.String, UnityEngine.UIElements.StyleComplexSelector>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(StyleMatchingContext), typeof(string), typeof(SelectorMatchRecord&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleMatchingContext), Member = "GetStyleSheetAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleSheet))]
	[Calls(Type = typeof(StyleMatchingContext), Member = "get_styleSheetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BBC7E0")]
	[Calls(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A75")]
	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

	[Address(RVA = "0x1BC7660", Offset = "0x1BC6860", Length = "0x2F0")]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "MatchRightToLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleComplexSelector), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FastLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.String, UnityEngine.UIElements.StyleComplexSelector>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(StyleMatchingContext), typeof(string), typeof(SelectorMatchRecord&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A71")]
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	[Address(RVA = "0x1BC7450", Offset = "0x1BC6650", Length = "0x20F")]
	[CalledBy(Type = typeof(UQueryMatcher), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "TestSelectorLinkedList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(StyleMatchingContext), typeof(SelectorMatchRecord&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleSelectorHelper), Member = "MatchesSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleSelector)}, ReturnType = typeof(MatchResultInfo))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A72")]
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

	[Address(RVA = "0x1BC7970", Offset = "0x1BC6B70", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AncestorFilter), Member = "IsCandidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleComplexSelector)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSelectorHelper), Member = "MatchRightToLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleComplexSelector), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015230")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002A73")]
	private static void TestSelectorLinkedList(StyleComplexSelector currentComplexSelector, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, ref SelectorMatchRecord record) { }

}

