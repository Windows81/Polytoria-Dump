namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200007B")]
public class HableCurve
{
	[Token(Token = "0x200007D")]
	private struct DirectParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000243")]
		internal float x0; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000244")]
		internal float y0; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000245")]
		internal float x1; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000246")]
		internal float y1; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000247")]
		internal float W; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000248")]
		internal float overshootX; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000249")]
		internal float overshootY; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400024A")]
		internal float gamma; //Field offset: 0x1C

	}

	[Token(Token = "0x200007C")]
	private class Segment
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400023D")]
		public float offsetX; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400023E")]
		public float offsetY; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400023F")]
		public float scaleX; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000240")]
		public float scaleY; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000241")]
		public float lnA; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000242")]
		public float B; //Field offset: 0x24

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DD")]
		public Segment() { }

		[Address(RVA = "0x1853C00", Offset = "0x1852E00", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180290410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E750")]
		[Token(Token = "0x60001DC")]
		public float Eval(float x) { }

	}

	[Token(Token = "0x200007E")]
	internal class Uniforms
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400024B")]
		private HableCurve parent; //Field offset: 0x10

		[Token(Token = "0x1700002B")]
		public Vector4 curve
		{
			[Address(RVA = "0x1856190", Offset = "0x1855390", Length = "0x37")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60001DF")]
			 get { } //Length: 55
		}

		[Token(Token = "0x1700002E")]
		public Vector4 midSegmentA
		{
			[Address(RVA = "0x18561D0", Offset = "0x18553D0", Length = "0x56")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60001E2")]
			 get { } //Length: 86
		}

		[Token(Token = "0x1700002F")]
		public Vector4 midSegmentB
		{
			[Address(RVA = "0x1856230", Offset = "0x1855430", Length = "0x49")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60001E3")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000030")]
		public Vector4 shoSegmentA
		{
			[Address(RVA = "0x1856280", Offset = "0x1855480", Length = "0x56")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60001E4")]
			 get { } //Length: 86
		}

		[Token(Token = "0x17000031")]
		public Vector4 shoSegmentB
		{
			[Address(RVA = "0x18562E0", Offset = "0x18554E0", Length = "0x49")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60001E5")]
			 get { } //Length: 73
		}

		[Token(Token = "0x1700002C")]
		public Vector4 toeSegmentA
		{
			[Address(RVA = "0x1856330", Offset = "0x1855530", Length = "0x56")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60001E0")]
			 get { } //Length: 86
		}

		[Token(Token = "0x1700002D")]
		public Vector4 toeSegmentB
		{
			[Address(RVA = "0x1856390", Offset = "0x1855590", Length = "0x49")]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x60001E1")]
			 get { } //Length: 73
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DE")]
		internal Uniforms(HableCurve parent) { }

		[Address(RVA = "0x1856190", Offset = "0x1855390", Length = "0x37")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001DF")]
		public Vector4 get_curve() { }

		[Address(RVA = "0x18561D0", Offset = "0x18553D0", Length = "0x56")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001E2")]
		public Vector4 get_midSegmentA() { }

		[Address(RVA = "0x1856230", Offset = "0x1855430", Length = "0x49")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001E3")]
		public Vector4 get_midSegmentB() { }

		[Address(RVA = "0x1856280", Offset = "0x1855480", Length = "0x56")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001E4")]
		public Vector4 get_shoSegmentA() { }

		[Address(RVA = "0x18562E0", Offset = "0x18554E0", Length = "0x49")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001E5")]
		public Vector4 get_shoSegmentB() { }

		[Address(RVA = "0x1856330", Offset = "0x1855530", Length = "0x56")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001E0")]
		public Vector4 get_toeSegmentA() { }

		[Address(RVA = "0x1856390", Offset = "0x1855590", Length = "0x49")]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60001E1")]
		public Vector4 get_toeSegmentB() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000237")]
	private float <whitePoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000238")]
	private float <inverseWhitePoint>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000239")]
	private float <x0>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400023A")]
	private float <x1>k__BackingField; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023B")]
	private readonly Segment[] m_Segments; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400023C")]
	public readonly Uniforms uniforms; //Field offset: 0x28

	[Token(Token = "0x17000028")]
	public private float inverseWhitePoint
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CF")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1240", Offset = "0x2C0440", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D0")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000027")]
	public private float whitePoint
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CD")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CE")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000029")]
	internal float x0
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D1")]
		internal get { } //Length: 6
		[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D2")]
		private set { } //Length: 6
	}

	[Token(Token = "0x1700002A")]
	internal float x1
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D3")]
		internal get { } //Length: 6
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D4")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x183F490", Offset = "0x183E690", Length = "0x16C")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60001D5")]
	public HableCurve() { }

	[Address(RVA = "0x183EB50", Offset = "0x183DD50", Length = "0x54")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DA")]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	[Address(RVA = "0x183EC00", Offset = "0x183DE00", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180290410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001D6")]
	public float Eval(float x) { }

	[Address(RVA = "0x183EBB0", Offset = "0x183DDB0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Token(Token = "0x60001DB")]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CF")]
	public float get_inverseWhitePoint() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CD")]
	public float get_whitePoint() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D1")]
	internal float get_x0() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D3")]
	internal float get_x1() { }

	[Address(RVA = "0x183F1E0", Offset = "0x183E3E0", Length = "0x240")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E750")]
	[Calls(Type = typeof(HableCurve), Member = "InitSegments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectParams)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001D7")]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	[Address(RVA = "0x183ECA0", Offset = "0x183DEA0", Length = "0x53A")]
	[CalledBy(Type = typeof(HableCurve), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180290410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D8")]
	private void InitSegments(DirectParams srcParams) { }

	[Address(RVA = "0x2C1240", Offset = "0x2C0440", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D0")]
	private void set_inverseWhitePoint(float value) { }

	[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CE")]
	private void set_whitePoint(float value) { }

	[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D2")]
	private void set_x0(float value) { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D4")]
	private void set_x1(float value) { }

	[Address(RVA = "0x183F420", Offset = "0x183E620", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180290410")]
	[Token(Token = "0x60001D9")]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

}

