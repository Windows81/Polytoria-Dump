namespace RLD;

[Token(Token = "0x2000211")]
public class SceneLookAndFeel : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40007FD")]
	private bool _drawLightIcons; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	[Token(Token = "0x40007FE")]
	private bool _drawParticleSystemIcons; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[SerializeField]
	[Token(Token = "0x40007FF")]
	private bool _drawCameraIcons; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000800")]
	private float _lightIconAlpha; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000801")]
	private float _particleSystemIconAlpha; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000802")]
	private float _cameraIconAlpha; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000803")]
	private Texture2D _lightIcon; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000804")]
	private Texture2D _particleSystemIcon; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000805")]
	private Texture2D _cameraIcon; //Field offset: 0x48

	[Token(Token = "0x1700066A")]
	public Texture2D CameraIcon
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001437")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001438")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000667")]
	public float CameraIconAlpha
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001431")]
		 get { } //Length: 6
		[Address(RVA = "0x5A2340", Offset = "0x5A1540", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001432")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000664")]
	public bool DrawCameraIcons
	{
		[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600142B")]
		 get { } //Length: 5
		[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600142C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000662")]
	public bool DrawLightIcons
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001427")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001428")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000663")]
	public bool DrawParticleSystemIcons
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001429")]
		 get { } //Length: 5
		[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600142A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000668")]
	public Texture2D LightIcon
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001433")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001434")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000665")]
	public float LightIconAlpha
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600142D")]
		 get { } //Length: 6
		[Address(RVA = "0x5A2370", Offset = "0x5A1570", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600142E")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000669")]
	public Texture2D ParticleSystemIcon
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001435")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001436")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000666")]
	public float ParticleSystemIconAlpha
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600142F")]
		 get { } //Length: 6
		[Address(RVA = "0x5A23A0", Offset = "0x5A15A0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001430")]
		 set { } //Length: 33
	}

	[Address(RVA = "0x5A2310", Offset = "0x5A1510", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001439")]
	public SceneLookAndFeel() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001437")]
	public Texture2D get_CameraIcon() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001431")]
	public float get_CameraIconAlpha() { }

	[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142B")]
	public bool get_DrawCameraIcons() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001427")]
	public bool get_DrawLightIcons() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001429")]
	public bool get_DrawParticleSystemIcons() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001433")]
	public Texture2D get_LightIcon() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142D")]
	public float get_LightIconAlpha() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001435")]
	public Texture2D get_ParticleSystemIcon() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142F")]
	public float get_ParticleSystemIconAlpha() { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001438")]
	public void set_CameraIcon(Texture2D value) { }

	[Address(RVA = "0x5A2340", Offset = "0x5A1540", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001432")]
	public void set_CameraIconAlpha(float value) { }

	[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142C")]
	public void set_DrawCameraIcons(bool value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001428")]
	public void set_DrawLightIcons(bool value) { }

	[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142A")]
	public void set_DrawParticleSystemIcons(bool value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001434")]
	public void set_LightIcon(Texture2D value) { }

	[Address(RVA = "0x5A2370", Offset = "0x5A1570", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600142E")]
	public void set_LightIconAlpha(float value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001436")]
	public void set_ParticleSystemIcon(Texture2D value) { }

	[Address(RVA = "0x5A23A0", Offset = "0x5A15A0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001430")]
	public void set_ParticleSystemIconAlpha(float value) { }

}

