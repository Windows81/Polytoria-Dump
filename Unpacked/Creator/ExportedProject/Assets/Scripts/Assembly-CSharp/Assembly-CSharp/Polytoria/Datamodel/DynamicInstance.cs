namespace Polytoria.Datamodel;

[Token(Token = "0x2000316")]
public class DynamicInstance : Instance
{
	[Token(Token = "0x4000C07")]
	private const float MIN_SIZE = 0.01; //Field offset: 0x0
	[FieldOffset(Offset = "0xF8")]
	[Range(0.01, 1)]
	[Token(Token = "0x4000BFA")]
	public float transformSyncInterval; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Range(0, 2)]
	[Token(Token = "0x4000BFB")]
	public float positionThreshold; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Range(0, 2)]
	[Token(Token = "0x4000BFC")]
	public float rotationThreshold; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Range(0, 2)]
	[Token(Token = "0x4000BFD")]
	public float scaleThreshold; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000BFE")]
	private Rigidbody _rb; //Field offset: 0x108
	[CompilerGenerated]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000BFF")]
	private SyncMode <SyncMode>k__BackingField; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x4000C00")]
	private bool syncVelocity; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000C01")]
	private float velocitySensitivity; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	[Token(Token = "0x4000C02")]
	private bool syncAngularVelocity; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000C03")]
	private float angularVelocitySensitivity; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000C04")]
	protected float timeAlive; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000C05")]
	private bool first; //Field offset: 0x128
	[FieldOffset(Offset = "0x129")]
	[Token(Token = "0x4000C06")]
	private bool requestedTransform; //Field offset: 0x129
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C08")]
	private double lastServerSendTime; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SyncVar(hook = "OnVelocityChanged")]
	[Token(Token = "0x4000C09")]
	private Vector3 _velocity; //Field offset: 0x138
	[FieldOffset(Offset = "0x144")]
	[SyncVar(hook = "OnAngularVelocityChanged")]
	[Token(Token = "0x4000C0A")]
	private Vector3 _angularVelocity; //Field offset: 0x144
	[FieldOffset(Offset = "0x150")]
	[SyncVar(hook = "OnIsKinematicChanged")]
	[Token(Token = "0x4000C0B")]
	private bool _isKinematic; //Field offset: 0x150
	[FieldOffset(Offset = "0x151")]
	[SyncVar(hook = "OnUseGravityChanged")]
	[Token(Token = "0x4000C0C")]
	private bool _useGravity; //Field offset: 0x151
	[FieldOffset(Offset = "0x154")]
	[SyncVar(hook = "OnDragChanged")]
	[Token(Token = "0x4000C0D")]
	private float _drag; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[SyncVar(hook = "OnAngularDragChanged")]
	[Token(Token = "0x4000C0E")]
	private float _angularDrag; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000C0F")]
	private ClientSyncState previousValue; //Field offset: 0x15C
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x4000C10")]
	private Vector3 lastPos; //Field offset: 0x184
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000C11")]
	private Vector3 lastSize; //Field offset: 0x190
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000C12")]
	private Quaternion lastRot; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x4000C13")]
	private Vector3 serverPosition; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000C14")]
	private Vector3 serverSize; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4000C15")]
	private Quaternion serverRotation; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000C16")]
	private bool isDirty; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D5")]
	[Token(Token = "0x4000C17")]
	private bool isChildOfPlayerTool; //Field offset: 0x1D5
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000C18")]
	private Players players; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000C19")]
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__velocity; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000C1A")]
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__angularVelocity; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000C1B")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate__isKinematic; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000C1C")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate__useGravity; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000C1D")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate__drag; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000C1E")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate__angularDrag; //Field offset: 0x208

	[Token(Token = "0x17000913")]
	protected override bool DoTransformSync
	{
		[Address(RVA = "0x40D0D0", Offset = "0x40C2D0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001CD1")]
		 get { } //Length: 131
	}

	[Token(Token = "0x1700091D")]
	public Vector3 Forward
	{
		[Address(RVA = "0x40D160", Offset = "0x40C360", Length = "0x3B")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Forward", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE4")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000920")]
	private bool IgnoreSync
	{
		[Address(RVA = "0x40D1A0", Offset = "0x40C3A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
		[Token(Token = "0x6001CE7")]
		private get { } //Length: 7
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000917")]
	public Vector3 LocalPosition
	{
		[Address(RVA = "0x40D1B0", Offset = "0x40C3B0", Length = "0x3B")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalPosition", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD8")]
		 get { } //Length: 59
		[Address(RVA = "0x40D4C0", Offset = "0x40C6C0", Length = "0x35")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD9")]
		 set { } //Length: 53
	}

	[Archivable]
	[Token(Token = "0x1700091C")]
	public Quaternion LocalQuaternion
	{
		[Address(RVA = "0x40D1F0", Offset = "0x40C3F0", Length = "0x33")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalQuaternion", ReturnType = typeof(Quaternion))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE2")]
		 get { } //Length: 51
		[Address(RVA = "0x40D500", Offset = "0x40C700", Length = "0x2C")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE3")]
		 set { } //Length: 44
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000918")]
	public Vector3 LocalRotation
	{
		[Address(RVA = "0x40D230", Offset = "0x40C430", Length = "0x3B")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalRotation", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDA")]
		 get { } //Length: 59
		[Address(RVA = "0x40D530", Offset = "0x40C730", Length = "0x35")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDB")]
		 set { } //Length: 53
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700091A")]
	public Vector3 LocalSize
	{
		[Address(RVA = "0x40D270", Offset = "0x40C470", Length = "0x3B")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalSize", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDE")]
		 get { } //Length: 59
		[Address(RVA = "0x40D570", Offset = "0x40C770", Length = "0x35")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDF")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000926")]
	public float Network_angularDrag
	{
		[Address(RVA = "0x40D2B0", Offset = "0x40C4B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D1B")]
		 get { } //Length: 9
		[Address(RVA = "0x40D5B0", Offset = "0x40C7B0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001D1C")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000922")]
	public Vector3 Network_angularVelocity
	{
		[Address(RVA = "0x40D2C0", Offset = "0x40C4C0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D13")]
		 get { } //Length: 25
		[Address(RVA = "0x40D620", Offset = "0x40C820", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
		[Token(Token = "0x6001D14")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000925")]
	public float Network_drag
	{
		[Address(RVA = "0x40D2E0", Offset = "0x40C4E0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D19")]
		 get { } //Length: 9
		[Address(RVA = "0x40D6A0", Offset = "0x40C8A0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001D1A")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000923")]
	public bool Network_isKinematic
	{
		[Address(RVA = "0x40D2F0", Offset = "0x40C4F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D15")]
		 get { } //Length: 8
		[Address(RVA = "0x40D710", Offset = "0x40C910", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6001D16")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000924")]
	public bool Network_useGravity
	{
		[Address(RVA = "0x40D300", Offset = "0x40C500", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D17")]
		 get { } //Length: 8
		[Address(RVA = "0x40D780", Offset = "0x40C980", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6001D18")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000921")]
	public Vector3 Network_velocity
	{
		[Address(RVA = "0x40D310", Offset = "0x40C510", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D11")]
		 get { } //Length: 25
		[Address(RVA = "0x40D7F0", Offset = "0x40C9F0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
		[Token(Token = "0x6001D12")]
		 set { } //Length: 122
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000915")]
	public Vector3 Position
	{
		[Address(RVA = "0x40D330", Offset = "0x40C530", Length = "0x3B")]
		[CalledBy(Type = typeof(Part), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Position", ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD4")]
		 get { } //Length: 59
		[Address(RVA = "0x40D870", Offset = "0x40CA70", Length = "0x35")]
		[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD5")]
		 set { } //Length: 53
	}

	[Archivable]
	[Token(Token = "0x1700091B")]
	public Quaternion Quaternion
	{
		[Address(RVA = "0x40D370", Offset = "0x40C570", Length = "0x33")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Quaternion", ReturnType = typeof(Quaternion))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE0")]
		 get { } //Length: 51
		[Address(RVA = "0x40D8B0", Offset = "0x40CAB0", Length = "0x2C")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE1")]
		 set { } //Length: 44
	}

	[Token(Token = "0x1700091E")]
	public Vector3 Right
	{
		[Address(RVA = "0x40D3B0", Offset = "0x40C5B0", Length = "0x3B")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Right", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE5")]
		 get { } //Length: 59
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000916")]
	public Vector3 Rotation
	{
		[Address(RVA = "0x40D3F0", Offset = "0x40C5F0", Length = "0x3B")]
		[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Rotation", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD6")]
		 get { } //Length: 59
		[Address(RVA = "0x40D8E0", Offset = "0x40CAE0", Length = "0x35")]
		[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD7")]
		 set { } //Length: 53
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000919")]
	public Vector3 Size
	{
		[Address(RVA = "0x40D430", Offset = "0x40C630", Length = "0x3B")]
		[CalledBy(Type = typeof(Environment), Member = "CreateExplosion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(bool), typeof(DynValue), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Size", ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDC")]
		 get { } //Length: 59
		[Address(RVA = "0x40D920", Offset = "0x40CB20", Length = "0x163")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDD")]
		 set { } //Length: 355
	}

	[MoonSharpHidden]
	[Token(Token = "0x17000914")]
	public SyncMode SyncMode
	{
		[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CD2")]
		 get { } //Length: 7
		[Address(RVA = "0x40DA90", Offset = "0x40CC90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CD3")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700091F")]
	public Vector3 Up
	{
		[Address(RVA = "0x40D480", Offset = "0x40C680", Length = "0x3B")]
		[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Up", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE6")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x40CCB0", Offset = "0x40BEB0", Length = "0x1A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001D23")]
	private static DynamicInstance() { }

	[Address(RVA = "0x40CE60", Offset = "0x40C060", Length = "0x26B")]
	[CalledBy(Type = typeof(SunLight), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointLight), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Spotlight), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Model), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001D0E")]
	public DynamicInstance() { }

	[Address(RVA = "0x40BE60", Offset = "0x40B060", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "CheckIfChildOfPlayerTool", ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6001D0F")]
	private void <Awake>b__74_0() { }

	[Address(RVA = "0x409300", Offset = "0x408500", Length = "0x117")]
	[CalledBy(Type = typeof(Instance), Member = "UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnection), typeof(Transform), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Instance), Member = "InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CF2")]
	public void ApplyTransform() { }

	[Address(RVA = "0x409420", Offset = "0x408620", Length = "0xD7")]
	[CalledBy(Type = typeof(Text3D), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SunLight), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Game), Member = "add_GameLoadedLocally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "add__ParentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001CEE")]
	protected virtual void Awake() { }

	[Address(RVA = "0x409500", Offset = "0x408700", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CFA")]
	private void CacheTransform() { }

	[Address(RVA = "0x409590", Offset = "0x408790", Length = "0x1B9")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "<Awake>b__74_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = "DoLinkTool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "IsDescendantOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CF3")]
	public void CheckIfChildOfPlayerTool() { }

	[Address(RVA = "0x409750", Offset = "0x408950", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command(requiresAuthority = False)]
	[Token(Token = "0x6001D00")]
	private void CmdRequestTransform(NetworkConnectionToClient sender = null) { }

	[Address(RVA = "0x4098A0", Offset = "0x408AA0", Length = "0x157")]
	[CalledBy(Type = typeof(NPC), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointLight), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Spotlight), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CFB")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x409A00", Offset = "0x408C00", Length = "0x347")]
	[CalledBy(Type = typeof(Text3D), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Spotlight), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointLight), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SunLight), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D25")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x40D0D0", Offset = "0x40C2D0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CD1")]
	protected override bool get_DoTransformSync() { }

	[Address(RVA = "0x40D160", Offset = "0x40C360", Length = "0x3B")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Forward", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE4")]
	public Vector3 get_Forward() { }

	[Address(RVA = "0x40D1A0", Offset = "0x40C3A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Token(Token = "0x6001CE7")]
	private bool get_IgnoreSync() { }

	[Address(RVA = "0x40D1B0", Offset = "0x40C3B0", Length = "0x3B")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalPosition", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CD8")]
	public Vector3 get_LocalPosition() { }

	[Address(RVA = "0x40D1F0", Offset = "0x40C3F0", Length = "0x33")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalQuaternion", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE2")]
	public Quaternion get_LocalQuaternion() { }

	[Address(RVA = "0x40D230", Offset = "0x40C430", Length = "0x3B")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalRotation", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CDA")]
	public Vector3 get_LocalRotation() { }

	[Address(RVA = "0x40D270", Offset = "0x40C470", Length = "0x3B")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_LocalSize", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CDE")]
	public Vector3 get_LocalSize() { }

	[Address(RVA = "0x40D2B0", Offset = "0x40C4B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D1B")]
	public float get_Network_angularDrag() { }

	[Address(RVA = "0x40D2C0", Offset = "0x40C4C0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D13")]
	public Vector3 get_Network_angularVelocity() { }

	[Address(RVA = "0x40D2E0", Offset = "0x40C4E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D19")]
	public float get_Network_drag() { }

	[Address(RVA = "0x40D2F0", Offset = "0x40C4F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D15")]
	public bool get_Network_isKinematic() { }

	[Address(RVA = "0x40D300", Offset = "0x40C500", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D17")]
	public bool get_Network_useGravity() { }

	[Address(RVA = "0x40D310", Offset = "0x40C510", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D11")]
	public Vector3 get_Network_velocity() { }

	[Address(RVA = "0x40D330", Offset = "0x40C530", Length = "0x3B")]
	[CalledBy(Type = typeof(Part), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Position", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CD4")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x40D370", Offset = "0x40C570", Length = "0x33")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Quaternion", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE0")]
	public Quaternion get_Quaternion() { }

	[Address(RVA = "0x40D3B0", Offset = "0x40C5B0", Length = "0x3B")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Right", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE5")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x40D3F0", Offset = "0x40C5F0", Length = "0x3B")]
	[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Rotation", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CD6")]
	public Vector3 get_Rotation() { }

	[Address(RVA = "0x40D430", Offset = "0x40C630", Length = "0x3B")]
	[CalledBy(Type = typeof(Environment), Member = "CreateExplosion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(bool), typeof(DynValue), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Size", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CDC")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CD2")]
	public SyncMode get_SyncMode() { }

	[Address(RVA = "0x40D480", Offset = "0x40C680", Length = "0x3B")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "get_Up", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE6")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x409D50", Offset = "0x408F50", Length = "0x1E7")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "UpdateServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstance), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CF9")]
	private bool HasTransformChanged() { }

	[Address(RVA = "0x409F40", Offset = "0x409140", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "InverseTransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "InverseTransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D0A")]
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	[Address(RVA = "0x409FA0", Offset = "0x4091A0", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D08")]
	public Vector3 InverseTransformPoint(Vector3 point) { }

	[Address(RVA = "0x40A000", Offset = "0x409200", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "InverseTransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "InverseTransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D0C")]
	public Vector3 InverseTransformVector(Vector3 vector) { }

	[Address(RVA = "0x40A060", Offset = "0x409260", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicInstance), Member = "UserCode_CmdRequestTransform__NetworkConnectionToClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D20")]
	protected static void InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x40A190", Offset = "0x409390", Length = "0x1A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D1E")]
	protected static void InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x40A340", Offset = "0x409540", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D22")]
	protected static void InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x40A4D0", Offset = "0x4096D0", Length = "0x15F")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D04")]
	public void LookAt(DynamicInstance target) { }

	[Address(RVA = "0x40A630", Offset = "0x409830", Length = "0x135")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D03")]
	public void LookAt(Vector3 target) { }

	[Address(RVA = "0x40A770", Offset = "0x409970", Length = "0x100")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D02")]
	public void LookAt(Vector3 target, Vector3 worldUp) { }

	[Address(RVA = "0x40A880", Offset = "0x409A80", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CED")]
	private void OnAngularDragChanged(float _, float newValue) { }

	[Address(RVA = "0x40A940", Offset = "0x409B40", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE9")]
	private void OnAngularVelocityChanged(Vector3 _, Vector3 newValue) { }

	[Address(RVA = "0x40AA30", Offset = "0x409C30", Length = "0xC7")]
	[CalledBy(Type = typeof(Part), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "OnDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Game), Member = "remove_GameLoadedLocally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CF0")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x40AB00", Offset = "0x409D00", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CEC")]
	private void OnDragChanged(float _, float newValue) { }

	[Address(RVA = "0x40ABC0", Offset = "0x409DC0", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "RequestTransform", ReturnType = typeof(void))]
	[Token(Token = "0x6001CEF")]
	private void OnGameLoadedLocally() { }

	[Address(RVA = "0x40ACC0", Offset = "0x409EC0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CEA")]
	private void OnIsKinematicChanged(bool _, bool newValue) { }

	[Address(RVA = "0x40AD90", Offset = "0x409F90", Length = "0x1F")]
	[CalledBy(Type = typeof(NPC), Member = "OnStartClient", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Instance), Member = "OnStartClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "RequestTransform", ReturnType = typeof(void))]
	[Token(Token = "0x6001CF5")]
	public virtual void OnStartClient() { }

	[Address(RVA = "0x40ADB0", Offset = "0x409FB0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CEB")]
	private void OnUseGravityChanged(bool _, bool newValue) { }

	[Address(RVA = "0x40AE80", Offset = "0x40A080", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_linearVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE8")]
	private void OnVelocityChanged(Vector3 _, Vector3 newValue) { }

	[Address(RVA = "0x40AF70", Offset = "0x40A170", Length = "0x28F")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "OnGameLoadedLocally", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstance), Member = "OnStartClient", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001CF1")]
	private void RequestTransform() { }

	[Address(RVA = "0x40B260", Offset = "0x40A460", Length = "0x35")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D07")]
	public void Rotate(Vector3 eulerAngles) { }

	[Address(RVA = "0x40B200", Offset = "0x40A400", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "RotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "RotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D06")]
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[Address(RVA = "0x40B2A0", Offset = "0x40A4A0", Length = "0x1CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc(includeOwner = False)]
	[Token(Token = "0x6001CFF")]
	protected void RpcSyncTransform(Vector3 position, Quaternion rotation, Vector3 size) { }

	[Address(RVA = "0x40B470", Offset = "0x40A670", Length = "0x190")]
	[CalledBy(Type = typeof(SunLight), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointLight), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Spotlight), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001D24")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x40D4C0", Offset = "0x40C6C0", Length = "0x35")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CD9")]
	public void set_LocalPosition(Vector3 value) { }

	[Address(RVA = "0x40D500", Offset = "0x40C700", Length = "0x2C")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE3")]
	public void set_LocalQuaternion(Quaternion value) { }

	[Address(RVA = "0x40D530", Offset = "0x40C730", Length = "0x35")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CDB")]
	public void set_LocalRotation(Vector3 value) { }

	[Address(RVA = "0x40D570", Offset = "0x40C770", Length = "0x35")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_LocalSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CDF")]
	public void set_LocalSize(Vector3 value) { }

	[Address(RVA = "0x40D5B0", Offset = "0x40C7B0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001D1C")]
	public void set_Network_angularDrag(in float value) { }

	[Address(RVA = "0x40D620", Offset = "0x40C820", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Token(Token = "0x6001D14")]
	public void set_Network_angularVelocity(in Vector3 value) { }

	[Address(RVA = "0x40D6A0", Offset = "0x40C8A0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001D1A")]
	public void set_Network_drag(in float value) { }

	[Address(RVA = "0x40D710", Offset = "0x40C910", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6001D16")]
	public void set_Network_isKinematic(in bool value) { }

	[Address(RVA = "0x40D780", Offset = "0x40C980", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6001D18")]
	public void set_Network_useGravity(in bool value) { }

	[Address(RVA = "0x40D7F0", Offset = "0x40C9F0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Token(Token = "0x6001D12")]
	public void set_Network_velocity(in Vector3 value) { }

	[Address(RVA = "0x40D870", Offset = "0x40CA70", Length = "0x35")]
	[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CD5")]
	public void set_Position(Vector3 value) { }

	[Address(RVA = "0x40D8B0", Offset = "0x40CAB0", Length = "0x2C")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CE1")]
	public void set_Quaternion(Quaternion value) { }

	[Address(RVA = "0x40D8E0", Offset = "0x40CAE0", Length = "0x35")]
	[CalledBy(Type = typeof(Text3D), Member = "set_FaceCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CD7")]
	public void set_Rotation(Vector3 value) { }

	[Address(RVA = "0x40D920", Offset = "0x40CB20", Length = "0x163")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CDD")]
	public void set_Size(Vector3 value) { }

	[Address(RVA = "0x40DA90", Offset = "0x40CC90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CD3")]
	public void set_SyncMode(SyncMode value) { }

	[Address(RVA = "0x40B600", Offset = "0x40A800", Length = "0x1D5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendTargetRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnection), typeof(string), typeof(int), typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[TargetRpc]
	[Token(Token = "0x6001D01")]
	private void SetTransformTargetRpc(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size) { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CF4")]
	protected virtual void Start() { }

	[Address(RVA = "0x40B7E0", Offset = "0x40A9E0", Length = "0x454")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "UpdateTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "get_linearVelocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularVelocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(Rigidbody), Member = "get_useGravity", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CFC")]
	private void SyncPhysics() { }

	[Address(RVA = "0x40BC40", Offset = "0x40AE40", Length = "0xBB")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "SyncTransformRecursively", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "GetChildrenOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(DynamicInstance), Member = "UpdateTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "SyncTransformRecursively", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MoonSharpHidden]
	[Token(Token = "0x6001CFE")]
	public void SyncTransformRecursively() { }

	[Address(RVA = "0x40BD00", Offset = "0x40AF00", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D0B")]
	public Vector3 TransformDirection(Vector3 direction) { }

	[Address(RVA = "0x40BD60", Offset = "0x40AF60", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D09")]
	public Vector3 TransformPoint(Vector3 point) { }

	[Address(RVA = "0x40BDC0", Offset = "0x40AFC0", Length = "0x53")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "TransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "TransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D0D")]
	public Vector3 TransformVector(Vector3 vector) { }

	[Address(RVA = "0x40BE20", Offset = "0x40B020", Length = "0x35")]
	[CalledBy(Type = typeof(DynamicInstanceProxy), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D05")]
	public void Translate(Vector3 translation) { }

	[Address(RVA = "0x40C730", Offset = "0x40B930", Length = "0x26C")]
	[CalledBy(Type = typeof(Decal), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Part), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text3D), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DynamicInstance), Member = "UpdateTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "HasTransformChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DynamicInstance), Member = "UpdateClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF8")]
	protected override void Update() { }

	[Address(RVA = "0x40BE70", Offset = "0x40B070", Length = "0x3DA")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CF7")]
	private void UpdateClient() { }

	[Address(RVA = "0x40C250", Offset = "0x40B450", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicInstance), Member = "HasTransformChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicInstance), Member = "UpdateTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF6")]
	private void UpdateServer() { }

	[Address(RVA = "0x40C370", Offset = "0x40B570", Length = "0x3B7")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "UpdateServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstance), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicInstance), Member = "SyncTransformRecursively", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicInstance), Member = "SyncPhysics", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001CFD")]
	private void UpdateTransform() { }

	[Address(RVA = "0x40C9A0", Offset = "0x40BBA0", Length = "0x246")]
	[CalledBy(Type = typeof(DynamicInstance), Member = "InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendTargetRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnection), typeof(string), typeof(int), typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001D1F")]
	protected void UserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkConnectionToClient sender) { }

	[Address(RVA = "0x40CBF0", Offset = "0x40BDF0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D1D")]
	protected void UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(Vector3 position, Quaternion rotation, Vector3 size) { }

	[Address(RVA = "0x40CC60", Offset = "0x40BE60", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D21")]
	protected void UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D10")]
	public virtual bool Weaved() { }

}

