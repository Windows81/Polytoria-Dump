namespace UnityEngine.UI;

[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200003A")]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
{
	[Token(Token = "0x200003B")]
	internal enum AspectMode
	{
		None = 0,
		WidthControlsHeight = 1,
		HeightControlsWidth = 2,
		FitInParent = 3,
		EnvelopeParent = 4,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000128")]
	private AspectMode m_AspectMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000129")]
	private float m_AspectRatio; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400012A")]
	private RectTransform m_Rect; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400012B")]
	private bool m_DelayedSetDirty; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400012C")]
	private bool m_DoesParentExist; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400012D")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x32

	[Token(Token = "0x17000099")]
	public AspectMode aspectMode
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024A")]
		 get { } //Length: 4
		[Address(RVA = "0x1CB23C0", Offset = "0x1CB15C0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[Token(Token = "0x600024B")]
		 set { } //Length: 86
	}

	[Token(Token = "0x1700009A")]
	public float aspectRatio
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024C")]
		 get { } //Length: 6
		[Address(RVA = "0x1CB2420", Offset = "0x1CB1620", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[Token(Token = "0x600024D")]
		 set { } //Length: 89
	}

	[Token(Token = "0x1700009B")]
	private RectTransform rectTransform
	{
		[Address(RVA = "0x1CB2330", Offset = "0x1CB1530", Length = "0x8D")]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600024E")]
		private get { } //Length: 141
	}

	[Address(RVA = "0x1CB2320", Offset = "0x1CB1520", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600024F")]
	protected AspectRatioFitter() { }

	[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025E")]
	private bool DoesParentExists() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024A")]
	public AspectMode get_aspectMode() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024C")]
	public float get_aspectRatio() { }

	[Address(RVA = "0x1CB2330", Offset = "0x1CB1530", Length = "0x8D")]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600024E")]
	private RectTransform get_rectTransform() { }

	[Address(RVA = "0x1CB1950", Offset = "0x1CB0B50", Length = "0xFF")]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000258")]
	private Vector2 GetParentSize() { }

	[Address(RVA = "0x1CB1A50", Offset = "0x1CB0C50", Length = "0x1CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000257")]
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	[Address(RVA = "0x1CB1C20", Offset = "0x1CB0E20", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025D")]
	public bool IsAspectModeValid() { }

	[Address(RVA = "0x1CB1C40", Offset = "0x1CB0E40", Length = "0xAB")]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025C")]
	public bool IsComponentValidOnObject() { }

	[Address(RVA = "0x1CB1CF0", Offset = "0x1CB0EF0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000252")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CB1D70", Offset = "0x1CB0F70", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000250")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CB1E10", Offset = "0x1CB1010", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000255")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1CB1E20", Offset = "0x1CB1020", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000253")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1CB23C0", Offset = "0x1CB15C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[Token(Token = "0x600024B")]
	public void set_aspectMode(AspectMode value) { }

	[Address(RVA = "0x1CB2420", Offset = "0x1CB1620", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[Token(Token = "0x600024D")]
	public void set_aspectRatio(float value) { }

	[Address(RVA = "0x1CB1E10", Offset = "0x1CB1010", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600025B")]
	protected void SetDirty() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000259")]
	public override void SetLayoutHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025A")]
	public override void SetLayoutVertical() { }

	[Address(RVA = "0x1CB1EC0", Offset = "0x1CB10C0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000251")]
	protected virtual void Start() { }

	[Address(RVA = "0x1CB2300", Offset = "0x1CB1500", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
	[Token(Token = "0x6000254")]
	protected override void Update() { }

	[Address(RVA = "0x1CB1F10", Offset = "0x1CB1110", Length = "0x3EC")]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "set_aspectMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AspectMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "set_aspectRatio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AspectRatioFitter), Member = "SetDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AspectRatioFitter), Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000256")]
	private void UpdateRect() { }

}

