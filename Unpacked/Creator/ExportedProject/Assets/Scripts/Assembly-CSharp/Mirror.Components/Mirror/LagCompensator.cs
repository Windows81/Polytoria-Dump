namespace Mirror;

[AddComponentMenu("Network/ Lag Compensation/ Lag Compensator")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/manual/general/lag-compensation")]
[Token(Token = "0x200001F")]
public class LagCompensator : NetworkBehaviour
{
	[FieldOffset(Offset = "0x68")]
	[Header("Components")]
	[Token(Token = "0x400008D")]
	[Tooltip("The collider to keep a history of.")]
	public Collider trackedCollider; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Header("Settings")]
	[Token(Token = "0x400008E")]
	public LagCompensationSettings lagCompensationSettings; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400008F")]
	private double lastCaptureTime; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000090")]
	private readonly Queue<KeyValuePair`2<Double, Capture3D>> history; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Header("Debugging")]
	[Token(Token = "0x4000091")]
	public Color historyColor; //Field offset: 0x88

	[Address(RVA = "0x1212950", Offset = "0x1211B50", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LagCompensationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000097")]
	public LagCompensator() { }

	[Address(RVA = "0x1211CB0", Offset = "0x1210EB0", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Bounds), Member = "ClosestPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x6000095")]
	public override bool BoundsCheck(NetworkConnectionToClient viewer, Vector3 hitPoint, float toleranceDistance, out float distance, out Vector3 nearest) { }

	[Address(RVA = "0x1211F30", Offset = "0x1211130", Length = "0x1CC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(Collider), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(LagCompensation), Member = "Insert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<KeyValuePair`2<Double, T>>", typeof(int), typeof(double), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x6000092")]
	protected override void Capture() { }

	[Address(RVA = "0x1212100", Offset = "0x1211300", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LagCompensation), Member = "DrawGizmos", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<KeyValuePair`2<Double, T>>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000093")]
	protected override void OnDrawGizmos() { }

	[Address(RVA = "0x1212160", Offset = "0x1211360", Length = "0x39A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(float), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(BoxCollider), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x6000096")]
	public override bool RaycastCheck(NetworkConnectionToClient viewer, Vector3 originPoint, Vector3 hitPoint, float tolerancePercent, int layerMask, out RaycastHit hit) { }

	[Address(RVA = "0x1212500", Offset = "0x1211700", Length = "0x33C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "get_rtt", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "get_bufferTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(LagCompensation), Member = "EstimateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(LagCompensation), Member = "Sample", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<KeyValuePair`2<Double, T>>", typeof(double), typeof(double), "T&", "T&", typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x6000094")]
	public override bool Sample(NetworkConnectionToClient viewer, out Capture3D sample) { }

	[Address(RVA = "0x1212840", Offset = "0x1211A40", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x6000091")]
	protected override void Update() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000098")]
	public virtual bool Weaved() { }

}

