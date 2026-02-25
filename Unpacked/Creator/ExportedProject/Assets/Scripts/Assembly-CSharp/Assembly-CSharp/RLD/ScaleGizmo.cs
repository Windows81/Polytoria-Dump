namespace RLD;

[Token(Token = "0x2000111")]
public class ScaleGizmo : GizmoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004A2")]
	private GizmoLineSlider3D _pstvXSlider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A3")]
	private GizmoLineSlider3D _pstvYSlider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004A4")]
	private GizmoLineSlider3D _pstvZSlider; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004A5")]
	private GizmoLineSlider3D _negXSlider; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004A6")]
	private GizmoLineSlider3D _negYSlider; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004A7")]
	private GizmoLineSlider3D _negZSlider; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004A8")]
	private GizmoLineSlider3DCollection _axesSliders; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004A9")]
	private GizmoMultiAxisScaleMode _multiAxisScaleMode; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004AA")]
	private GizmoPlaneSlider3D _xySlider; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004AB")]
	private GizmoPlaneSlider3D _yzSlider; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40004AC")]
	private GizmoPlaneSlider3D _zxSlider; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004AD")]
	private GizmoPlaneSlider3DCollection _dblSliders; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004AE")]
	private GizmoCap3D _midCap; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004AF")]
	private GizmoUniformScaleDrag3D _unformScaleDrag; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40004B0")]
	private GizmoScaleGuide _scaleGuide; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40004B1")]
	private IEnumerable<GameObject> _scaleGuideTargetObjects; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40004B2")]
	private ScaleGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40004B3")]
	private ScaleGizmoSettings3D _settings3D; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x40004B4")]
	private ScaleGizmoHotkeys _hotkeys; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x40004B5")]
	private bool _useSnapEnableHotkey; //Field offset: 0xB8
	[FieldOffset(Offset = "0xB9")]
	[SerializeField]
	[Token(Token = "0x40004B6")]
	private bool _useMultiAxisScaleModeHotkey; //Field offset: 0xB9
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40004B7")]
	private ScaleGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40004B8")]
	private ScaleGizmoSettings3D _sharedSettings3D; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40004B9")]
	private ScaleGizmoHotkeys _sharedHotkeys; //Field offset: 0xD0

	[Token(Token = "0x1700039B")]
	public ScaleGizmoHotkeys Hotkeys
	{
		[Address(RVA = "0x528830", Offset = "0x527A30", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000B20")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000399")]
	public ScaleGizmoLookAndFeel3D LookAndFeel3D
	{
		[Address(RVA = "0x528850", Offset = "0x527A50", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000B1E")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000398")]
	public GizmoMultiAxisScaleMode MultiAxisScaleMode
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B1D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700039A")]
	public ScaleGizmoSettings3D Settings3D
	{
		[Address(RVA = "0x528870", Offset = "0x527A70", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000B1F")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700039C")]
	public ScaleGizmoHotkeys SharedHotkeys
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B21")]
		 get { } //Length: 8
		[Address(RVA = "0x5288A0", Offset = "0x527AA0", Length = "0x6D")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B22")]
		 set { } //Length: 109
	}

	[Token(Token = "0x1700039E")]
	public ScaleGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B25")]
		 get { } //Length: 8
		[Address(RVA = "0x528910", Offset = "0x527B10", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScaleGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x6000B26")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700039D")]
	public ScaleGizmoSettings3D SharedSettings3D
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B23")]
		 get { } //Length: 8
		[Address(RVA = "0x528940", Offset = "0x527B40", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ScaleGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[Token(Token = "0x6000B24")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170003A0")]
	public bool UseMultiAxisScaleModeHotkey
	{
		[Address(RVA = "0x528890", Offset = "0x527A90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000B29")]
		 get { } //Length: 8
		[Address(RVA = "0x528970", Offset = "0x527B70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700039F")]
	public bool UseSnapEnableHotkey
	{
		[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B27")]
		 get { } //Length: 8
		[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B28")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x528580", Offset = "0x527780", Length = "0x2A6")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateScaleGizmo", ReturnType = typeof(ScaleGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoScaleGuide), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoUniformScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000B3A")]
	public ScaleGizmo() { }

	[Address(RVA = "0x528830", Offset = "0x527A30", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B20")]
	public ScaleGizmoHotkeys get_Hotkeys() { }

	[Address(RVA = "0x528850", Offset = "0x527A50", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B1E")]
	public ScaleGizmoLookAndFeel3D get_LookAndFeel3D() { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1D")]
	public GizmoMultiAxisScaleMode get_MultiAxisScaleMode() { }

	[Address(RVA = "0x528870", Offset = "0x527A70", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B1F")]
	public ScaleGizmoSettings3D get_Settings3D() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B21")]
	public ScaleGizmoHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B25")]
	public ScaleGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B23")]
	public ScaleGizmoSettings3D get_SharedSettings3D() { }

	[Address(RVA = "0x528890", Offset = "0x527A90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B29")]
	public bool get_UseMultiAxisScaleModeHotkey() { }

	[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B27")]
	public bool get_UseSnapEnableHotkey() { }

	[Address(RVA = "0x5264E0", Offset = "0x5256E0", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B2C")]
	public float GetZoomFactor(Vector3 position, Camera camera) { }

	[Address(RVA = "0x526410", Offset = "0x525610", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B2B")]
	public float GetZoomFactor(Vector3 position) { }

	[Address(RVA = "0x5265B0", Offset = "0x5257B0", Length = "0x9AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "set_ScaleDragAxisIndexUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "set_ScaleDragAxisIndexRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "RegisterScalerHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_ScaleDragAxisIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoHandleId), Member = "get_MidScaleCap", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Token(Token = "0x6000B33")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x526F60", Offset = "0x526160", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "get_Position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoUniformScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B36")]
	public virtual void OnGizmoAttemptHandleDragBegin(int handleId) { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B32")]
	public virtual void OnGizmoEnabled() { }

	[Address(RVA = "0x527100", Offset = "0x526300", Length = "0x3BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "GetRenderSortedSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoLineSlider3D>))]
	[Calls(Type = typeof(GizmoScaleGuide), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ScaleGizmo), Member = "PlaceDblSlidersInSliderPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "get_NumRenderCameras", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000B35")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x5274C0", Offset = "0x5266C0", Length = "0x709")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(ScaleGizmo), Member = "PlaceDblSlidersInSliderPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B34")]
	public virtual void OnGizmoUpdateBegin() { }

	[Address(RVA = "0x527BD0", Offset = "0x526DD0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B2D")]
	public bool OwnsHandle(int handleId) { }

	[Address(RVA = "0x527C60", Offset = "0x526E60", Length = "0x108")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B37")]
	private void PlaceDblSlidersInSliderPlanes(Camera camera) { }

	[Address(RVA = "0x5288A0", Offset = "0x527AA0", Length = "0x6D")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B22")]
	public void set_SharedHotkeys(ScaleGizmoHotkeys value) { }

	[Address(RVA = "0x528910", Offset = "0x527B10", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScaleGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x6000B26")]
	public void set_SharedLookAndFeel3D(ScaleGizmoLookAndFeel3D value) { }

	[Address(RVA = "0x528940", Offset = "0x527B40", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScaleGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Token(Token = "0x6000B24")]
	public void set_SharedSettings3D(ScaleGizmoSettings3D value) { }

	[Address(RVA = "0x528970", Offset = "0x527B70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2A")]
	public void set_UseMultiAxisScaleModeHotkey(bool value) { }

	[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B28")]
	public void set_UseSnapEnableHotkey(bool value) { }

	[Address(RVA = "0x527D70", Offset = "0x526F70", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSlider), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2E")]
	public void SetAxesLinesHoverable(bool hoverable) { }

	[Address(RVA = "0x527E10", Offset = "0x527010", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B30")]
	public void SetMultiAxisScaleMode(GizmoMultiAxisScaleMode scaleMode) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B31")]
	public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects) { }

	[Address(RVA = "0x527EC0", Offset = "0x5270C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B2F")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x527F20", Offset = "0x527120", Length = "0x34B")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B38")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x528270", Offset = "0x527470", Length = "0x305")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleGizmoSettings3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000B39")]
	private void SetupSharedSettings() { }

}

