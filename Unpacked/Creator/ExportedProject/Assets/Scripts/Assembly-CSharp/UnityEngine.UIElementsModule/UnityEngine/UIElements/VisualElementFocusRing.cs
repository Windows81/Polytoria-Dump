namespace UnityEngine.UIElements;

[Token(Token = "0x200051E")]
public class VisualElementFocusRing : IFocusRing
{
	[Token(Token = "0x200051F")]
	internal enum DefaultFocusOrder
	{
		ChildOrder = 0,
		PositionXY = 1,
		PositionYX = 2,
	}

	[Token(Token = "0x2000520")]
	private class FocusRingRecord
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010F8")]
		public int m_AutoIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010F9")]
		public Focusable m_Focusable; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010FA")]
		public bool m_IsSlot; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010FB")]
		public List<FocusRingRecord> m_ScopeNavigationOrder; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002540")]
		public FocusRingRecord() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010F1")]
	private readonly VisualElement root; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010F2")]
	private DefaultFocusOrder <defaultFocusOrder>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010F3")]
	private List<FocusRingRecord> m_FocusRing; //Field offset: 0x20

	[Token(Token = "0x170009B1")]
	public DefaultFocusOrder defaultFocusOrder
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002531")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002532")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170009B0")]
	private FocusController focusController
	{
		[Address(RVA = "0x1393560", Offset = "0x1392760", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002530")]
		private get { } //Length: 42
	}

	[Address(RVA = "0x1B75490", Offset = "0x1B74690", Length = "0x9A")]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "set_rootVisualElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600252F")]
	public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = 0) { }

	[Address(RVA = "0x1B73C10", Offset = "0x1B72E10", Length = "0x2C6")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_isCompositeRoot", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002536")]
	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList) { }

	[Address(RVA = "0x1B73EE0", Offset = "0x1B730E0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002535")]
	private void DoUpdate() { }

	[Address(RVA = "0x1B73FC0", Offset = "0x1B731C0", Length = "0x3B0")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "FocusRingSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusRingRecord), typeof(FocusRingRecord)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002533")]
	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	[Address(RVA = "0x1B74380", Offset = "0x1B73580", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "FocusRingAutoIndexSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusRingRecord), typeof(FocusRingRecord)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002534")]
	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002531")]
	public DefaultFocusOrder get_defaultFocusOrder() { }

	[Address(RVA = "0x1393560", Offset = "0x1392760", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002530")]
	private FocusController get_focusController() { }

	[Address(RVA = "0x1B747D0", Offset = "0x1B739D0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002538")]
	private int GetFocusableInternalIndex(Focusable f) { }

	[Address(RVA = "0x1B744A0", Offset = "0x1B736A0", Length = "0x325")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C920")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002539")]
	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[Address(RVA = "0x1B74880", Offset = "0x1B73A80", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetNextElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600253E")]
	private VisualElement GetNextElementDepthFirst(VisualElement ve) { }

	[Address(RVA = "0x1B74F70", Offset = "0x1B74170", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[Token(Token = "0x600253A")]
	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x1B748E0", Offset = "0x1B73AE0", Length = "0x583")]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetNextElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "get_delegatesFocus", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "GetPreviousElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C920")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600253B")]
	internal Focusable GetNextFocusableInSequence(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x1B74E70", Offset = "0x1B74070", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetNextElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600253C")]
	internal VisualElement GetNextFocusableInTree(VisualElement currentFocusable) { }

	[Address(RVA = "0x1B750E0", Offset = "0x1B742E0", Length = "0xA6")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "GetPreviousElementDepthFirst", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600253F")]
	private VisualElement GetPreviousElementDepthFirst(VisualElement ve) { }

	[Address(RVA = "0x1B75190", Offset = "0x1B74390", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "GetPreviousElementDepthFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600253D")]
	internal VisualElement GetPreviousFocusableInTree(VisualElement currentFocusable) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002532")]
	public void set_defaultFocusOrder(DefaultFocusOrder value) { }

	[Address(RVA = "0x1B75240", Offset = "0x1B74440", Length = "0x247")]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Focusable), Member = "get_excludeFromFocusRing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "SortAndFlattenScopeLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002537")]
	private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList) { }

}

