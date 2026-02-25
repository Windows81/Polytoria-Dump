namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000320")]
public class GradientSky : SkyBase
{
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "OnSunDiscColorChanged")]
	[Token(Token = "0x4000C68")]
	private Color sunDiscColor; //Field offset: 0x100
	[FieldOffset(Offset = "0x110")]
	[SyncVar(hook = "OnSunDiscMultiplierChanged")]
	[Token(Token = "0x4000C69")]
	private float sunDiscMultiplier; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SyncVar(hook = "OnSunDiscExponentChanged")]
	[Token(Token = "0x4000C6A")]
	private float sunDiscExponent; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SyncVar(hook = "OnSunHaloColorChanged")]
	[Token(Token = "0x4000C6B")]
	private Color sunHaloColor; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[SyncVar(hook = "OnSunHaloExponentChanged")]
	[Token(Token = "0x4000C6C")]
	private float sunHaloExponent; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[SyncVar(hook = "OnSunHaloContributionChanged")]
	[Token(Token = "0x4000C6D")]
	private float sunHaloContribution; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[SyncVar(hook = "OnHorizonLineColorChanged")]
	[Token(Token = "0x4000C6E")]
	private Color horizonLineColor; //Field offset: 0x130
	[FieldOffset(Offset = "0x140")]
	[SyncVar(hook = "OnHorizonLineExponentChanged")]
	[Token(Token = "0x4000C6F")]
	private float horizonLineExponent; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[SyncVar(hook = "OnHorizonLineContributionChanged")]
	[Token(Token = "0x4000C70")]
	private float horizonLineContribution; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[SyncVar(hook = "OnSkyGradientTopChanged")]
	[Token(Token = "0x4000C71")]
	private Color skyGradientTop; //Field offset: 0x148
	[FieldOffset(Offset = "0x158")]
	[SyncVar(hook = "OnSkyGradientBottomChanged")]
	[Token(Token = "0x4000C72")]
	private Color skyGradientBottom; //Field offset: 0x158
	[FieldOffset(Offset = "0x168")]
	[SyncVar(hook = "OnSkyGradientExponentChanged")]
	[Token(Token = "0x4000C73")]
	private float skyGradientExponent; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000C74")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunDiscColor; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000C75")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunDiscMultiplier; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000C76")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunDiscExponent; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000C77")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunHaloColor; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000C78")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunHaloExponent; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000C79")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunHaloContribution; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000C7A")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_horizonLineColor; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000C7B")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_horizonLineExponent; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000C7C")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_horizonLineContribution; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000C7D")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientTop; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000C7E")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientBottom; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000C7F")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_skyGradientExponent; //Field offset: 0x1C8

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700094E")]
	public Color HorizonLineColor
	{
		[Address(RVA = "0x424B60", Offset = "0x423D60", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DB1")]
		 get { } //Length: 14
		[Address(RVA = "0x424C00", Offset = "0x423E00", Length = "0xBA")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnHorizonLineColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_HorizonLineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DB2")]
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000950")]
	public float HorizonLineContribution
	{
		[Address(RVA = "0x424B70", Offset = "0x423D70", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DB5")]
		 get { } //Length: 9
		[Address(RVA = "0x424CC0", Offset = "0x423EC0", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnHorizonLineContributionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_HorizonLineContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DB6")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700094F")]
	public float HorizonLineExponent
	{
		[Address(RVA = "0x424B80", Offset = "0x423D80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DB3")]
		 get { } //Length: 9
		[Address(RVA = "0x424D70", Offset = "0x423F70", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnHorizonLineExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_HorizonLineExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DB4")]
		 set { } //Length: 166
	}

	[Token(Token = "0x1700095A")]
	public Color NetworkhorizonLineColor
	{
		[Address(RVA = "0x424B60", Offset = "0x423D60", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DDB")]
		 get { } //Length: 14
		[Address(RVA = "0x424E20", Offset = "0x424020", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6001DDC")]
		 set { } //Length: 113
	}

	[Token(Token = "0x1700095C")]
	public float NetworkhorizonLineContribution
	{
		[Address(RVA = "0x424B70", Offset = "0x423D70", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DDF")]
		 get { } //Length: 9
		[Address(RVA = "0x424EA0", Offset = "0x4240A0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DE0")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700095B")]
	public float NetworkhorizonLineExponent
	{
		[Address(RVA = "0x424B80", Offset = "0x423D80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DDD")]
		 get { } //Length: 9
		[Address(RVA = "0x424F10", Offset = "0x424110", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DDE")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700095E")]
	public Color NetworkskyGradientBottom
	{
		[Address(RVA = "0x424B90", Offset = "0x423D90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DE3")]
		 get { } //Length: 14
		[Address(RVA = "0x424F80", Offset = "0x424180", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6001DE4")]
		 set { } //Length: 113
	}

	[Token(Token = "0x1700095F")]
	public float NetworkskyGradientExponent
	{
		[Address(RVA = "0x424BA0", Offset = "0x423DA0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DE5")]
		 get { } //Length: 9
		[Address(RVA = "0x425000", Offset = "0x424200", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DE6")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700095D")]
	public Color NetworkskyGradientTop
	{
		[Address(RVA = "0x424BB0", Offset = "0x423DB0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DE1")]
		 get { } //Length: 14
		[Address(RVA = "0x425070", Offset = "0x424270", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6001DE2")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000954")]
	public Color NetworksunDiscColor
	{
		[Address(RVA = "0x407480", Offset = "0x406680", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DCF")]
		 get { } //Length: 14
		[Address(RVA = "0x4250F0", Offset = "0x4242F0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6001DD0")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000956")]
	public float NetworksunDiscExponent
	{
		[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DD3")]
		 get { } //Length: 9
		[Address(RVA = "0x425170", Offset = "0x424370", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DD4")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000955")]
	public float NetworksunDiscMultiplier
	{
		[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DD1")]
		 get { } //Length: 9
		[Address(RVA = "0x4251E0", Offset = "0x4243E0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DD2")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000957")]
	public Color NetworksunHaloColor
	{
		[Address(RVA = "0x424BD0", Offset = "0x423DD0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DD5")]
		 get { } //Length: 14
		[Address(RVA = "0x425250", Offset = "0x424450", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6001DD6")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000959")]
	public float NetworksunHaloContribution
	{
		[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DD9")]
		 get { } //Length: 9
		[Address(RVA = "0x4252D0", Offset = "0x4244D0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DDA")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000958")]
	public float NetworksunHaloExponent
	{
		[Address(RVA = "0x424BF0", Offset = "0x423DF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DD7")]
		 get { } //Length: 9
		[Address(RVA = "0x425340", Offset = "0x424540", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6001DD8")]
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000952")]
	public Color SkyGradientBottom
	{
		[Address(RVA = "0x424B90", Offset = "0x423D90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DB9")]
		 get { } //Length: 14
		[Address(RVA = "0x4253B0", Offset = "0x4245B0", Length = "0xBA")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSkyGradientBottomChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SkyGradientBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DBA")]
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000953")]
	public float SkyGradientExponent
	{
		[Address(RVA = "0x424BA0", Offset = "0x423DA0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DBB")]
		 get { } //Length: 9
		[Address(RVA = "0x425470", Offset = "0x424670", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSkyGradientExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SkyGradientExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DBC")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000951")]
	public Color SkyGradientTop
	{
		[Address(RVA = "0x424BB0", Offset = "0x423DB0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DB7")]
		 get { } //Length: 14
		[Address(RVA = "0x425520", Offset = "0x424720", Length = "0xBA")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSkyGradientTopChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SkyGradientTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DB8")]
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000948")]
	public Color SunDiscColor
	{
		[Address(RVA = "0x407480", Offset = "0x406680", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA5")]
		 get { } //Length: 14
		[Address(RVA = "0x4255E0", Offset = "0x4247E0", Length = "0xBA")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSunDiscColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunDiscColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DA6")]
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700094A")]
	public float SunDiscExponent
	{
		[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA9")]
		 get { } //Length: 9
		[Address(RVA = "0x4256A0", Offset = "0x4248A0", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSunDiscExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunDiscExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DAA")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000949")]
	public float SunDiscMultiplier
	{
		[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA7")]
		 get { } //Length: 9
		[Address(RVA = "0x425750", Offset = "0x424950", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSunDiscMultiplierChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunDiscMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DA8")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700094B")]
	public Color SunHaloColor
	{
		[Address(RVA = "0x424BD0", Offset = "0x423DD0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DAB")]
		 get { } //Length: 14
		[Address(RVA = "0x425800", Offset = "0x424A00", Length = "0xBA")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSunHaloColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunHaloColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DAC")]
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700094D")]
	public float SunHaloContribution
	{
		[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DAF")]
		 get { } //Length: 9
		[Address(RVA = "0x4258C0", Offset = "0x424AC0", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSunHaloContributionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunHaloContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DB0")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700094C")]
	public float SunHaloExponent
	{
		[Address(RVA = "0x424BF0", Offset = "0x423DF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DAD")]
		 get { } //Length: 9
		[Address(RVA = "0x425970", Offset = "0x424B70", Length = "0xA6")]
		[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSky), Member = "OnSunHaloExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunHaloExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001DAE")]
		 set { } //Length: 166
	}

	[Address(RVA = "0x424730", Offset = "0x423930", Length = "0x426")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SkyBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6001DCD")]
	public GradientSky() { }

	[Address(RVA = "0x4237D0", Offset = "0x4229D0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SkyBase), Member = "Apply", ReturnType = typeof(void))]
	[Token(Token = "0x6001DBF")]
	protected virtual void Apply() { }

	[Address(RVA = "0x4238B0", Offset = "0x422AB0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DBD")]
	protected virtual void Awake() { }

	[Address(RVA = "0x423990", Offset = "0x422B90", Length = "0x1A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DC0")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x423B40", Offset = "0x422D40", Length = "0x5E2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DE8")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x424B60", Offset = "0x423D60", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB1")]
	public Color get_HorizonLineColor() { }

	[Address(RVA = "0x424B70", Offset = "0x423D70", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB5")]
	public float get_HorizonLineContribution() { }

	[Address(RVA = "0x424B80", Offset = "0x423D80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB3")]
	public float get_HorizonLineExponent() { }

	[Address(RVA = "0x424B60", Offset = "0x423D60", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DDB")]
	public Color get_NetworkhorizonLineColor() { }

	[Address(RVA = "0x424B70", Offset = "0x423D70", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DDF")]
	public float get_NetworkhorizonLineContribution() { }

	[Address(RVA = "0x424B80", Offset = "0x423D80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DDD")]
	public float get_NetworkhorizonLineExponent() { }

	[Address(RVA = "0x424B90", Offset = "0x423D90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE3")]
	public Color get_NetworkskyGradientBottom() { }

	[Address(RVA = "0x424BA0", Offset = "0x423DA0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE5")]
	public float get_NetworkskyGradientExponent() { }

	[Address(RVA = "0x424BB0", Offset = "0x423DB0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE1")]
	public Color get_NetworkskyGradientTop() { }

	[Address(RVA = "0x407480", Offset = "0x406680", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCF")]
	public Color get_NetworksunDiscColor() { }

	[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD3")]
	public float get_NetworksunDiscExponent() { }

	[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD1")]
	public float get_NetworksunDiscMultiplier() { }

	[Address(RVA = "0x424BD0", Offset = "0x423DD0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD5")]
	public Color get_NetworksunHaloColor() { }

	[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD9")]
	public float get_NetworksunHaloContribution() { }

	[Address(RVA = "0x424BF0", Offset = "0x423DF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DD7")]
	public float get_NetworksunHaloExponent() { }

	[Address(RVA = "0x424B90", Offset = "0x423D90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB9")]
	public Color get_SkyGradientBottom() { }

	[Address(RVA = "0x424BA0", Offset = "0x423DA0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DBB")]
	public float get_SkyGradientExponent() { }

	[Address(RVA = "0x424BB0", Offset = "0x423DB0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DB7")]
	public Color get_SkyGradientTop() { }

	[Address(RVA = "0x407480", Offset = "0x406680", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DA5")]
	public Color get_SunDiscColor() { }

	[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DA9")]
	public float get_SunDiscExponent() { }

	[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DA7")]
	public float get_SunDiscMultiplier() { }

	[Address(RVA = "0x424BD0", Offset = "0x423DD0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DAB")]
	public Color get_SunHaloColor() { }

	[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DAF")]
	public float get_SunHaloContribution() { }

	[Address(RVA = "0x424BF0", Offset = "0x423DF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DAD")]
	public float get_SunHaloExponent() { }

	[Address(RVA = "0x424130", Offset = "0x423330", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC7")]
	private void OnHorizonLineColorChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x424170", Offset = "0x423370", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC9")]
	private void OnHorizonLineContributionChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x4241B0", Offset = "0x4233B0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_HorizonLineExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC8")]
	private void OnHorizonLineExponentChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x4241F0", Offset = "0x4233F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DCB")]
	private void OnSkyGradientBottomChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x424230", Offset = "0x423430", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DCC")]
	private void OnSkyGradientExponentChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x424270", Offset = "0x423470", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SkyGradientTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DCA")]
	private void OnSkyGradientTopChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x4242B0", Offset = "0x4234B0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC1")]
	private void OnSunDiscColorChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x4242F0", Offset = "0x4234F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC3")]
	private void OnSunDiscExponentChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x424330", Offset = "0x423530", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunDiscMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC2")]
	private void OnSunDiscMultiplierChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x424370", Offset = "0x423570", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC4")]
	private void OnSunHaloColorChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x4243B0", Offset = "0x4235B0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC6")]
	private void OnSunHaloContributionChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x4243F0", Offset = "0x4235F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GradientSky), Member = "set_SunHaloExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DC5")]
	private void OnSunHaloExponentChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x424430", Offset = "0x423630", Length = "0x2E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001DE7")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x424C00", Offset = "0x423E00", Length = "0xBA")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnHorizonLineColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_HorizonLineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DB2")]
	public void set_HorizonLineColor(Color value) { }

	[Address(RVA = "0x424CC0", Offset = "0x423EC0", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnHorizonLineContributionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_HorizonLineContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DB6")]
	public void set_HorizonLineContribution(float value) { }

	[Address(RVA = "0x424D70", Offset = "0x423F70", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnHorizonLineExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_HorizonLineExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DB4")]
	public void set_HorizonLineExponent(float value) { }

	[Address(RVA = "0x424E20", Offset = "0x424020", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6001DDC")]
	public void set_NetworkhorizonLineColor(in Color value) { }

	[Address(RVA = "0x424EA0", Offset = "0x4240A0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DE0")]
	public void set_NetworkhorizonLineContribution(in float value) { }

	[Address(RVA = "0x424F10", Offset = "0x424110", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DDE")]
	public void set_NetworkhorizonLineExponent(in float value) { }

	[Address(RVA = "0x424F80", Offset = "0x424180", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6001DE4")]
	public void set_NetworkskyGradientBottom(in Color value) { }

	[Address(RVA = "0x425000", Offset = "0x424200", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DE6")]
	public void set_NetworkskyGradientExponent(in float value) { }

	[Address(RVA = "0x425070", Offset = "0x424270", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6001DE2")]
	public void set_NetworkskyGradientTop(in Color value) { }

	[Address(RVA = "0x4250F0", Offset = "0x4242F0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6001DD0")]
	public void set_NetworksunDiscColor(in Color value) { }

	[Address(RVA = "0x425170", Offset = "0x424370", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DD4")]
	public void set_NetworksunDiscExponent(in float value) { }

	[Address(RVA = "0x4251E0", Offset = "0x4243E0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DD2")]
	public void set_NetworksunDiscMultiplier(in float value) { }

	[Address(RVA = "0x425250", Offset = "0x424450", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6001DD6")]
	public void set_NetworksunHaloColor(in Color value) { }

	[Address(RVA = "0x4252D0", Offset = "0x4244D0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DDA")]
	public void set_NetworksunHaloContribution(in float value) { }

	[Address(RVA = "0x425340", Offset = "0x424540", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6001DD8")]
	public void set_NetworksunHaloExponent(in float value) { }

	[Address(RVA = "0x4253B0", Offset = "0x4245B0", Length = "0xBA")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSkyGradientBottomChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SkyGradientBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DBA")]
	public void set_SkyGradientBottom(Color value) { }

	[Address(RVA = "0x425470", Offset = "0x424670", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSkyGradientExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SkyGradientExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DBC")]
	public void set_SkyGradientExponent(float value) { }

	[Address(RVA = "0x425520", Offset = "0x424720", Length = "0xBA")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSkyGradientTopChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SkyGradientTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DB8")]
	public void set_SkyGradientTop(Color value) { }

	[Address(RVA = "0x4255E0", Offset = "0x4247E0", Length = "0xBA")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSunDiscColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunDiscColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DA6")]
	public void set_SunDiscColor(Color value) { }

	[Address(RVA = "0x4256A0", Offset = "0x4248A0", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSunDiscExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunDiscExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DAA")]
	public void set_SunDiscExponent(float value) { }

	[Address(RVA = "0x425750", Offset = "0x424950", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSunDiscMultiplierChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunDiscMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DA8")]
	public void set_SunDiscMultiplier(float value) { }

	[Address(RVA = "0x425800", Offset = "0x424A00", Length = "0xBA")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSunHaloColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunHaloColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DAC")]
	public void set_SunHaloColor(Color value) { }

	[Address(RVA = "0x4258C0", Offset = "0x424AC0", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSunHaloContributionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunHaloContribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DB0")]
	public void set_SunHaloContribution(float value) { }

	[Address(RVA = "0x425970", Offset = "0x424B70", Length = "0xA6")]
	[CalledBy(Type = typeof(GradientSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSky), Member = "OnSunHaloExponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSkyProxy), Member = "set_SunHaloExponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001DAE")]
	public void set_SunHaloExponent(float value) { }

	[Address(RVA = "0x424720", Offset = "0x423920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DBE")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DCE")]
	public virtual bool Weaved() { }

}

