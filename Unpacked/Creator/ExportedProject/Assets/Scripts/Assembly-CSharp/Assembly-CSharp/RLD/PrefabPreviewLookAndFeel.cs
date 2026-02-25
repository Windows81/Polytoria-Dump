namespace RLD;

[Token(Token = "0x2000295")]
public class PrefabPreviewLookAndFeel : Settings
{
	[Token(Token = "0x4000A0D")]
	private static readonly float _minBkAlpha; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A0E")]
	private Color _bkColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000A0F")]
	private int _previewWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000A10")]
	private int _previewHeight; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000A11")]
	private float _lightIntensity; //Field offset: 0x40

	[Token(Token = "0x1700083B")]
	public Color BkColor
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018F7")]
		 get { } //Length: 11
		[Address(RVA = "0x3F0920", Offset = "0x3EFB20", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60018F8")]
		 set { } //Length: 114
	}

	[Token(Token = "0x1700083E")]
	public float LightIntensity
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018FD")]
		 get { } //Length: 6
		[Address(RVA = "0x3F09A0", Offset = "0x3EFBA0", Length = "0x14")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018FE")]
		 set { } //Length: 20
	}

	[Token(Token = "0x1700083D")]
	public int PreviewHeight
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018FB")]
		 get { } //Length: 4
		[Address(RVA = "0x3F09C0", Offset = "0x3EFBC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60018FC")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700083C")]
	public int PreviewWidth
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018F9")]
		 get { } //Length: 4
		[Address(RVA = "0x3F09D0", Offset = "0x3EFBD0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60018FA")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x3F08B0", Offset = "0x3EFAB0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001900")]
	private static PrefabPreviewLookAndFeel() { }

	[Address(RVA = "0x3F08F0", Offset = "0x3EFAF0", Length = "0x28")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60018FF")]
	public PrefabPreviewLookAndFeel() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018F7")]
	public Color get_BkColor() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018FD")]
	public float get_LightIntensity() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018FB")]
	public int get_PreviewHeight() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018F9")]
	public int get_PreviewWidth() { }

	[Address(RVA = "0x3F0920", Offset = "0x3EFB20", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60018F8")]
	public void set_BkColor(Color value) { }

	[Address(RVA = "0x3F09A0", Offset = "0x3EFBA0", Length = "0x14")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018FE")]
	public void set_LightIntensity(float value) { }

	[Address(RVA = "0x3F09C0", Offset = "0x3EFBC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60018FC")]
	public void set_PreviewHeight(int value) { }

	[Address(RVA = "0x3F09D0", Offset = "0x3EFBD0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60018FA")]
	public void set_PreviewWidth(int value) { }

}

