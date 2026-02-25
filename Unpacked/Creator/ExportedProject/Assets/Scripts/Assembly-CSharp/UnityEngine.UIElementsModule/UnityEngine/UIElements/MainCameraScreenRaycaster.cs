namespace UnityEngine.UIElements;

[Token(Token = "0x2000277")]
internal class MainCameraScreenRaycaster : CameraScreenRaycaster
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009BE")]
	private Camera[] singleCameraArray; //Field offset: 0x28

	[Address(RVA = "0x1C6FA90", Offset = "0x1C6EC90", Length = "0x5F")]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MainCameraScreenRaycaster), Member = "ResolveCamera", ReturnType = typeof(void))]
	[Token(Token = "0x600113D")]
	public MainCameraScreenRaycaster() { }

	[Address(RVA = "0x1C6F9B0", Offset = "0x1C6EBB0", Length = "0xCE")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "get_raycaster", ReturnType = typeof(IScreenRaycaster))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainCameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MainCameraScreenRaycaster), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600113F")]
	private void ResolveCamera() { }

	[Address(RVA = "0x1C6FA80", Offset = "0x1C6EC80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MainCameraScreenRaycaster), Member = "ResolveCamera", ReturnType = typeof(void))]
	[Token(Token = "0x600113E")]
	public virtual void Update() { }

}

