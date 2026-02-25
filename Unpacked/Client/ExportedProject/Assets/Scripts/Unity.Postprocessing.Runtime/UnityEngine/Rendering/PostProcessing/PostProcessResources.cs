namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000075")]
public sealed class PostProcessResources : ScriptableObject
{
	[Token(Token = "0x2000077")]
	internal sealed class ComputeShaders
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000219")]
		public ComputeShader autoExposure; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400021A")]
		public ComputeShader exposureHistogram; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400021B")]
		public ComputeShader lut3DBaker; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400021C")]
		public ComputeShader texture3dLerp; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400021D")]
		public ComputeShader gammaHistogram; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400021E")]
		public ComputeShader waveform; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400021F")]
		public ComputeShader vectorscope; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000220")]
		public ComputeShader multiScaleAODownsample1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000221")]
		public ComputeShader multiScaleAODownsample2; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000222")]
		public ComputeShader multiScaleAORender; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000223")]
		public ComputeShader multiScaleAOUpsample; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000224")]
		public ComputeShader gaussianDownsample; //Field offset: 0x68

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B7")]
		public ComputeShaders() { }

		[Address(RVA = "0x183EA90", Offset = "0x183DC90", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001B6")]
		public ComputeShaders Clone() { }

	}

	[Token(Token = "0x2000076")]
	internal sealed class Shaders
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000201")]
		public Shader bloom; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000202")]
		public Shader copy; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000203")]
		public Shader copyStd; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000204")]
		public Shader copyStdFromTexArray; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000205")]
		public Shader copyStdFromDoubleWide; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000206")]
		public Shader discardAlpha; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000207")]
		public Shader depthOfField; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000208")]
		public Shader finalPass; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000209")]
		public Shader grainBaker; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400020A")]
		public Shader motionBlur; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400020B")]
		public Shader temporalAntialiasing; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400020C")]
		public Shader subpixelMorphologicalAntialiasing; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400020D")]
		public Shader texture2dLerp; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400020E")]
		public Shader uber; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400020F")]
		public Shader lut2DBaker; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000210")]
		public Shader lightMeter; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000211")]
		public Shader gammaHistogram; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000212")]
		public Shader waveform; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000213")]
		public Shader vectorscope; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000214")]
		public Shader debugOverlays; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000215")]
		public Shader deferredFog; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000216")]
		public Shader scalableAO; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000217")]
		public Shader multiScaleAO; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000218")]
		public Shader screenSpaceReflections; //Field offset: 0xC8

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B5")]
		public Shaders() { }

		[Address(RVA = "0x1855350", Offset = "0x1854550", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001B4")]
		public Shaders Clone() { }

	}

	[Token(Token = "0x2000078")]
	internal sealed class SMAALuts
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000225")]
		public Texture2D area; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000226")]
		public Texture2D search; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B8")]
		public SMAALuts() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FC")]
	public Texture2D[] blueNoise64; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FD")]
	public Texture2D[] blueNoise256; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FE")]
	public SMAALuts smaaLuts; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FF")]
	public Shaders shaders; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000200")]
	public ComputeShaders computeShaders; //Field offset: 0x38

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B3")]
	public PostProcessResources() { }

}

