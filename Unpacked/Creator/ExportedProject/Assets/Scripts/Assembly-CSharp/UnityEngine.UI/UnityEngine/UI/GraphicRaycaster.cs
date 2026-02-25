namespace UnityEngine.UI;

[AddComponentMenu("Event/Graphic Raycaster")]
[RequireComponent(typeof(Canvas))]
[Token(Token = "0x200001F")]
public class GraphicRaycaster : BaseRaycaster
{
	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <>c
	{
		[Token(Token = "0x4000090")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000091")]
		public static Comparison<Graphic> <>9__27_0; //Field offset: 0x8

		[Address(RVA = "0x1A91C40", Offset = "0x1A90E40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600012F")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000130")]
		public <>c() { }

		[Address(RVA = "0x1A91AA0", Offset = "0x1A90CA0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000131")]
		internal int <Raycast>b__27_0(Graphic g1, Graphic g2) { }

	}

	[Token(Token = "0x2000020")]
	internal enum BlockingObjects
	{
		None = 0,
		TwoD = 1,
		ThreeD = 2,
		All = 3,
	}

	[Token(Token = "0x4000084")]
	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	[Token(Token = "0x400008A")]
	private static readonly List<Graphic> s_SortedGraphics; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private bool m_IgnoreReversedGraphics; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private BlockingObjects m_BlockingObjects; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	protected LayerMask m_BlockingMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000088")]
	private Canvas m_Canvas; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000089")]
	private List<Graphic> m_RaycastResults; //Field offset: 0x40

	[Token(Token = "0x17000047")]
	public LayerMask blockingMask
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000127")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000128")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public BlockingObjects blockingObjects
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000048")]
	private Canvas canvas
	{
		[Address(RVA = "0x1A84000", Offset = "0x1A83200", Length = "0x8D")]
		[CalledBy(Type = typeof(GraphicRaycaster), Member = "get_sortOrderPriority", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GraphicRaycaster), Member = "get_renderOrderPriority", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicRaycaster), Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600012A")]
		private get { } //Length: 141
	}

	[Token(Token = "0x17000049")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x1A84090", Offset = "0x1A83290", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600012C")]
		 get { } //Length: 176
	}

	[Token(Token = "0x17000045")]
	public bool ignoreReversedGraphics
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000123")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000044")]
	public virtual int renderOrderPriority
	{
		[Address(RVA = "0x1A84150", Offset = "0x1A83350", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_renderOrder", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000122")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000043")]
	public virtual int sortOrderPriority
	{
		[Address(RVA = "0x1A841B0", Offset = "0x1A833B0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000121")]
		 get { } //Length: 80
	}

	[Address(RVA = "0x1A83EE0", Offset = "0x1A830E0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012E")]
	private static GraphicRaycaster() { }

	[Address(RVA = "0x1A83F70", Offset = "0x1A83170", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000129")]
	protected GraphicRaycaster() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000127")]
	public LayerMask get_blockingMask() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	public BlockingObjects get_blockingObjects() { }

	[Address(RVA = "0x1A84000", Offset = "0x1A83200", Length = "0x8D")]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "get_sortOrderPriority", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "get_renderOrderPriority", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600012A")]
	private Canvas get_canvas() { }

	[Address(RVA = "0x1A84090", Offset = "0x1A83290", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600012C")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000123")]
	public bool get_ignoreReversedGraphics() { }

	[Address(RVA = "0x1A84150", Offset = "0x1A83350", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_renderOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000122")]
	public virtual int get_renderOrderPriority() { }

	[Address(RVA = "0x1A841B0", Offset = "0x1A833B0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	public virtual int get_sortOrderPriority() { }

	[Address(RVA = "0x1A83020", Offset = "0x1A82220", Length = "0xEBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Camera), typeof(Vector2), typeof(System.Collections.Generic.IList`1<UnityEngine.UI.Graphic>), typeof(System.Collections.Generic.List`1<UnityEngine.UI.Graphic>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "ScreenToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4600")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012B")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x1A82A40", Offset = "0x1A81C40", Length = "0x5D4")]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector4)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600012D")]
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000128")]
	public void set_blockingMask(LayerMask value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000126")]
	public void set_blockingObjects(BlockingObjects value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000124")]
	public void set_ignoreReversedGraphics(bool value) { }

}

