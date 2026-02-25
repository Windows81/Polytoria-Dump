namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200004E")]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
{
	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private sealed class <DelayedSetDirty>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000183")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000184")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000185")]
		public RectTransform rectTransform; //Field offset: 0x20

		[Token(Token = "0x170000D3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000304")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000D4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000306")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000301")]
		public <DelayedSetDirty>d__57(int <>1__state) { }

		[Address(RVA = "0x1CC73F0", Offset = "0x1CC65F0", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000303")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000304")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000306")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CC7480", Offset = "0x1CC6680", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000305")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000302")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400017B")]
	protected RectOffset m_Padding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400017C")]
	protected TextAnchor m_ChildAlignment; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017D")]
	private RectTransform m_Rect; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017E")]
	protected DrivenRectTransformTracker m_Tracker; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400017F")]
	private Vector2 m_TotalMinSize; //Field offset: 0x3C
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000180")]
	private Vector2 m_TotalPreferredSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000181")]
	private Vector2 m_TotalFlexibleSize; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000182")]
	private List<RectTransform> m_RectChildren; //Field offset: 0x58

	[Token(Token = "0x170000C8")]
	public TextAnchor childAlignment
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DD")]
		 get { } //Length: 4
		[Address(RVA = "0x1CC1CD0", Offset = "0x1CC0ED0", Length = "0x4B")]
		[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Token(Token = "0x60002DE")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000D0")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x1A1E2F0", Offset = "0x1A1D4F0", Length = "0x8")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CD")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x1A1E2E0", Offset = "0x1A1D4E0", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D2")]
	private bool isRootLayoutGroup
	{
		[Address(RVA = "0x1CC1B20", Offset = "0x1CC0D20", Length = "0x11A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60002FA")]
		private get { } //Length: 282
	}

	[Token(Token = "0x170000D1")]
	public override int layoutPriority
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CE")]
	public override float minHeight
	{
		[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CB")]
	public override float minWidth
	{
		[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C7")]
	public RectOffset padding
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DB")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC1D20", Offset = "0x1CC0F20", Length = "0x4C")]
		[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Battlehub.UIControls.TreeViewItem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "UpdateIndent", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "ZeroIndent", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "StartOverride", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeViewItem", Member = "UpdateIndent", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeViewItem", Member = "ZeroIndent", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeViewItem", Member = "StartOverride", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x60002DC")]
		 set { } //Length: 76
	}

	[Token(Token = "0x170000CF")]
	public override float preferredHeight
	{
		[Address(RVA = "0x1A1E2C0", Offset = "0x1A1D4C0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CC")]
	public override float preferredWidth
	{
		[Address(RVA = "0x1A1E2B0", Offset = "0x1A1D4B0", Length = "0x8")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000CA")]
	protected List<RectTransform> rectChildren
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C9")]
	protected RectTransform rectTransform
	{
		[Address(RVA = "0x1CC1C40", Offset = "0x1CC0E40", Length = "0x8D")]
		[CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60002DF")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x1CC1980", Offset = "0x1CC0B80", Length = "0x194")]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002EC")]
	protected LayoutGroup() { }

	[Address(RVA = "0x1CC0990", Offset = "0x1CBFB90", Length = "0x335")]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002E1")]
	public override void CalculateLayoutInputHorizontal() { }

	[Token(Token = "0x60002E2")]
	public abstract void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CC0CD0", Offset = "0x1CBFED0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedSetDirty>d__57))]
	[Token(Token = "0x6000300")]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DD")]
	public TextAnchor get_childAlignment() { }

	[Address(RVA = "0x1A1E2F0", Offset = "0x1A1D4F0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E8")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x1A1E2E0", Offset = "0x1A1D4E0", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E5")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1CC1B20", Offset = "0x1CC0D20", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002FA")]
	private bool get_isRootLayoutGroup() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E9")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E6")]
	public override float get_minHeight() { }

	[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E3")]
	public override float get_minWidth() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DB")]
	public RectOffset get_padding() { }

	[Address(RVA = "0x1A1E2C0", Offset = "0x1A1D4C0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E7")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x1A1E2B0", Offset = "0x1A1D4B0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E4")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E0")]
	protected List<RectTransform> get_rectChildren() { }

	[Address(RVA = "0x1CC1C40", Offset = "0x1CC0E40", Length = "0x8D")]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60002DF")]
	protected RectTransform get_rectTransform() { }

	[Address(RVA = "0x1CC0D40", Offset = "0x1CBFF40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002F4")]
	protected float GetAlignmentOnAxis(int axis) { }

	[Address(RVA = "0x1CC0D90", Offset = "0x1CBFF90", Length = "0x15F")]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002F3")]
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	[Address(RVA = "0x1CC0EF0", Offset = "0x1CC00F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x60002F2")]
	protected float GetTotalFlexibleSize(int axis) { }

	[Address(RVA = "0x1CC0F00", Offset = "0x1CC0100", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x60002F0")]
	protected float GetTotalMinSize(int axis) { }

	[Address(RVA = "0x1CC0F10", Offset = "0x1CC0110", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x60002F1")]
	protected float GetTotalPreferredSize(int axis) { }

	[Address(RVA = "0x1CC0F20", Offset = "0x1CC0120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FD")]
	protected override void OnChildRectTransformDimensionsChange() { }

	[Address(RVA = "0x1CC0F20", Offset = "0x1CC0120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002EF")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CC0F30", Offset = "0x1CC0130", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sendChildDimensionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002EE")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CC0FD0", Offset = "0x1CC01D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sendChildDimensionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002ED")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CC1020", Offset = "0x1CC0220", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Component))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002FB")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1CC0F20", Offset = "0x1CC0120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FC")]
	protected override void OnTransformChildrenChanged() { }

	[Address(RVA = "0x1CC1CD0", Offset = "0x1CC0ED0", Length = "0x4B")]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "set_ChildAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingScrollRect", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x60002DE")]
	public void set_childAlignment(TextAnchor value) { }

	[Address(RVA = "0x1CC1D20", Offset = "0x1CC0F20", Length = "0x4C")]
	[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Battlehub.UIControls.TreeViewItem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "UpdateIndent", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "ZeroIndent", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.TreeViewItem", Member = "StartOverride", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeViewItem", Member = "UpdateIndent", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeViewItem", Member = "ZeroIndent", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingTreeViewItem", Member = "StartOverride", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002DC")]
	public void set_padding(RectOffset value) { }

	[Address(RVA = "0x1CC1670", Offset = "0x1CC0870", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002F6")]
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	[Address(RVA = "0x1CC1710", Offset = "0x1CC0910", Length = "0xAE")]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002F8")]
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	[Address(RVA = "0x1CC1150", Offset = "0x1CC0350", Length = "0x2C5")]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F9")]
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	[Address(RVA = "0x1CC1420", Offset = "0x1CC0620", Length = "0x242")]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F7")]
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	[Address(RVA = "0x1CC17C0", Offset = "0x1CC09C0", Length = "0x121")]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnChildRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002FF")]
	protected void SetDirty() { }

	[Token(Token = "0x60002EA")]
	public abstract void SetLayoutHorizontal() { }

	[Address(RVA = "0x1CC18F0", Offset = "0x1CC0AF0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60002F5")]
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	[Token(Token = "0x60002EB")]
	public abstract void SetLayoutVertical() { }

	[Address(RVA = "0x6EA890", Offset = "0x6E9A90", Length = "0x94")]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_reverseArrangement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FE")]
	protected void SetProperty(ref T currentValue, T newValue) { }

}

