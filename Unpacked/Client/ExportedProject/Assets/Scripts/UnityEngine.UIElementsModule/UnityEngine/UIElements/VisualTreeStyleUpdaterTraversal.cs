namespace UnityEngine.UIElements;

[Token(Token = "0x2000530")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
{
	[CompilerGenerated]
	[Token(Token = "0x2000531")]
	private sealed class <>c
	{
		[Token(Token = "0x4001136")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001137")]
		public static Comparison<SelectorMatchRecord> <>9__28_0; //Field offset: 0x8

		[Address(RVA = "0x1B67AF0", Offset = "0x1B66CF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025A2")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025A3")]
		public <>c() { }

		[Address(RVA = "0x1B67830", Offset = "0x1B66A30", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SelectorMatchRecord), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
		[Token(Token = "0x60025A4")]
		internal int <ProcessMatchedRules>b__28_0(SelectorMatchRecord a, SelectorMatchRecord b) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400112D")]
	private StyleVariableContext m_ProcessVarContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400112E")]
	private HashSet<VisualElement> m_UpdateList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400112F")]
	private HashSet<VisualElement> m_ParentList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001130")]
	private List<SelectorMatchRecord> m_TempMatchResults; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001131")]
	private float <currentPixelsPerPoint>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001132")]
	private StyleMatchingContext m_StyleMatchingContext; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001133")]
	private StylePropertyReader m_StylePropertyReader; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001134")]
	private BaseVisualElementPanel <currentPanel>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001135")]
	private readonly List<StylePropertyId> m_AnimatedProperties; //Field offset: 0x50

	[Token(Token = "0x170009BB")]
	private BaseVisualElementPanel currentPanel
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002592")]
		private get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002593")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170009BA")]
	private float currentPixelsPerPoint
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002590")]
		private get { } //Length: 6
		[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002591")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x1B78560", Offset = "0x1B77760", Length = "0x31A")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StyleVariableContext), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AncestorFilter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60025A1")]
	public VisualTreeStyleUpdaterTraversal() { }

	[Address(RVA = "0x1B76750", Offset = "0x1B75950", Length = "0x101")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "PropagateToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002595")]
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B76860", Offset = "0x1B75A60", Length = "0x1D5")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "HasTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600259D")]
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	[Address(RVA = "0x1B76A40", Offset = "0x1B75C40", Length = "0x95")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002596")]
	public void Clear() { }

	[Address(RVA = "0x1B76AE0", Offset = "0x1B75CE0", Length = "0x23E")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600259C")]
	private void ForceUpdateTransitions(VisualElement element) { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002592")]
	private BaseVisualElementPanel get_currentPanel() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002590")]
	private float get_currentPixelsPerPoint() { }

	[Address(RVA = "0x1B76D20", Offset = "0x1B75F20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002599")]
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	[Address(RVA = "0x1B76D60", Offset = "0x1B75F60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002594")]
	public void PrepareTraversal(BaseVisualElementPanel panel, float pixelsPerPoint) { }

	[Address(RVA = "0x1B76D90", Offset = "0x1B75F90", Length = "0xAF8")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleVariableContext), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, UnityEngine.UIElements.ComputedStyle>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InitialStyle), Member = "Get", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleVariableContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleVariableContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleComplexSelector), typeof(StyleVariableContext), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "FinalizeApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, UnityEngine.UIElements.ComputedStyle>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedStyle))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StyleSheet), Member = "get_contentHash", ReturnType = typeof(int))]
	[Calls(Type = typeof(StyleVariableContext), Member = "AddInitialRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleVariableContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600259F")]
	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) { }

	[Address(RVA = "0x1B77890", Offset = "0x1B76A90", Length = "0x115")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleVariableContext), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleVariable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60025A0")]
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	[Address(RVA = "0x1B779B0", Offset = "0x1B76BB0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_hasInlineStyle", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "IsValueSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600259B")]
	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	[Address(RVA = "0x1B77AE0", Offset = "0x1B76CE0", Length = "0xDA")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "AddChangedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "PropagateToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "PropagateToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002597")]
	private void PropagateToChildren(VisualElement ve) { }

	[Address(RVA = "0x1B77BC0", Offset = "0x1B76DC0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002598")]
	private void PropagateToParents(VisualElement ve) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002593")]
	private void set_currentPanel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002591")]
	private void set_currentPixelsPerPoint(float value) { }

	[Address(RVA = "0x1B77C70", Offset = "0x1B76E70", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600259E")]
	protected bool ShouldSkipElement(VisualElement element) { }

	[Address(RVA = "0x1B77CF0", Offset = "0x1B76EF0", Length = "0x86A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_hasTransition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "IsValueSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "StartAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ForceUpdateTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_styleInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "HasSelfEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleInitialized", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(AncestorFilter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AncestorFilter), Member = "PopElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "CancelAnimationsWithNoTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleMatchingContext), Member = "AddStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_customPropertiesCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_hasInlineStyle", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_hasRunningAnimations", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600259A")]
	public virtual void TraverseRecursive(VisualElement element, int depth) { }

}

