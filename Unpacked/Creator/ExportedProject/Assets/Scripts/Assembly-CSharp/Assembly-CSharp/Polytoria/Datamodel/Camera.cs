namespace Polytoria.Datamodel;

[Token(Token = "0x2000311")]
public class Camera : DynamicInstance
{
	[Token(Token = "0x4000BBA")]
	public static float sensitivityModifier; //Field offset: 0x0
	[Token(Token = "0x4000BBB")]
	public static Camera Instance; //Field offset: 0x8
	[Token(Token = "0x4000BBC")]
	public static LayerMask clipIgnoreLayers; //Field offset: 0x10
	[Token(Token = "0x4000BBD")]
	public static List<MeshRenderer> disableOnFirstPerson; //Field offset: 0x18
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000BBE")]
	private Camera cam; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BBF")]
	private Transform target; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BC0")]
	private float distance; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000BC1")]
	private float distanceLerp; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BC2")]
	private float xSpeed; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000BC3")]
	private float ySpeed; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000BC4")]
	private float yMinLimit; //Field offset: 0x230
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000BC5")]
	private float yMaxLimit; //Field offset: 0x234
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000BC6")]
	private float distanceMax; //Field offset: 0x238
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000BC7")]
	private float minDist; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000BC8")]
	private float maxDist; //Field offset: 0x240
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000BC9")]
	private bool clipThroughWalls; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000BCA")]
	private float scrollSensitivity; //Field offset: 0x248
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000BCB")]
	private float flySpeed; //Field offset: 0x24C
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000BCC")]
	private float fastFlySpeed; //Field offset: 0x250
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4000BCD")]
	private float freeLookSensitivity; //Field offset: 0x254
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000BCE")]
	private float x; //Field offset: 0x258
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4000BCF")]
	private float y; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000BD0")]
	private bool init; //Field offset: 0x260
	[FieldOffset(Offset = "0x261")]
	[Token(Token = "0x4000BD1")]
	private bool wasLocked; //Field offset: 0x261
	[FieldOffset(Offset = "0x262")]
	[Token(Token = "0x4000BD2")]
	private bool looking; //Field offset: 0x262
	[FieldOffset(Offset = "0x263")]
	[Token(Token = "0x4000BD3")]
	private bool locked; //Field offset: 0x263
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x4000BD4")]
	private bool wasFirstPerson; //Field offset: 0x264
	[CompilerGenerated]
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000BD5")]
	private CameraMode <Mode>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4000BD6")]
	private float <LerpSpeed>k__BackingField; //Field offset: 0x26C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000BD7")]
	private bool <FollowLerp>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	[FieldOffset(Offset = "0x271")]
	[Token(Token = "0x4000BD8")]
	private bool <CanLock>k__BackingField; //Field offset: 0x271
	[CompilerGenerated]
	[FieldOffset(Offset = "0x272")]
	[Token(Token = "0x4000BD9")]
	private bool <CtrlLocked>k__BackingField; //Field offset: 0x272
	[CompilerGenerated]
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000BDA")]
	private float <SensitivityMultiplier>k__BackingField; //Field offset: 0x274
	[CompilerGenerated]
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000BDB")]
	private Vector3 <PositionOffset>k__BackingField; //Field offset: 0x278
	[CompilerGenerated]
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000BDC")]
	private Vector3 <RotationOffset>k__BackingField; //Field offset: 0x284
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000BDD")]
	private int lastDisableFPCount; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000BDE")]
	private DynamicInstance followTargetInstance; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000BDF")]
	private Transform followTargetTransform; //Field offset: 0x2A0

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008FB")]
	public bool CanLock
	{
		[Address(RVA = "0x404EC0", Offset = "0x4040C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C67")]
		 get { } //Length: 8
		[Address(RVA = "0x4050E0", Offset = "0x4042E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C68")]
		 set { } //Length: 7
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008F5")]
	public bool ClipThroughWalls
	{
		[Address(RVA = "0x404ED0", Offset = "0x4040D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C5B")]
		 get { } //Length: 8
		[Address(RVA = "0x4050F0", Offset = "0x4042F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C5C")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170008FC")]
	public bool CtrlLocked
	{
		[Address(RVA = "0x404EE0", Offset = "0x4040E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C69")]
		 get { } //Length: 8
		[Address(RVA = "0x405100", Offset = "0x404300", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C6A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170008EF")]
	public float Distance
	{
		[Address(RVA = "0x404EF0", Offset = "0x4040F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C4F")]
		 get { } //Length: 9
		[Address(RVA = "0x405110", Offset = "0x404310", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C50")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170008EA")]
	private bool DoLerp
	{
		[Address(RVA = "0x404F00", Offset = "0x404100", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001C46")]
		private get { } //Length: 29
	}

	[Token(Token = "0x17000901")]
	protected virtual bool DoTransformSync
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C72")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170008F7")]
	public float FastFlySpeed
	{
		[Address(RVA = "0x404F50", Offset = "0x404150", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C5F")]
		 get { } //Length: 9
		[Address(RVA = "0x405150", Offset = "0x404350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C60")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170008F6")]
	public float FlySpeed
	{
		[Address(RVA = "0x404F60", Offset = "0x404160", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C5D")]
		 get { } //Length: 9
		[Address(RVA = "0x405160", Offset = "0x404360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C5E")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170008FA")]
	public bool FollowLerp
	{
		[Address(RVA = "0x404F70", Offset = "0x404170", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C65")]
		 get { } //Length: 8
		[Address(RVA = "0x405170", Offset = "0x404370", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C66")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000902")]
	public DynamicInstance FollowTarget
	{
		[Address(RVA = "0x404F80", Offset = "0x404180", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C75")]
		 get { } //Length: 8
		[Address(RVA = "0x405180", Offset = "0x404380", Length = "0x101")]
		[CalledBy(Type = typeof(CameraProxy), Member = "set_FollowTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C76")]
		 set { } //Length: 257
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008EC")]
	public float FOV
	{
		[Address(RVA = "0x404F20", Offset = "0x404120", Length = "0x20")]
		[CalledBy(Type = typeof(Player), Member = "set_Camera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraProxy), Member = "get_FOV", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C49")]
		 get { } //Length: 32
		[Address(RVA = "0x405120", Offset = "0x404320", Length = "0x21")]
		[CalledBy(Type = typeof(Player), Member = "<UpdateFov>b__232_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "<UpdateFov>b__232_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraProxy), Member = "set_FOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C4A")]
		 set { } //Length: 33
	}

	[Token(Token = "0x170008F8")]
	public float FreeLookSensitivity
	{
		[Address(RVA = "0x404F90", Offset = "0x404190", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C61")]
		 get { } //Length: 9
		[Address(RVA = "0x405290", Offset = "0x404490", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C62")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170008F2")]
	public float HorizontalSpeed
	{
		[Address(RVA = "0x404FA0", Offset = "0x4041A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C55")]
		 get { } //Length: 9
		[Address(RVA = "0x4052A0", Offset = "0x4044A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C56")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000900")]
	public bool IsFirstPerson
	{
		[Address(RVA = "0x404FB0", Offset = "0x4041B0", Length = "0x18")]
		[CalledBy(Type = typeof(Player), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraProxy), Member = "get_IsFirstPerson", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001C71")]
		 get { } //Length: 24
	}

	[Token(Token = "0x170008F9")]
	public float LerpSpeed
	{
		[Address(RVA = "0x404FD0", Offset = "0x4041D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C63")]
		 get { } //Length: 9
		[Address(RVA = "0x4052B0", Offset = "0x4044B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C64")]
		 set { } //Length: 9
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008F1")]
	public float MaxDistance
	{
		[Address(RVA = "0x404FE0", Offset = "0x4041E0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C53")]
		 get { } //Length: 9
		[Address(RVA = "0x4052C0", Offset = "0x4044C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C54")]
		 set { } //Length: 9
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008F0")]
	public float MinDistance
	{
		[Address(RVA = "0x404FF0", Offset = "0x4041F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C51")]
		 get { } //Length: 9
		[Address(RVA = "0x4052D0", Offset = "0x4044D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C52")]
		 set { } //Length: 9
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008EB")]
	public CameraMode Mode
	{
		[Address(RVA = "0x405000", Offset = "0x404200", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C47")]
		 get { } //Length: 7
		[Address(RVA = "0x4052E0", Offset = "0x4044E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C48")]
		 set { } //Length: 7
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008ED")]
	public bool Orthographic
	{
		[Address(RVA = "0x405040", Offset = "0x404240", Length = "0x20")]
		[CalledBy(Type = typeof(CameraProxy), Member = "get_Orthographic", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C4B")]
		 get { } //Length: 32
		[Address(RVA = "0x405320", Offset = "0x404520", Length = "0x21")]
		[CalledBy(Type = typeof(CameraProxy), Member = "set_Orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Camera), Member = "set_orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C4C")]
		 set { } //Length: 33
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008EE")]
	public float OrthographicSize
	{
		[Address(RVA = "0x405010", Offset = "0x404210", Length = "0x20")]
		[CalledBy(Type = typeof(CameraProxy), Member = "get_OrthographicSize", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C4D")]
		 get { } //Length: 32
		[Address(RVA = "0x4052F0", Offset = "0x4044F0", Length = "0x21")]
		[CalledBy(Type = typeof(CameraProxy), Member = "set_OrthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Camera), Member = "set_orthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C4E")]
		 set { } //Length: 33
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008FE")]
	public Vector3 PositionOffset
	{
		[Address(RVA = "0x405070", Offset = "0x404270", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C6D")]
		 get { } //Length: 25
		[Address(RVA = "0x405350", Offset = "0x404550", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C6E")]
		 set { } //Length: 22
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x170008FF")]
	public Vector3 RotationOffset
	{
		[Address(RVA = "0x405090", Offset = "0x404290", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C6F")]
		 get { } //Length: 25
		[Address(RVA = "0x405370", Offset = "0x404570", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C70")]
		 set { } //Length: 22
	}

	[Token(Token = "0x170008F4")]
	public float ScrollSensitivity
	{
		[Address(RVA = "0x4050B0", Offset = "0x4042B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C59")]
		 get { } //Length: 9
		[Address(RVA = "0x405390", Offset = "0x404590", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C5A")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170008FD")]
	public float SensitivityMultiplier
	{
		[Address(RVA = "0x4050C0", Offset = "0x4042C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C6B")]
		 get { } //Length: 9
		[Address(RVA = "0x4053A0", Offset = "0x4045A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001C6C")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170008F3")]
	public float VerticalSpeed
	{
		[Address(RVA = "0x4050D0", Offset = "0x4042D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C57")]
		 get { } //Length: 9
		[Address(RVA = "0x4053B0", Offset = "0x4045B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001C58")]
		 set { } //Length: 9
	}

	[Address(RVA = "0x404D40", Offset = "0x403F40", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C91")]
	private static Camera() { }

	[Address(RVA = "0x404DE0", Offset = "0x403FE0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicInstance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001C90")]
	public Camera() { }

	[Address(RVA = "0x402790", Offset = "0x401990", Length = "0x3E7")]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Camera), Member = "CalculateWallClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C83")]
	private void ApplyCameraTransform(Transform followTarget) { }

	[Address(RVA = "0x402B80", Offset = "0x401D80", Length = "0x24D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(LayerMask), Member = "GetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SettingsController), Member = "Load", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C73")]
	protected virtual void Awake() { }

	[Address(RVA = "0x402DD0", Offset = "0x401FD0", Length = "0x257")]
	[CalledBy(Type = typeof(Camera), Member = "ApplyCameraTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "Linecast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(RaycastHit&), typeof(int), typeof(QueryTriggerInteraction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001C85")]
	private void CalculateWallClipping(Transform followTarget) { }

	[Address(RVA = "0x403030", Offset = "0x402230", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C8E")]
	private static float ClampAngle(float angle, float min, float max) { }

	[Address(RVA = "0x403070", Offset = "0x402270", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C84")]
	private void ClampDistance() { }

	[Address(RVA = "0x404EC0", Offset = "0x4040C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C67")]
	public bool get_CanLock() { }

	[Address(RVA = "0x404ED0", Offset = "0x4040D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C5B")]
	public bool get_ClipThroughWalls() { }

	[Address(RVA = "0x404EE0", Offset = "0x4040E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C69")]
	public bool get_CtrlLocked() { }

	[Address(RVA = "0x404EF0", Offset = "0x4040F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C4F")]
	public float get_Distance() { }

	[Address(RVA = "0x404F00", Offset = "0x404100", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C46")]
	private bool get_DoLerp() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C72")]
	protected virtual bool get_DoTransformSync() { }

	[Address(RVA = "0x404F50", Offset = "0x404150", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C5F")]
	public float get_FastFlySpeed() { }

	[Address(RVA = "0x404F60", Offset = "0x404160", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C5D")]
	public float get_FlySpeed() { }

	[Address(RVA = "0x404F70", Offset = "0x404170", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C65")]
	public bool get_FollowLerp() { }

	[Address(RVA = "0x404F80", Offset = "0x404180", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C75")]
	public DynamicInstance get_FollowTarget() { }

	[Address(RVA = "0x404F20", Offset = "0x404120", Length = "0x20")]
	[CalledBy(Type = typeof(Player), Member = "set_Camera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraProxy), Member = "get_FOV", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C49")]
	public float get_FOV() { }

	[Address(RVA = "0x404F90", Offset = "0x404190", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C61")]
	public float get_FreeLookSensitivity() { }

	[Address(RVA = "0x404FA0", Offset = "0x4041A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C55")]
	public float get_HorizontalSpeed() { }

	[Address(RVA = "0x404FB0", Offset = "0x4041B0", Length = "0x18")]
	[CalledBy(Type = typeof(Player), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraProxy), Member = "get_IsFirstPerson", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C71")]
	public bool get_IsFirstPerson() { }

	[Address(RVA = "0x404FD0", Offset = "0x4041D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C63")]
	public float get_LerpSpeed() { }

	[Address(RVA = "0x404FE0", Offset = "0x4041E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C53")]
	public float get_MaxDistance() { }

	[Address(RVA = "0x404FF0", Offset = "0x4041F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C51")]
	public float get_MinDistance() { }

	[Address(RVA = "0x405000", Offset = "0x404200", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C47")]
	public CameraMode get_Mode() { }

	[Address(RVA = "0x405040", Offset = "0x404240", Length = "0x20")]
	[CalledBy(Type = typeof(CameraProxy), Member = "get_Orthographic", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C4B")]
	public bool get_Orthographic() { }

	[Address(RVA = "0x405010", Offset = "0x404210", Length = "0x20")]
	[CalledBy(Type = typeof(CameraProxy), Member = "get_OrthographicSize", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C4D")]
	public float get_OrthographicSize() { }

	[Address(RVA = "0x405070", Offset = "0x404270", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C6D")]
	public Vector3 get_PositionOffset() { }

	[Address(RVA = "0x405090", Offset = "0x404290", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C6F")]
	public Vector3 get_RotationOffset() { }

	[Address(RVA = "0x4050B0", Offset = "0x4042B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C59")]
	public float get_ScrollSensitivity() { }

	[Address(RVA = "0x4050C0", Offset = "0x4042C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C6B")]
	public float get_SensitivityMultiplier() { }

	[Address(RVA = "0x4050D0", Offset = "0x4042D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C57")]
	public float get_VerticalSpeed() { }

	[Address(RVA = "0x4030B0", Offset = "0x4022B0", Length = "0x33C")]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C81")]
	private void HandleCameraRotation() { }

	[Address(RVA = "0x4033F0", Offset = "0x4025F0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C80")]
	private void HandleCursorLocking() { }

	[Address(RVA = "0x4034B0", Offset = "0x4026B0", Length = "0x403")]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C7E")]
	private void HandleFirstPersonRendering() { }

	[Address(RVA = "0x403930", Offset = "0x402B30", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C88")]
	private void HandleFreeLook() { }

	[Address(RVA = "0x4038C0", Offset = "0x402AC0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C8A")]
	private void HandleFreeLookToggle() { }

	[Address(RVA = "0x403A50", Offset = "0x402C50", Length = "0x5FA")]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFree", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C87")]
	private void HandleFreeMovement() { }

	[Address(RVA = "0x404050", Offset = "0x403250", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C89")]
	private void HandleFreeZoom() { }

	[Address(RVA = "0x404180", Offset = "0x403380", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C7C")]
	private void HandleLockInput() { }

	[Address(RVA = "0x404200", Offset = "0x403400", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(EventSystem), Member = "IsPointerOverGameObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputService), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001C7D")]
	private float HandleScrollInput() { }

	[Address(RVA = "0x404300", Offset = "0x403500", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C82")]
	private void HandleScrollZoom(float scroll) { }

	[Address(RVA = "0x404320", Offset = "0x403520", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "UpdateFree", ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C78")]
	private void LateUpdate() { }

	[Address(RVA = "0x404360", Offset = "0x403560", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C8D")]
	private void OnDisable() { }

	[Address(RVA = "0x4050E0", Offset = "0x4042E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C68")]
	public void set_CanLock(bool value) { }

	[Address(RVA = "0x4050F0", Offset = "0x4042F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C5C")]
	public void set_ClipThroughWalls(bool value) { }

	[Address(RVA = "0x405100", Offset = "0x404300", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C6A")]
	public void set_CtrlLocked(bool value) { }

	[Address(RVA = "0x405110", Offset = "0x404310", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C50")]
	public void set_Distance(float value) { }

	[Address(RVA = "0x405150", Offset = "0x404350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C60")]
	public void set_FastFlySpeed(float value) { }

	[Address(RVA = "0x405160", Offset = "0x404360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C5E")]
	public void set_FlySpeed(float value) { }

	[Address(RVA = "0x405170", Offset = "0x404370", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C66")]
	public void set_FollowLerp(bool value) { }

	[Address(RVA = "0x405180", Offset = "0x404380", Length = "0x101")]
	[CalledBy(Type = typeof(CameraProxy), Member = "set_FollowTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C76")]
	public void set_FollowTarget(DynamicInstance value) { }

	[Address(RVA = "0x405120", Offset = "0x404320", Length = "0x21")]
	[CalledBy(Type = typeof(Player), Member = "<UpdateFov>b__232_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "<UpdateFov>b__232_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraProxy), Member = "set_FOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C4A")]
	public void set_FOV(float value) { }

	[Address(RVA = "0x405290", Offset = "0x404490", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C62")]
	public void set_FreeLookSensitivity(float value) { }

	[Address(RVA = "0x4052A0", Offset = "0x4044A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C56")]
	public void set_HorizontalSpeed(float value) { }

	[Address(RVA = "0x4052B0", Offset = "0x4044B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C64")]
	public void set_LerpSpeed(float value) { }

	[Address(RVA = "0x4052C0", Offset = "0x4044C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C54")]
	public void set_MaxDistance(float value) { }

	[Address(RVA = "0x4052D0", Offset = "0x4044D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C52")]
	public void set_MinDistance(float value) { }

	[Address(RVA = "0x4052E0", Offset = "0x4044E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C48")]
	public void set_Mode(CameraMode value) { }

	[Address(RVA = "0x405320", Offset = "0x404520", Length = "0x21")]
	[CalledBy(Type = typeof(CameraProxy), Member = "set_Orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "set_orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C4C")]
	public void set_Orthographic(bool value) { }

	[Address(RVA = "0x4052F0", Offset = "0x4044F0", Length = "0x21")]
	[CalledBy(Type = typeof(CameraProxy), Member = "set_OrthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C4E")]
	public void set_OrthographicSize(float value) { }

	[Address(RVA = "0x405350", Offset = "0x404550", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C6E")]
	public void set_PositionOffset(Vector3 value) { }

	[Address(RVA = "0x405370", Offset = "0x404570", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C70")]
	public void set_RotationOffset(Vector3 value) { }

	[Address(RVA = "0x405390", Offset = "0x404590", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C5A")]
	public void set_ScrollSensitivity(float value) { }

	[Address(RVA = "0x4053A0", Offset = "0x4045A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001C6C")]
	public void set_SensitivityMultiplier(float value) { }

	[Address(RVA = "0x4053B0", Offset = "0x4045B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001C58")]
	public void set_VerticalSpeed(float value) { }

	[Address(RVA = "0x404390", Offset = "0x403590", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[MoonSharpHidden]
	[Token(Token = "0x6001C77")]
	private void SetFollowTarget(DynamicInstance instance) { }

	[Address(RVA = "0x404440", Offset = "0x403640", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6001C8F")]
	public void SetTarget(Transform target) { }

	[Address(RVA = "0x404460", Offset = "0x403660", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(EventSystem), Member = "IsPointerOverGameObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001C7F")]
	private bool ShouldProcessCameraInput() { }

	[Address(RVA = "0x4045C0", Offset = "0x4037C0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C74")]
	protected virtual void Start() { }

	[Address(RVA = "0x404590", Offset = "0x403790", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C8B")]
	private void StartLooking() { }

	[Address(RVA = "0x404360", Offset = "0x403560", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C8C")]
	private void StopLooking() { }

	[Address(RVA = "0x404A50", Offset = "0x403C50", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C79")]
	private void UpdateFollow() { }

	[Address(RVA = "0x404690", Offset = "0x403890", Length = "0x3A5")]
	[CalledBy(Type = typeof(Camera), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFollow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFollowTarget", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "HandleFirstPersonRendering", ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(EventSystem), Member = "IsPointerOverGameObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputService), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "ApplyCameraTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Camera), Member = "HandleCameraRotation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C7B")]
	private void UpdateFollowMode(Transform followTarget) { }

	[Address(RVA = "0x404A40", Offset = "0x403C40", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001C7A")]
	private void UpdateFollowTarget() { }

	[Address(RVA = "0x404A60", Offset = "0x403C60", Length = "0x2D6")]
	[CalledBy(Type = typeof(Camera), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "HandleFreeMovement", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputService), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001C86")]
	private void UpdateFree() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C92")]
	public virtual bool Weaved() { }

}

