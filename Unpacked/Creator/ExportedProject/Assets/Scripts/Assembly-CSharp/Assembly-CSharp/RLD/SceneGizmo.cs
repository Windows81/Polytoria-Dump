namespace RLD;

[Token(Token = "0x2000098")]
public class SceneGizmo : GizmoBehaviour, ISceneGizmo
{
	[CompilerGenerated]
	[Token(Token = "0x2000099")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400021A")]
		public Vector3 cameraPos; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055E")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0x3E4E50", Offset = "0x3E4050", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoCap3D), Member = "get_Position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600055F")]
		internal int <OnGizmoRender>b__0(SceneGizmoCap h0, SceneGizmoCap h1) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000213")]
	private SceneGizmoCamPrjSwitchLabel _camPrjSwitchLabel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000214")]
	private SceneGizmoMidCap _midAxisHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000215")]
	private SceneGizmoAxisCap[] _axesHandles; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000216")]
	private List<SceneGizmoCap> _renderSortedHandles; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000217")]
	private RTSceneGizmoCamera _sceneGizmoCamera; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000218")]
	private SceneGizmoLookAndFeel _lookAndFeel; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000219")]
	private SceneGizmoLookAndFeel _sharedLookAndFeel; //Field offset: 0x50

	[Token(Token = "0x170001A0")]
	public SceneGizmoLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x3E4DB0", Offset = "0x3E3FB0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000557")]
		 get { } //Length: 17
	}

	[Token(Token = "0x1700019E")]
	public override Gizmo OwnerGizmo
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000555")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700019F")]
	public override Camera SceneCamera
	{
		[Address(RVA = "0x3E4DD0", Offset = "0x3E3FD0", Length = "0x1B")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000556")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700019D")]
	public RTSceneGizmoCamera SceneGizmoCamera
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000554")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A1")]
	public SceneGizmoLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000558")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000559")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3E4CD0", Offset = "0x3E3ED0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600055D")]
	public SceneGizmo() { }

	[Address(RVA = "0x3E4DB0", Offset = "0x3E3FB0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000557")]
	public SceneGizmoLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000555")]
	public override Gizmo get_OwnerGizmo() { }

	[Address(RVA = "0x3E4DD0", Offset = "0x3E3FD0", Length = "0x1B")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000556")]
	public override Camera get_SceneCamera() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000554")]
	public RTSceneGizmoCamera get_SceneGizmoCamera() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000558")]
	public SceneGizmoLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x3E3FB0", Offset = "0x3E31B0", Length = "0xA97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Priority), Member = "MakeHighest", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add2DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Gizmo), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GizmoHandle))]
	[Calls(Type = typeof(QuadShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(AxisDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHandlePickedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(ISceneGizmoCamViewportUpdater)}, ReturnType = typeof(RTSceneGizmoCamera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600055A")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x3E4A70", Offset = "0x3E3C70", Length = "0x25D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600055C")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x3E4A50", Offset = "0x3E3C50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600055B")]
	public virtual void OnGUI() { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000559")]
	public void set_SharedLookAndFeel(SceneGizmoLookAndFeel value) { }

}

