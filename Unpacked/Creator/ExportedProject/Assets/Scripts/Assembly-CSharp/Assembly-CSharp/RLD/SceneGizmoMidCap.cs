namespace RLD;

[Token(Token = "0x2000097")]
public class SceneGizmoMidCap : SceneGizmoCap
{

	[Address(RVA = "0x3E3E00", Offset = "0x3E3000", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHandlePickedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000550")]
	public SceneGizmoMidCap(SceneGizmo sceneGizmo) { }

	[Address(RVA = "0x3E3CE0", Offset = "0x3E2EE0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTFocusCamera), Member = "PerformProjectionSwitch", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000553")]
	private void OnGizmoHandlePicked(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3E3D70", Offset = "0x3E2F70", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000552")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x3E3DD0", Offset = "0x3E2FD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000551")]
	public virtual void Render(Camera camera) { }

}

