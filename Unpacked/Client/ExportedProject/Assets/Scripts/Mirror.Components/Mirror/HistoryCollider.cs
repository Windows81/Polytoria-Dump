namespace Mirror;

[AddComponentMenu("Network/ Lag Compensation/ History Collider")]
[DisallowMultipleComponent]
[Token(Token = "0x200001D")]
public class HistoryCollider : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Header("Components")]
	[Token(Token = "0x4000081")]
	[Tooltip("The object's actual collider. We need to know where it is, and how large it is.")]
	public Collider actualCollider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000082")]
	[Tooltip("The helper collider that the history bounds are projected onto.\nNeeds to be added to a child GameObject to counter-rotate an axis aligned Bounding Box onto it.\nThis is only used by this component.")]
	public BoxCollider boundsCollider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Header("History")]
	[Token(Token = "0x4000083")]
	[Tooltip("Keep this many past bounds in the buffer. The larger this is, the further we can raycast into the past.\nMaximum time := historyAmount * captureInterval")]
	public int boundsLimit; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000084")]
	[Tooltip("Gather N bounds at a time into a bucket for faster encapsulation. A factor of 2 will be twice as fast, etc.")]
	public int boundsPerBucket; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000085")]
	[Tooltip("Capture bounds every 'captureInterval' seconds. Larger values will require fewer computations, but may not capture every small move.")]
	public float captureInterval; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000086")]
	private double lastCaptureTime; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Header("Debug")]
	[Token(Token = "0x4000087")]
	public Color historyColor; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000088")]
	public Color currentColor; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000089")]
	protected HistoryBounds history; //Field offset: 0x68

	[Address(RVA = "0x1211C70", Offset = "0x1210E70", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	public HistoryCollider() { }

	[Address(RVA = "0x1211500", Offset = "0x1210700", Length = "0x21C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HistoryBounds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	protected override void Awake() { }

	[Address(RVA = "0x1211720", Offset = "0x1210920", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collider), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(HistoryBounds), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000087")]
	protected override void CaptureBounds() { }

	[Address(RVA = "0x1211780", Offset = "0x1210980", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000086")]
	protected override void FixedUpdate() { }

	[Address(RVA = "0x1211830", Offset = "0x1210A30", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HistoryBounds), Member = "get_total", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Gizmos), Member = "DrawWireCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000089")]
	protected override void OnDrawGizmos() { }

	[Address(RVA = "0x12119B0", Offset = "0x1210BB0", Length = "0x2B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(BoxCollider), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxCollider), Member = "set_center", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(HistoryBounds), Member = "get_total", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000088")]
	protected override void ProjectBounds() { }

}

