namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x200039B")]
public class CameraProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FE5")]
	private readonly Camera camera; //Field offset: 0x20

	[Token(Token = "0x17000B64")]
	public bool ClipThroughWalls
	{
		[Address(RVA = "0x4A1250", Offset = "0x4A0450", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026C4")]
		 get { } //Length: 30
		[Address(RVA = "0x4A1510", Offset = "0x4A0710", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C5")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000B5E")]
	public float Distance
	{
		[Address(RVA = "0x4A1270", Offset = "0x4A0470", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B8")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1530", Offset = "0x4A0730", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B9")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B66")]
	public float FastFlySpeed
	{
		[Address(RVA = "0x4A12B0", Offset = "0x4A04B0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C8")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1570", Offset = "0x4A0770", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C9")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B65")]
	public float FlySpeed
	{
		[Address(RVA = "0x4A12D0", Offset = "0x4A04D0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C6")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1590", Offset = "0x4A0790", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C7")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B69")]
	public bool FollowLerp
	{
		[Address(RVA = "0x4A12F0", Offset = "0x4A04F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026CE")]
		 get { } //Length: 30
		[Address(RVA = "0x4A15B0", Offset = "0x4A07B0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026CF")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000B6E")]
	public DynamicInstance FollowTarget
	{
		[Address(RVA = "0x4A1310", Offset = "0x4A0510", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D7")]
		 get { } //Length: 30
		[Address(RVA = "0x4A15D0", Offset = "0x4A07D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "set_FollowTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D8")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B5B")]
	public float FOV
	{
		[Address(RVA = "0x4A1290", Offset = "0x4A0490", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "get_FOV", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B2")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1550", Offset = "0x4A0750", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "set_FOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B3")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B67")]
	public float FreeLookSensitivity
	{
		[Address(RVA = "0x4A1330", Offset = "0x4A0530", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026CA")]
		 get { } //Length: 31
		[Address(RVA = "0x4A15F0", Offset = "0x4A07F0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026CB")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B61")]
	public float HorizontalSpeed
	{
		[Address(RVA = "0x4A1350", Offset = "0x4A0550", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026BE")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1610", Offset = "0x4A0810", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026BF")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B6D")]
	public bool IsFirstPerson
	{
		[Address(RVA = "0x4A1370", Offset = "0x4A0570", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "get_IsFirstPerson", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D6")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000B68")]
	public float LerpSpeed
	{
		[Address(RVA = "0x4A1390", Offset = "0x4A0590", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026CC")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1630", Offset = "0x4A0830", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026CD")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B60")]
	public float MaxDistance
	{
		[Address(RVA = "0x4A13B0", Offset = "0x4A05B0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026BC")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1650", Offset = "0x4A0850", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026BD")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B5F")]
	public float MinDistance
	{
		[Address(RVA = "0x4A13D0", Offset = "0x4A05D0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026BA")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1670", Offset = "0x4A0870", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026BB")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B5A")]
	public CameraMode Mode
	{
		[Address(RVA = "0x4A13F0", Offset = "0x4A05F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026B0")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1690", Offset = "0x4A0890", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B1")]
		 set { } //Length: 29
	}

	[Token(Token = "0x17000B5C")]
	public bool Orthographic
	{
		[Address(RVA = "0x4A1430", Offset = "0x4A0630", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "get_Orthographic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B4")]
		 get { } //Length: 29
		[Address(RVA = "0x4A16D0", Offset = "0x4A08D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "set_Orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B5")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B5D")]
	public float OrthographicSize
	{
		[Address(RVA = "0x4A1410", Offset = "0x4A0610", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "get_OrthographicSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B6")]
		 get { } //Length: 29
		[Address(RVA = "0x4A16B0", Offset = "0x4A08B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Camera), Member = "set_OrthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026B7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B6B")]
	public Vector3 PositionOffset
	{
		[Address(RVA = "0x4A1450", Offset = "0x4A0650", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D2")]
		 get { } //Length: 47
		[Address(RVA = "0x4A16F0", Offset = "0x4A08F0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D3")]
		 set { } //Length: 46
	}

	[Token(Token = "0x17000B6C")]
	public Vector3 RotationOffset
	{
		[Address(RVA = "0x4A1480", Offset = "0x4A0680", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D4")]
		 get { } //Length: 47
		[Address(RVA = "0x4A1720", Offset = "0x4A0920", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D5")]
		 set { } //Length: 46
	}

	[Token(Token = "0x17000B63")]
	public float ScrollSensitivity
	{
		[Address(RVA = "0x4A14B0", Offset = "0x4A06B0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C2")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1750", Offset = "0x4A0950", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C3")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B6A")]
	public float SensitivityMultiplier
	{
		[Address(RVA = "0x4A14D0", Offset = "0x4A06D0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D0")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1770", Offset = "0x4A0970", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026D1")]
		 set { } //Length: 31
	}

	[Token(Token = "0x17000B62")]
	public float VerticalSpeed
	{
		[Address(RVA = "0x4A14F0", Offset = "0x4A06F0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C0")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1790", Offset = "0x4A0990", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026C1")]
		 set { } //Length: 31
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026AF")]
	public CameraProxy(Camera target) { }

	[Address(RVA = "0x4A1250", Offset = "0x4A0450", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C4")]
	public bool get_ClipThroughWalls() { }

	[Address(RVA = "0x4A1270", Offset = "0x4A0470", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B8")]
	public float get_Distance() { }

	[Address(RVA = "0x4A12B0", Offset = "0x4A04B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C8")]
	public float get_FastFlySpeed() { }

	[Address(RVA = "0x4A12D0", Offset = "0x4A04D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C6")]
	public float get_FlySpeed() { }

	[Address(RVA = "0x4A12F0", Offset = "0x4A04F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CE")]
	public bool get_FollowLerp() { }

	[Address(RVA = "0x4A1310", Offset = "0x4A0510", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D7")]
	public DynamicInstance get_FollowTarget() { }

	[Address(RVA = "0x4A1290", Offset = "0x4A0490", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_FOV", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B2")]
	public float get_FOV() { }

	[Address(RVA = "0x4A1330", Offset = "0x4A0530", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CA")]
	public float get_FreeLookSensitivity() { }

	[Address(RVA = "0x4A1350", Offset = "0x4A0550", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BE")]
	public float get_HorizontalSpeed() { }

	[Address(RVA = "0x4A1370", Offset = "0x4A0570", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_IsFirstPerson", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D6")]
	public bool get_IsFirstPerson() { }

	[Address(RVA = "0x4A1390", Offset = "0x4A0590", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CC")]
	public float get_LerpSpeed() { }

	[Address(RVA = "0x4A13B0", Offset = "0x4A05B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BC")]
	public float get_MaxDistance() { }

	[Address(RVA = "0x4A13D0", Offset = "0x4A05D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BA")]
	public float get_MinDistance() { }

	[Address(RVA = "0x4A13F0", Offset = "0x4A05F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026B0")]
	public CameraMode get_Mode() { }

	[Address(RVA = "0x4A1430", Offset = "0x4A0630", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_Orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B4")]
	public bool get_Orthographic() { }

	[Address(RVA = "0x4A1410", Offset = "0x4A0610", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_OrthographicSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B6")]
	public float get_OrthographicSize() { }

	[Address(RVA = "0x4A1450", Offset = "0x4A0650", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D2")]
	public Vector3 get_PositionOffset() { }

	[Address(RVA = "0x4A1480", Offset = "0x4A0680", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D4")]
	public Vector3 get_RotationOffset() { }

	[Address(RVA = "0x4A14B0", Offset = "0x4A06B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C2")]
	public float get_ScrollSensitivity() { }

	[Address(RVA = "0x4A14D0", Offset = "0x4A06D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D0")]
	public float get_SensitivityMultiplier() { }

	[Address(RVA = "0x4A14F0", Offset = "0x4A06F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C0")]
	public float get_VerticalSpeed() { }

	[Address(RVA = "0x4A1510", Offset = "0x4A0710", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C5")]
	public void set_ClipThroughWalls(bool value) { }

	[Address(RVA = "0x4A1530", Offset = "0x4A0730", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B9")]
	public void set_Distance(float value) { }

	[Address(RVA = "0x4A1570", Offset = "0x4A0770", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C9")]
	public void set_FastFlySpeed(float value) { }

	[Address(RVA = "0x4A1590", Offset = "0x4A0790", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C7")]
	public void set_FlySpeed(float value) { }

	[Address(RVA = "0x4A15B0", Offset = "0x4A07B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CF")]
	public void set_FollowLerp(bool value) { }

	[Address(RVA = "0x4A15D0", Offset = "0x4A07D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_FollowTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D8")]
	public void set_FollowTarget(DynamicInstance value) { }

	[Address(RVA = "0x4A1550", Offset = "0x4A0750", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_FOV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B3")]
	public void set_FOV(float value) { }

	[Address(RVA = "0x4A15F0", Offset = "0x4A07F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CB")]
	public void set_FreeLookSensitivity(float value) { }

	[Address(RVA = "0x4A1610", Offset = "0x4A0810", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BF")]
	public void set_HorizontalSpeed(float value) { }

	[Address(RVA = "0x4A1630", Offset = "0x4A0830", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026CD")]
	public void set_LerpSpeed(float value) { }

	[Address(RVA = "0x4A1650", Offset = "0x4A0850", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BD")]
	public void set_MaxDistance(float value) { }

	[Address(RVA = "0x4A1670", Offset = "0x4A0870", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026BB")]
	public void set_MinDistance(float value) { }

	[Address(RVA = "0x4A1690", Offset = "0x4A0890", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B1")]
	public void set_Mode(CameraMode value) { }

	[Address(RVA = "0x4A16D0", Offset = "0x4A08D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_Orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B5")]
	public void set_Orthographic(bool value) { }

	[Address(RVA = "0x4A16B0", Offset = "0x4A08B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_OrthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026B7")]
	public void set_OrthographicSize(float value) { }

	[Address(RVA = "0x4A16F0", Offset = "0x4A08F0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D3")]
	public void set_PositionOffset(Vector3 value) { }

	[Address(RVA = "0x4A1720", Offset = "0x4A0920", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D5")]
	public void set_RotationOffset(Vector3 value) { }

	[Address(RVA = "0x4A1750", Offset = "0x4A0950", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C3")]
	public void set_ScrollSensitivity(float value) { }

	[Address(RVA = "0x4A1770", Offset = "0x4A0970", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D1")]
	public void set_SensitivityMultiplier(float value) { }

	[Address(RVA = "0x4A1790", Offset = "0x4A0990", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026C1")]
	public void set_VerticalSpeed(float value) { }

}

