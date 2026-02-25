namespace RLD;

[Token(Token = "0x2000096")]
public abstract class SceneGizmoCap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000211")]
	protected SceneGizmo _sceneGizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000212")]
	protected GizmoCap3D _cap; //Field offset: 0x18

	[Token(Token = "0x1700019B")]
	public int HandleId
	{
		[Address(RVA = "0x3E2690", Offset = "0x3E1890", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600054B")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700019C")]
	public Vector3 Position
	{
		[Address(RVA = "0x3E26B0", Offset = "0x3E18B0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoCap3D), Member = "get_Position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600054C")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x3E25E0", Offset = "0x3E17E0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600054D")]
	public SceneGizmoCap(SceneGizmo sceneGizmo, int capHandleId) { }

	[Address(RVA = "0x3E2690", Offset = "0x3E1890", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600054B")]
	public int get_HandleId() { }

	[Address(RVA = "0x3E26B0", Offset = "0x3E18B0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "get_Position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054C")]
	public Vector3 get_Position() { }

	[Token(Token = "0x600054F")]
	public abstract void Render(Camera camera) { }

	[Address(RVA = "0x3E25C0", Offset = "0x3E17C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054E")]
	public void SetHoverable(bool isHoverable) { }

}

