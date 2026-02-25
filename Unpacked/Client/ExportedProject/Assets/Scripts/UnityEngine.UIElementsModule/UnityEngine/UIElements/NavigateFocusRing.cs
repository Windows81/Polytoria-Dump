namespace UnityEngine.UIElements;

[Token(Token = "0x2000262")]
internal class NavigateFocusRing : IFocusRing
{
	[Token(Token = "0x2000263")]
	internal class ChangeDirection : FocusChangeDirection
	{

		[Address(RVA = "0x1C63A50", Offset = "0x1C62C50", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60010A8")]
		public ChangeDirection(int i) { }

	}

	[Token(Token = "0x2000264")]
	private struct FocusableHierarchyTraversal
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000958")]
		public VisualElement root; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000959")]
		public VisualElement currentFocusable; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400095A")]
		public Rect validRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400095B")]
		public bool firstPass; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400095C")]
		public ChangeDirection direction; //Field offset: 0x28

		[Address(RVA = "0x1C68BD0", Offset = "0x1C67DD0", Length = "0x11D")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection), typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010AF")]
		public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null) { }

		[Address(RVA = "0x1C68CF0", Offset = "0x1C67EF0", Length = "0x118")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "TieBreaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010AB")]
		private int Order(VisualElement a, VisualElement b) { }

		[Address(RVA = "0x1C68E10", Offset = "0x1C68010", Length = "0xE7")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010AC")]
		private int StrictOrder(VisualElement a, VisualElement b) { }

		[Address(RVA = "0x1C68F00", Offset = "0x1C68100", Length = "0x1D0")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "StrictOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010AD")]
		private int StrictOrder(Rect ra, Rect rb) { }

		[Address(RVA = "0x1C690D0", Offset = "0x1C682D0", Length = "0x15B")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "Order", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010AE")]
		private int TieBreaker(Rect ra, Rect rb) { }

		[Address(RVA = "0x1C69230", Offset = "0x1C68430", Length = "0x156")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010AA")]
		private bool ValidateElement(VisualElement v) { }

		[Address(RVA = "0x1C69390", Offset = "0x1C68590", Length = "0x178")]
		[CalledBy(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010A9")]
		private bool ValidateHierarchyTraversal(VisualElement v) { }

	}

	[Token(Token = "0x4000950")]
	public static readonly ChangeDirection Left; //Field offset: 0x0
	[Token(Token = "0x4000951")]
	public static readonly ChangeDirection Right; //Field offset: 0x8
	[Token(Token = "0x4000952")]
	public static readonly ChangeDirection Up; //Field offset: 0x10
	[Token(Token = "0x4000953")]
	public static readonly ChangeDirection Down; //Field offset: 0x18
	[Token(Token = "0x4000954")]
	public static readonly FocusChangeDirection Next; //Field offset: 0x20
	[Token(Token = "0x4000955")]
	public static readonly FocusChangeDirection Previous; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000956")]
	private readonly VisualElement m_Root; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000957")]
	private readonly VisualElementFocusRing m_Ring; //Field offset: 0x18

	[Token(Token = "0x17000315")]
	private FocusController focusController
	{
		[Address(RVA = "0x1393560", Offset = "0x1392760", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600109F")]
		private get { } //Length: 42
	}

	[Address(RVA = "0x1C70C00", Offset = "0x1C6FE00", Length = "0x31D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60010A7")]
	private static NavigateFocusRing() { }

	[Address(RVA = "0x1C70F20", Offset = "0x1C70120", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010A0")]
	public NavigateFocusRing(VisualElement root) { }

	[Address(RVA = "0x1393560", Offset = "0x1392760", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600109F")]
	private FocusController get_focusController() { }

	[Address(RVA = "0x1C6FAF0", Offset = "0x1C6ECF0", Length = "0x31C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElementFocusChangeTarget), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(VisualElementFocusChangeTarget))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010A1")]
	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	[Address(RVA = "0x1C70610", Offset = "0x1C6F810", Length = "0x436")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocument), Member = "FindRootUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(UIDocument))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection), typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010A2")]
	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	[Address(RVA = "0x1C6FFB0", Offset = "0x1C6F1B0", Length = "0x651")]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FocusableHierarchyTraversal), Member = "GetBestOverall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010A4")]
	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction, VisualElement root) { }

	[Address(RVA = "0x1C70A50", Offset = "0x1C6FC50", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010A5")]
	private static bool IsActive(VisualElement v) { }

	[Address(RVA = "0x1C70AC0", Offset = "0x1C6FCC0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010A6")]
	private static bool IsNavigable(Focusable focusable) { }

	[Address(RVA = "0x1C70B10", Offset = "0x1C6FD10", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocument), Member = "FindRootUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(UIDocument))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010A3")]
	private bool IsWorldSpaceNavigationValid(Focusable currentFocusable, out UIDocument document) { }

}

