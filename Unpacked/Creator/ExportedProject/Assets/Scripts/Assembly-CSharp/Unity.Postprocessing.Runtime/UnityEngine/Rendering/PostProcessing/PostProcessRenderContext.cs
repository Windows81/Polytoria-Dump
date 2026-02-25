namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000073")]
public sealed class PostProcessRenderContext
{
	[Token(Token = "0x2000074")]
	internal enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DA")]
	private Camera m_Camera; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001DB")]
	private CommandBuffer <command>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DC")]
	private RenderTargetIdentifier <source>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001DD")]
	private RenderTargetIdentifier <destination>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001DE")]
	private RenderTextureFormat <sourceFormat>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40001DF")]
	private bool <flip>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001E0")]
	private PostProcessResources <resources>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001E1")]
	private PropertySheetFactory <propertySheets>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001E2")]
	private Dictionary<String, Object> <userData>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001E3")]
	private PostProcessDebugLayer <debugLayer>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40001E4")]
	private int <width>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40001E5")]
	private int <height>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001E6")]
	private bool <stereoActive>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40001E7")]
	private int <xrActiveEye>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001E8")]
	private int <numberOfEyes>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40001E9")]
	private StereoRenderingMode <stereoRenderingMode>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001EA")]
	private int <screenWidth>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40001EB")]
	private int <screenHeight>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001EC")]
	private bool <isSceneView>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40001ED")]
	private Antialiasing <antialiasing>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001EE")]
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001EF")]
	internal PropertySheet uberSheet; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001F0")]
	internal Texture autoExposureTexture; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001F1")]
	internal LogHistogram logHistogram; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001F2")]
	internal Texture logLut; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40001F3")]
	internal AutoExposure autoExposure; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40001F4")]
	internal int bloomBufferNameID; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40001F5")]
	internal bool physicalCamera; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40001F6")]
	private RenderTextureDescriptor m_sourceDescriptor; //Field offset: 0xF8

	[Token(Token = "0x17000022")]
	public internal Antialiasing antialiasing
	{
		[Address(RVA = "0x3D6660", Offset = "0x3D5860", Length = "0x7")]
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 7
		[Address(RVA = "0x184DE50", Offset = "0x184D050", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60001A7")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700000F")]
	public Camera camera
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000180")]
		 get { } //Length: 5
		[Address(RVA = "0x184DE60", Offset = "0x184D060", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
		[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000181")]
		 set { } //Length: 124
	}

	[Token(Token = "0x17000010")]
	public CommandBuffer command
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000182")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000183")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000018")]
	public internal PostProcessDebugLayer debugLayer
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000192")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000193")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000012")]
	public RenderTargetIdentifier destination
	{
		[Address(RVA = "0x184DE00", Offset = "0x184D000", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000186")]
		 get { } //Length: 29
		[Address(RVA = "0x184DEE0", Offset = "0x184D0E0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000187")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000014")]
	public bool flip
	{
		[Address(RVA = "0x184DE20", Offset = "0x184D020", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600018A")]
		 get { } //Length: 5
		[Address(RVA = "0x184DF00", Offset = "0x184D100", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600018B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public private int height
	{
		[Address(RVA = "0x508E90", Offset = "0x508090", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000196")]
		 get { } //Length: 7
		[Address(RVA = "0x508F50", Offset = "0x508150", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000197")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000021")]
	public internal bool isSceneView
	{
		[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 8
		[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A5")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700001D")]
	public private int numberOfEyes
	{
		[Address(RVA = "0x50C450", Offset = "0x50B650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600019C")]
		 get { } //Length: 7
		[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600019D")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000016")]
	public internal PropertySheetFactory propertySheets
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600018E")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600018F")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x17000015")]
	public internal PostProcessResources resources
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600018C")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600018D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000020")]
	public private int screenHeight
	{
		[Address(RVA = "0x13FA000", Offset = "0x13F9200", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 7
		[Address(RVA = "0x184DF10", Offset = "0x184D110", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A3")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700001F")]
	public private int screenWidth
	{
		[Address(RVA = "0x13F9F60", Offset = "0x13F9160", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 7
		[Address(RVA = "0x184DF20", Offset = "0x184D120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A1")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000011")]
	public RenderTargetIdentifier source
	{
		[Address(RVA = "0x184DE30", Offset = "0x184D030", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000184")]
		 get { } //Length: 29
		[Address(RVA = "0x184DF30", Offset = "0x184D130", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000185")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000013")]
	public RenderTextureFormat sourceFormat
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000188")]
		 get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000189")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001B")]
	public private bool stereoActive
	{
		[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000198")]
		 get { } //Length: 8
		[Address(RVA = "0x184DF50", Offset = "0x184D150", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000199")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700001E")]
	public private StereoRenderingMode stereoRenderingMode
	{
		[Address(RVA = "0x50C460", Offset = "0x50B660", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600019E")]
		 get { } //Length: 7
		[Address(RVA = "0x184DF60", Offset = "0x184D160", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600019F")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000023")]
	public internal TemporalAntialiasing temporalAntialiasing
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000017")]
	public private Dictionary<String, Object> userData
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000190")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000191")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000019")]
	public private int width
	{
		[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000194")]
		 get { } //Length: 7
		[Address(RVA = "0x508F40", Offset = "0x508140", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000195")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700001C")]
	public int xrActiveEye
	{
		[Address(RVA = "0x126F110", Offset = "0x126E310", Length = "0x7")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600019A")]
		 get { } //Length: 7
		[Address(RVA = "0x126F300", Offset = "0x126E500", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600019B")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B2")]
	public PostProcessRenderContext() { }

	[Address(RVA = "0x3D6660", Offset = "0x3D5860", Length = "0x7")]
	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A6")]
	public Antialiasing get_antialiasing() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	public Camera get_camera() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000182")]
	public CommandBuffer get_command() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000192")]
	public PostProcessDebugLayer get_debugLayer() { }

	[Address(RVA = "0x184DE00", Offset = "0x184D000", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000186")]
	public RenderTargetIdentifier get_destination() { }

	[Address(RVA = "0x184DE20", Offset = "0x184D020", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600018A")]
	public bool get_flip() { }

	[Address(RVA = "0x508E90", Offset = "0x508090", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000196")]
	public int get_height() { }

	[Address(RVA = "0x310340", Offset = "0x30F540", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A4")]
	public bool get_isSceneView() { }

	[Address(RVA = "0x50C450", Offset = "0x50B650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600019C")]
	public int get_numberOfEyes() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600018E")]
	public PropertySheetFactory get_propertySheets() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600018C")]
	public PostProcessResources get_resources() { }

	[Address(RVA = "0x13FA000", Offset = "0x13F9200", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A2")]
	public int get_screenHeight() { }

	[Address(RVA = "0x13F9F60", Offset = "0x13F9160", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A0")]
	public int get_screenWidth() { }

	[Address(RVA = "0x184DE30", Offset = "0x184D030", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000184")]
	public RenderTargetIdentifier get_source() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000188")]
	public RenderTextureFormat get_sourceFormat() { }

	[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000198")]
	public bool get_stereoActive() { }

	[Address(RVA = "0x50C460", Offset = "0x50B660", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600019E")]
	public StereoRenderingMode get_stereoRenderingMode() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A8")]
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000190")]
	public Dictionary<String, Object> get_userData() { }

	[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000194")]
	public int get_width() { }

	[Address(RVA = "0x126F110", Offset = "0x126E310", Length = "0x7")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600019A")]
	public int get_xrActiveEye() { }

	[Address(RVA = "0x184D760", Offset = "0x184C960", Length = "0x1B0")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(PostProcessRenderContext), typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessEvent), typeof(PostProcessRenderContext), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef>), typeof(PostProcessRenderContext), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(FilterMode), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AE")]
	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	[Address(RVA = "0x184D910", Offset = "0x184CB10", Length = "0x102")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AF")]
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	[Address(RVA = "0x184DA20", Offset = "0x184CC20", Length = "0x8F")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(PostProcessRenderContext), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(ScalableAO), Member = "DoLazyInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PostProcessRenderContext)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(RenderTexture))]
	[Token(Token = "0x60001B0")]
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	[Address(RVA = "0x184DAB0", Offset = "0x184CCB0", Length = "0x20")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AC")]
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	[Address(RVA = "0x184DAE0", Offset = "0x184CCE0", Length = "0x39")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AB")]
	public bool IsTemporalAntialiasingActive() { }

	[Address(RVA = "0x184DB20", Offset = "0x184CD20", Length = "0x57")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AD")]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	[Address(RVA = "0x184DB80", Offset = "0x184CD80", Length = "0x274")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AA")]
	public void Reset() { }

	[Address(RVA = "0x184DE50", Offset = "0x184D050", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60001A7")]
	internal void set_antialiasing(Antialiasing value) { }

	[Address(RVA = "0x184DE60", Offset = "0x184D060", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000181")]
	public void set_camera(Camera value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000183")]
	public void set_command(CommandBuffer value) { }

	[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000193")]
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[Address(RVA = "0x184DEE0", Offset = "0x184D0E0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000187")]
	public void set_destination(RenderTargetIdentifier value) { }

	[Address(RVA = "0x184DF00", Offset = "0x184D100", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600018B")]
	public void set_flip(bool value) { }

	[Address(RVA = "0x508F50", Offset = "0x508150", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000197")]
	private void set_height(int value) { }

	[Address(RVA = "0x2F5C50", Offset = "0x2F4E50", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A5")]
	internal void set_isSceneView(bool value) { }

	[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600019D")]
	private void set_numberOfEyes(int value) { }

	[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600018F")]
	internal void set_propertySheets(PropertySheetFactory value) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600018D")]
	internal void set_resources(PostProcessResources value) { }

	[Address(RVA = "0x184DF10", Offset = "0x184D110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A3")]
	private void set_screenHeight(int value) { }

	[Address(RVA = "0x184DF20", Offset = "0x184D120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A1")]
	private void set_screenWidth(int value) { }

	[Address(RVA = "0x184DF30", Offset = "0x184D130", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000185")]
	public void set_source(RenderTargetIdentifier value) { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000189")]
	public void set_sourceFormat(RenderTextureFormat value) { }

	[Address(RVA = "0x184DF50", Offset = "0x184D150", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000199")]
	private void set_stereoActive(bool value) { }

	[Address(RVA = "0x184DF60", Offset = "0x184D160", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600019F")]
	private void set_stereoRenderingMode(StereoRenderingMode value) { }

	[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A9")]
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000191")]
	private void set_userData(Dictionary<String, Object> value) { }

	[Address(RVA = "0x508F40", Offset = "0x508140", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000195")]
	private void set_width(int value) { }

	[Address(RVA = "0x126F300", Offset = "0x126E500", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600019B")]
	public void set_xrActiveEye(int value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B1")]
	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled) { }

}

