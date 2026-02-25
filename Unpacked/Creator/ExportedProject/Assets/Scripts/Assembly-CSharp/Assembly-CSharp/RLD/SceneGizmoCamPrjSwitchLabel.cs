namespace RLD;

[Token(Token = "0x2000095")]
public class SceneGizmoCamPrjSwitchLabel
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400020E")]
	private SceneGizmo _sceneGizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020F")]
	private GizmoHandle _handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000210")]
	private QuadShape2D _labelQuad; //Field offset: 0x20

	[Token(Token = "0x17000199")]
	public GizmoHandle Handle
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000544")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700019A")]
	public int Id
	{
		[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000545")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x3E2220", Offset = "0x3E1420", Length = "0x191")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(QuadShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Gizmo), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GizmoHandle))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add2DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHandlePickedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000546")]
	public SceneGizmoCamPrjSwitchLabel(SceneGizmo sceneGizmo) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000544")]
	public GizmoHandle get_Handle() { }

	[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000545")]
	public int get_Id() { }

	[Address(RVA = "0x3E1F00", Offset = "0x3E1100", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTFocusCamera), Member = "PerformProjectionSwitch", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054A")]
	private void OnGizmoHandlePicked(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3E1F90", Offset = "0x3E1190", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000548")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x3E1840", Offset = "0x3E0A40", Length = "0x6B7")]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AnimationCurve))]
	[Calls(Type = typeof(GUI), Member = "DrawTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectEx), Member = "InvertScreenY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectEx), Member = "PlaceBelowCenterHrz", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectEx), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GUIEx), Member = "PushColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RTFocusCamera), Member = "get_PrjSwitchProgress", ReturnType = typeof(float))]
	[Calls(Type = typeof(RTFocusCamera), Member = "get_PrjSwitchTransitionType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(GUIEx), Member = "PopColor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "get_CamPerspModeLabelTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "get_CamOrthoModeLabelTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(RTFocusCamera), Member = "get_IsDoingProjectionSwitch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000547")]
	public void OnGUI() { }

	[Address(RVA = "0x3E1FE0", Offset = "0x3E11E0", Length = "0x23B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TexturePool), Member = "get_CamOrthoMode", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(TexturePool), Member = "get_CamPerspMode", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(RectEx), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = "CalculateMaxPrjSwitchLabelRectSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectEx), Member = "PlaceBelowCenterHrz", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(QuadShape2D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000549")]
	private void UpdateTransform() { }

}

