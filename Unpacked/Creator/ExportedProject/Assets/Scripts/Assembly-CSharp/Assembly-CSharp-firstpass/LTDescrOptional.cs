//Type is in global namespace

[Token(Token = "0x2000021")]
public class LTDescrOptional
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012E")]
	private Transform <toTrans>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400012F")]
	private Vector3 <point>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000130")]
	private Vector3 <axis>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000131")]
	private float <lastVal>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000132")]
	private Quaternion <origRotation>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000133")]
	private LTBezierPath <path>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000134")]
	private LTSpline <spline>k__BackingField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000135")]
	public AnimationCurve animationCurve; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000136")]
	public int initFrameCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000137")]
	public Color color; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000138")]
	private LTRect <ltRect>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000139")]
	private Action<Single> <onUpdateFloat>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400013A")]
	private Action<Single, Single> <onUpdateFloatRatio>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400013B")]
	private Action<Single, Object> <onUpdateFloatObject>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400013C")]
	private Action<Vector2> <onUpdateVector2>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400013D")]
	private Action<Vector3> <onUpdateVector3>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400013E")]
	private Action<Vector3, Object> <onUpdateVector3Object>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400013F")]
	private Action<Color> <onUpdateColor>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000140")]
	private Action<Color, Object> <onUpdateColorObject>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000141")]
	private Action <onComplete>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000142")]
	private Action<Object> <onCompleteObject>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000143")]
	private object <onCompleteParam>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000144")]
	private object <onUpdateParam>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000145")]
	private Action <onStart>k__BackingField; //Field offset: 0xE0

	[Token(Token = "0x1700001D")]
	public Vector3 axis
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000327")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000328")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700001E")]
	public float lastVal
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000329")]
		 get { } //Length: 6
		[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032A")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000022")]
	public LTRect ltRect
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000331")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000332")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002B")]
	public Action onComplete
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000343")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000344")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700002C")]
	public Action<Object> onCompleteObject
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000345")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000346")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700002D")]
	public object onCompleteParam
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000347")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000348")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700002F")]
	public Action onStart
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600034B")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600034C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000029")]
	public Action<Color> onUpdateColor
	{
		[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033F")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000340")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700002A")]
	public Action<Color, Object> onUpdateColorObject
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000341")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000342")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000023")]
	public Action<Single> onUpdateFloat
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000333")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000334")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000025")]
	public Action<Single, Object> onUpdateFloatObject
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000337")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000338")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000024")]
	public Action<Single, Single> onUpdateFloatRatio
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000335")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000336")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700002E")]
	public object onUpdateParam
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000349")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD560", Offset = "0x2DC760", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600034A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000026")]
	public Action<Vector2> onUpdateVector2
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000339")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000027")]
	public Action<Vector3> onUpdateVector3
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033B")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000028")]
	public Action<Vector3, Object> onUpdateVector3Object
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033D")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700001F")]
	public Quaternion origRotation
	{
		[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032B")]
		 get { } //Length: 11
		[Address(RVA = "0x2DD5E0", Offset = "0x2DC7E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000020")]
	public LTBezierPath path
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032D")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700001C")]
	public Vector3 point
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000325")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000326")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000021")]
	public LTSpline spline
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600032F")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000330")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700001B")]
	public Transform toTrans
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000323")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000324")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034F")]
	public LTDescrOptional() { }

	[Address(RVA = "0x2DCF60", Offset = "0x2DC160", Length = "0x1F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600034E")]
	public void callOnUpdate(float val, float ratioPassed) { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000327")]
	public Vector3 get_axis() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000329")]
	public float get_lastVal() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000331")]
	public LTRect get_ltRect() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000343")]
	public Action get_onComplete() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000345")]
	public Action<Object> get_onCompleteObject() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000347")]
	public object get_onCompleteParam() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600034B")]
	public Action get_onStart() { }

	[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033F")]
	public Action<Color> get_onUpdateColor() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000341")]
	public Action<Color, Object> get_onUpdateColorObject() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000333")]
	public Action<Single> get_onUpdateFloat() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000337")]
	public Action<Single, Object> get_onUpdateFloatObject() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000335")]
	public Action<Single, Single> get_onUpdateFloatRatio() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000349")]
	public object get_onUpdateParam() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000339")]
	public Action<Vector2> get_onUpdateVector2() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033B")]
	public Action<Vector3> get_onUpdateVector3() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033D")]
	public Action<Vector3, Object> get_onUpdateVector3Object() { }

	[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032B")]
	public Quaternion get_origRotation() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032D")]
	public LTBezierPath get_path() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000325")]
	public Vector3 get_point() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032F")]
	public LTSpline get_spline() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000323")]
	public Transform get_toTrans() { }

	[Address(RVA = "0x2DD2D0", Offset = "0x2DC4D0", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600034D")]
	public void reset() { }

	[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000328")]
	public void set_axis(Vector3 value) { }

	[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032A")]
	public void set_lastVal(float value) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000332")]
	public void set_ltRect(LTRect value) { }

	[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000344")]
	public void set_onComplete(Action value) { }

	[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000346")]
	public void set_onCompleteObject(Action<Object> value) { }

	[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000348")]
	public void set_onCompleteParam(object value) { }

	[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600034C")]
	public void set_onStart(Action value) { }

	[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000340")]
	public void set_onUpdateColor(Action<Color> value) { }

	[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000342")]
	public void set_onUpdateColorObject(Action<Color, Object> value) { }

	[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000334")]
	public void set_onUpdateFloat(Action<Single> value) { }

	[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000338")]
	public void set_onUpdateFloatObject(Action<Single, Object> value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000336")]
	public void set_onUpdateFloatRatio(Action<Single, Single> value) { }

	[Address(RVA = "0x2DD560", Offset = "0x2DC760", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600034A")]
	public void set_onUpdateParam(object value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033A")]
	public void set_onUpdateVector2(Action<Vector2> value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033C")]
	public void set_onUpdateVector3(Action<Vector3> value) { }

	[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033E")]
	public void set_onUpdateVector3Object(Action<Vector3, Object> value) { }

	[Address(RVA = "0x2DD5E0", Offset = "0x2DC7E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032C")]
	public void set_origRotation(Quaternion value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600032E")]
	public void set_path(LTBezierPath value) { }

	[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000326")]
	public void set_point(Vector3 value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000330")]
	public void set_spline(LTSpline value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000324")]
	public void set_toTrans(Transform value) { }

}

