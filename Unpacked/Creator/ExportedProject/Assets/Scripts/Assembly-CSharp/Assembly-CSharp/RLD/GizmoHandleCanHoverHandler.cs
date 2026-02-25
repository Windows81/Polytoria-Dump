namespace RLD;

[Token(Token = "0x2000070")]
public sealed class GizmoHandleCanHoverHandler : MulticastDelegate
{

	[Address(RVA = "0x3CD4F0", Offset = "0x3CC6F0", Length = "0xA6")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600036F")]
	public GizmoHandleCanHoverHandler(object object, IntPtr method) { }

	[Address(RVA = "0x3CD470", Offset = "0x3CC670", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Token(Token = "0x6000371")]
	public override IAsyncResult BeginInvoke(int handleId, Gizmo ownerGizmo, GizmoHandleHoverData handleHoverData, YesNoAnswer answer, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000372")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000370")]
	public override void Invoke(int handleId, Gizmo ownerGizmo, GizmoHandleHoverData handleHoverData, YesNoAnswer answer) { }

}

