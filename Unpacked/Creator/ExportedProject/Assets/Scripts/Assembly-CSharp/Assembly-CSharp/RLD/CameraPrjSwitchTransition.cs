namespace RLD;

[Token(Token = "0x2000134")]
public class CameraPrjSwitchTransition
{
	[CompilerGenerated]
	[Token(Token = "0x2000136")]
	private sealed class <DoTransition>d__41 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400058A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400058B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400058C")]
		public CameraPrjSwitchTransition <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400058D")]
		private float <frustumHeight>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400058E")]
		private float <targetFOV>5__3; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400058F")]
		private float <invDuration>5__4; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000590")]
		private float <fovSpeed>5__5; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000591")]
		private Transform <_targetTransform>5__6; //Field offset: 0x38

		[Token(Token = "0x170004EA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E7B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170004EB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000E7D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E78")]
		public <DoTransition>d__41(int <>1__state) { }

		[Address(RVA = "0x54E410", Offset = "0x54D610", Length = "0x580")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Camera), Member = "set_orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028EDD0")]
		[Calls(Type = typeof(CameraEx), Member = "GetOrthoFOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
		[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000E7A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54E9A0", Offset = "0x54DBA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000E7C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E79")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000135")]
	internal enum Type
	{
		None = 0,
		ToOrtho = 1,
		ToPerspective = 2,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057A")]
	private CameraProjectionSwitchBeginHandler TransitionBegin; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057B")]
	private CameraProjectionSwitchUpdateHandler TransitionUpdate; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057C")]
	private CameraProjectionSwitchBeginHandler TransitionEnd; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400057D")]
	private IEnumerator _transitionCrtn; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400057E")]
	private MonoBehaviour _targetMono; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400057F")]
	private Camera _targetCamera; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000580")]
	private float _camFieldOfView; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000581")]
	private Vector3 _camFocusPoint; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000582")]
	private Vector3 _camRestorePosition; //Field offset: 0x50
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000583")]
	private Type _transitionType; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000584")]
	private float _durationInSeconds; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000585")]
	private float _progress; //Field offset: 0x64

	[Token(Token = "0x14000017")]
	public event CameraProjectionSwitchBeginHandler TransitionBegin
	{
		[Address(RVA = "0x53BE80", Offset = "0x53B080", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E62")]
		 add { } //Length: 158
		[Address(RVA = "0x53C090", Offset = "0x53B290", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E63")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000019")]
	public event CameraProjectionSwitchBeginHandler TransitionEnd
	{
		[Address(RVA = "0x53BF20", Offset = "0x53B120", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E66")]
		 add { } //Length: 158
		[Address(RVA = "0x53C130", Offset = "0x53B330", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E67")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000018")]
	public event CameraProjectionSwitchUpdateHandler TransitionUpdate
	{
		[Address(RVA = "0x53BFC0", Offset = "0x53B1C0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E64")]
		 add { } //Length: 158
		[Address(RVA = "0x53C1D0", Offset = "0x53B3D0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000E65")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170004E7")]
	public float CamFieldOfView
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E70")]
		 get { } //Length: 6
		[Address(RVA = "0x53C270", Offset = "0x53B470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E71")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170004E8")]
	public Vector3 CamFocusPoint
	{
		[Address(RVA = "0x3B87C0", Offset = "0x3B79C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E72")]
		 get { } //Length: 19
		[Address(RVA = "0x53C290", Offset = "0x53B490", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E73")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170004E5")]
	public float DurationInSeconds
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E6D")]
		 get { } //Length: 6
		[Address(RVA = "0x53C2B0", Offset = "0x53B4B0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000E6E")]
		 set { } //Length: 31
	}

	[Token(Token = "0x170004E9")]
	public bool IsActive
	{
		[Address(RVA = "0x53C070", Offset = "0x53B270", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E74")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170004E6")]
	public float Progress
	{
		[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E6F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004E3")]
	public Camera TargetCamera
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E6A")]
		 get { } //Length: 5
		[Address(RVA = "0x53C2D0", Offset = "0x53B4D0", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000E6B")]
		 set { } //Length: 115
	}

	[Token(Token = "0x170004E2")]
	public MonoBehaviour TargetMono
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E68")]
		 get { } //Length: 95
		[Address(RVA = "0x53C350", Offset = "0x53B550", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000E69")]
		 set { } //Length: 115
	}

	[Token(Token = "0x170004E4")]
	public Type TransitionType
	{
		[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E6C")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x53BE60", Offset = "0x53B060", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E77")]
	public CameraPrjSwitchTransition() { }

	[Address(RVA = "0x53BE80", Offset = "0x53B080", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E62")]
	public void add_TransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x53BF20", Offset = "0x53B120", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E66")]
	public void add_TransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x53BFC0", Offset = "0x53B1C0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E64")]
	public void add_TransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	[Address(RVA = "0x53BC60", Offset = "0x53AE60", Length = "0x183")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000E75")]
	public void Begin() { }

	[Address(RVA = "0x53BDF0", Offset = "0x53AFF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoTransition>d__41))]
	[Token(Token = "0x6000E76")]
	private IEnumerator DoTransition() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E70")]
	public float get_CamFieldOfView() { }

	[Address(RVA = "0x3B87C0", Offset = "0x3B79C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E72")]
	public Vector3 get_CamFocusPoint() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E6D")]
	public float get_DurationInSeconds() { }

	[Address(RVA = "0x53C070", Offset = "0x53B270", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E74")]
	public bool get_IsActive() { }

	[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E6F")]
	public float get_Progress() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E6A")]
	public Camera get_TargetCamera() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E68")]
	public MonoBehaviour get_TargetMono() { }

	[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E6C")]
	public Type get_TransitionType() { }

	[Address(RVA = "0x53C090", Offset = "0x53B290", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E63")]
	public void remove_TransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x53C130", Offset = "0x53B330", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E67")]
	public void remove_TransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x53C1D0", Offset = "0x53B3D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000E65")]
	public void remove_TransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	[Address(RVA = "0x53C270", Offset = "0x53B470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E71")]
	public void set_CamFieldOfView(float value) { }

	[Address(RVA = "0x53C290", Offset = "0x53B490", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E73")]
	public void set_CamFocusPoint(Vector3 value) { }

	[Address(RVA = "0x53C2B0", Offset = "0x53B4B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000E6E")]
	public void set_DurationInSeconds(float value) { }

	[Address(RVA = "0x53C2D0", Offset = "0x53B4D0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E6B")]
	public void set_TargetCamera(Camera value) { }

	[Address(RVA = "0x53C350", Offset = "0x53B550", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000E69")]
	public void set_TargetMono(MonoBehaviour value) { }

}

