namespace UnityEngine.UI;

[Token(Token = "0x2000050")]
public class LayoutRebuilder : ICanvasElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private sealed class <>c
	{
		[Token(Token = "0x4000189")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400018A")]
		public static Predicate<Component> <>9__10_0; //Field offset: 0x8
		[Token(Token = "0x400018B")]
		public static UnityAction<Component> <>9__12_0; //Field offset: 0x10
		[Token(Token = "0x400018C")]
		public static UnityAction<Component> <>9__12_1; //Field offset: 0x18
		[Token(Token = "0x400018D")]
		public static UnityAction<Component> <>9__12_2; //Field offset: 0x20
		[Token(Token = "0x400018E")]
		public static UnityAction<Component> <>9__12_3; //Field offset: 0x28

		[Address(RVA = "0x1CC7EA0", Offset = "0x1CC70A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600031B")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031C")]
		public <>c() { }

		[Address(RVA = "0x1CC7DA0", Offset = "0x1CC6FA0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600031D")]
		internal LayoutRebuilder <.cctor>b__5_0() { }

		[Address(RVA = "0x1CC7DF0", Offset = "0x1CC6FF0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600031E")]
		internal void <.cctor>b__5_1(LayoutRebuilder x) { }

		[Address(RVA = "0x1CC7B40", Offset = "0x1CC6D40", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000320")]
		internal void <Rebuild>b__12_0(Component e) { }

		[Address(RVA = "0x1CC7BB0", Offset = "0x1CC6DB0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000321")]
		internal void <Rebuild>b__12_1(Component e) { }

		[Address(RVA = "0x1CC7C20", Offset = "0x1CC6E20", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000322")]
		internal void <Rebuild>b__12_2(Component e) { }

		[Address(RVA = "0x1CC7C90", Offset = "0x1CC6E90", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000323")]
		internal void <Rebuild>b__12_3(Component e) { }

		[Address(RVA = "0x1CC7D00", Offset = "0x1CC6F00", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600031F")]
		internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	}

	[Token(Token = "0x4000188")]
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000186")]
	private RectTransform m_ToRebuild; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000187")]
	private int m_CachedHashFromTransform; //Field offset: 0x18

	[Token(Token = "0x170000D5")]
	public override Transform transform
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1CC3410", Offset = "0x1CC2610", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectTransform), Member = "add_reapplyDrivenProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReapplyDrivenProperties)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000309")]
	private static LayoutRebuilder() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600031A")]
	public LayoutRebuilder() { }

	[Address(RVA = "0x1CC1D70", Offset = "0x1CC0F70", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000308")]
	private void Clear() { }

	[Address(RVA = "0x1CC1DA0", Offset = "0x1CC0FA0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000318")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1CC1E00", Offset = "0x1CC1000", Length = "0xFB")]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UIHVLayout", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "DebugLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004CFE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E9190")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600030E")]
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030B")]
	public override Transform get_transform() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000317")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000316")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x1CC1F00", Offset = "0x1CC1100", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000307")]
	private void Initialize(RectTransform controller) { }

	[Address(RVA = "0x1CC1F50", Offset = "0x1CC1150", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600030C")]
	public override bool IsDestroyed() { }

	[Address(RVA = "0x1CC1FA0", Offset = "0x1CC11A0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E9190")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000315")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x1CC2020", Offset = "0x1CC1220", Length = "0x519")]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "ReapplyDrivenProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup+<DelayedSetDirty>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "SetLayoutDirty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetLayoutDirty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetLayoutDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E9190")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004CFE0")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "ValidController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Collections.Generic.List`1<UnityEngine.Component>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000312")]
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	[Address(RVA = "0x1CC2540", Offset = "0x1CC1740", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004CFE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E9190")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000314")]
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	[Address(RVA = "0x1CC26C0", Offset = "0x1CC18C0", Length = "0x270")]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Component&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "StripDisabledBehavioursFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000311")]
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	[Address(RVA = "0x1CC2940", Offset = "0x1CC1B40", Length = "0x3A2")]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutRebuilder), Member = "StripDisabledBehavioursFromList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000310")]
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	[Address(RVA = "0x1CC2CF0", Offset = "0x1CC1EF0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Token(Token = "0x600030A")]
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	[Address(RVA = "0x1CC2D40", Offset = "0x1CC1F40", Length = "0x34B")]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600030F")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x1CC3090", Offset = "0x1CC2290", Length = "0x117")]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Component>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600030D")]
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	[Address(RVA = "0x1CC31B0", Offset = "0x1CC23B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000319")]
	public virtual string ToString() { }

	[Address(RVA = "0x1CC3210", Offset = "0x1CC2410", Length = "0x1F3")]
	[CalledBy(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000313")]
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

}

