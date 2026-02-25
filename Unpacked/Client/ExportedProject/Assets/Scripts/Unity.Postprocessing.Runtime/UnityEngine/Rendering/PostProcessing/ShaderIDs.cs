namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000089")]
internal static class ShaderIDs
{
	[Token(Token = "0x4000270")]
	internal static readonly int MainTex; //Field offset: 0x0
	[Token(Token = "0x4000271")]
	internal static readonly int Jitter; //Field offset: 0x4
	[Token(Token = "0x4000272")]
	internal static readonly int Sharpness; //Field offset: 0x8
	[Token(Token = "0x4000273")]
	internal static readonly int FinalBlendParameters; //Field offset: 0xC
	[Token(Token = "0x4000274")]
	internal static readonly int HistoryTex; //Field offset: 0x10
	[Token(Token = "0x4000275")]
	internal static readonly int SMAA_Flip; //Field offset: 0x14
	[Token(Token = "0x4000276")]
	internal static readonly int SMAA_Flop; //Field offset: 0x18
	[Token(Token = "0x4000277")]
	internal static readonly int AOParams; //Field offset: 0x1C
	[Token(Token = "0x4000278")]
	internal static readonly int AOColor; //Field offset: 0x20
	[Token(Token = "0x4000279")]
	internal static readonly int OcclusionTexture1; //Field offset: 0x24
	[Token(Token = "0x400027A")]
	internal static readonly int OcclusionTexture2; //Field offset: 0x28
	[Token(Token = "0x400027B")]
	internal static readonly int SAOcclusionTexture; //Field offset: 0x2C
	[Token(Token = "0x400027C")]
	internal static readonly int MSVOcclusionTexture; //Field offset: 0x30
	[Token(Token = "0x400027D")]
	internal static readonly int DepthCopy; //Field offset: 0x34
	[Token(Token = "0x400027E")]
	internal static readonly int LinearDepth; //Field offset: 0x38
	[Token(Token = "0x400027F")]
	internal static readonly int LowDepth1; //Field offset: 0x3C
	[Token(Token = "0x4000280")]
	internal static readonly int LowDepth2; //Field offset: 0x40
	[Token(Token = "0x4000281")]
	internal static readonly int LowDepth3; //Field offset: 0x44
	[Token(Token = "0x4000282")]
	internal static readonly int LowDepth4; //Field offset: 0x48
	[Token(Token = "0x4000283")]
	internal static readonly int TiledDepth1; //Field offset: 0x4C
	[Token(Token = "0x4000284")]
	internal static readonly int TiledDepth2; //Field offset: 0x50
	[Token(Token = "0x4000285")]
	internal static readonly int TiledDepth3; //Field offset: 0x54
	[Token(Token = "0x4000286")]
	internal static readonly int TiledDepth4; //Field offset: 0x58
	[Token(Token = "0x4000287")]
	internal static readonly int Occlusion1; //Field offset: 0x5C
	[Token(Token = "0x4000288")]
	internal static readonly int Occlusion2; //Field offset: 0x60
	[Token(Token = "0x4000289")]
	internal static readonly int Occlusion3; //Field offset: 0x64
	[Token(Token = "0x400028A")]
	internal static readonly int Occlusion4; //Field offset: 0x68
	[Token(Token = "0x400028B")]
	internal static readonly int Combined1; //Field offset: 0x6C
	[Token(Token = "0x400028C")]
	internal static readonly int Combined2; //Field offset: 0x70
	[Token(Token = "0x400028D")]
	internal static readonly int Combined3; //Field offset: 0x74
	[Token(Token = "0x400028E")]
	internal static readonly int SSRResolveTemp; //Field offset: 0x78
	[Token(Token = "0x400028F")]
	internal static readonly int Noise; //Field offset: 0x7C
	[Token(Token = "0x4000290")]
	internal static readonly int Test; //Field offset: 0x80
	[Token(Token = "0x4000291")]
	internal static readonly int Resolve; //Field offset: 0x84
	[Token(Token = "0x4000292")]
	internal static readonly int History; //Field offset: 0x88
	[Token(Token = "0x4000293")]
	internal static readonly int ViewMatrix; //Field offset: 0x8C
	[Token(Token = "0x4000294")]
	internal static readonly int InverseViewMatrix; //Field offset: 0x90
	[Token(Token = "0x4000295")]
	internal static readonly int ScreenSpaceProjectionMatrix; //Field offset: 0x94
	[Token(Token = "0x4000296")]
	internal static readonly int Params2; //Field offset: 0x98
	[Token(Token = "0x4000297")]
	internal static readonly int FogColor; //Field offset: 0x9C
	[Token(Token = "0x4000298")]
	internal static readonly int FogParams; //Field offset: 0xA0
	[Token(Token = "0x4000299")]
	internal static readonly int VelocityScale; //Field offset: 0xA4
	[Token(Token = "0x400029A")]
	internal static readonly int MaxBlurRadius; //Field offset: 0xA8
	[Token(Token = "0x400029B")]
	internal static readonly int RcpMaxBlurRadius; //Field offset: 0xAC
	[Token(Token = "0x400029C")]
	internal static readonly int VelocityTex; //Field offset: 0xB0
	[Token(Token = "0x400029D")]
	internal static readonly int Tile2RT; //Field offset: 0xB4
	[Token(Token = "0x400029E")]
	internal static readonly int Tile4RT; //Field offset: 0xB8
	[Token(Token = "0x400029F")]
	internal static readonly int Tile8RT; //Field offset: 0xBC
	[Token(Token = "0x40002A0")]
	internal static readonly int TileMaxOffs; //Field offset: 0xC0
	[Token(Token = "0x40002A1")]
	internal static readonly int TileMaxLoop; //Field offset: 0xC4
	[Token(Token = "0x40002A2")]
	internal static readonly int TileVRT; //Field offset: 0xC8
	[Token(Token = "0x40002A3")]
	internal static readonly int NeighborMaxTex; //Field offset: 0xCC
	[Token(Token = "0x40002A4")]
	internal static readonly int LoopCount; //Field offset: 0xD0
	[Token(Token = "0x40002A5")]
	internal static readonly int DepthOfFieldTemp; //Field offset: 0xD4
	[Token(Token = "0x40002A6")]
	internal static readonly int DepthOfFieldTex; //Field offset: 0xD8
	[Token(Token = "0x40002A7")]
	internal static readonly int Distance; //Field offset: 0xDC
	[Token(Token = "0x40002A8")]
	internal static readonly int LensCoeff; //Field offset: 0xE0
	[Token(Token = "0x40002A9")]
	internal static readonly int MaxCoC; //Field offset: 0xE4
	[Token(Token = "0x40002AA")]
	internal static readonly int RcpMaxCoC; //Field offset: 0xE8
	[Token(Token = "0x40002AB")]
	internal static readonly int RcpAspect; //Field offset: 0xEC
	[Token(Token = "0x40002AC")]
	internal static readonly int CoCTex; //Field offset: 0xF0
	[Token(Token = "0x40002AD")]
	internal static readonly int TaaParams; //Field offset: 0xF4
	[Token(Token = "0x40002AE")]
	internal static readonly int AutoExposureTex; //Field offset: 0xF8
	[Token(Token = "0x40002AF")]
	internal static readonly int HistogramBuffer; //Field offset: 0xFC
	[Token(Token = "0x40002B0")]
	internal static readonly int Params; //Field offset: 0x100
	[Token(Token = "0x40002B1")]
	internal static readonly int ScaleOffsetRes; //Field offset: 0x104
	[Token(Token = "0x40002B2")]
	internal static readonly int BloomTex; //Field offset: 0x108
	[Token(Token = "0x40002B3")]
	internal static readonly int SampleScale; //Field offset: 0x10C
	[Token(Token = "0x40002B4")]
	internal static readonly int Threshold; //Field offset: 0x110
	[Token(Token = "0x40002B5")]
	internal static readonly int ColorIntensity; //Field offset: 0x114
	[Token(Token = "0x40002B6")]
	internal static readonly int Bloom_DirtTex; //Field offset: 0x118
	[Token(Token = "0x40002B7")]
	internal static readonly int Bloom_Settings; //Field offset: 0x11C
	[Token(Token = "0x40002B8")]
	internal static readonly int Bloom_Color; //Field offset: 0x120
	[Token(Token = "0x40002B9")]
	internal static readonly int Bloom_DirtTileOffset; //Field offset: 0x124
	[Token(Token = "0x40002BA")]
	internal static readonly int ChromaticAberration_Amount; //Field offset: 0x128
	[Token(Token = "0x40002BB")]
	internal static readonly int ChromaticAberration_SpectralLut; //Field offset: 0x12C
	[Token(Token = "0x40002BC")]
	internal static readonly int Distortion_CenterScale; //Field offset: 0x130
	[Token(Token = "0x40002BD")]
	internal static readonly int Distortion_Amount; //Field offset: 0x134
	[Token(Token = "0x40002BE")]
	internal static readonly int Lut2D; //Field offset: 0x138
	[Token(Token = "0x40002BF")]
	internal static readonly int Lut3D; //Field offset: 0x13C
	[Token(Token = "0x40002C0")]
	internal static readonly int Lut3D_Params; //Field offset: 0x140
	[Token(Token = "0x40002C1")]
	internal static readonly int Lut2D_Params; //Field offset: 0x144
	[Token(Token = "0x40002C2")]
	internal static readonly int UserLut2D_Params; //Field offset: 0x148
	[Token(Token = "0x40002C3")]
	internal static readonly int PostExposure; //Field offset: 0x14C
	[Token(Token = "0x40002C4")]
	internal static readonly int ColorBalance; //Field offset: 0x150
	[Token(Token = "0x40002C5")]
	internal static readonly int ColorFilter; //Field offset: 0x154
	[Token(Token = "0x40002C6")]
	internal static readonly int HueSatCon; //Field offset: 0x158
	[Token(Token = "0x40002C7")]
	internal static readonly int Brightness; //Field offset: 0x15C
	[Token(Token = "0x40002C8")]
	internal static readonly int ChannelMixerRed; //Field offset: 0x160
	[Token(Token = "0x40002C9")]
	internal static readonly int ChannelMixerGreen; //Field offset: 0x164
	[Token(Token = "0x40002CA")]
	internal static readonly int ChannelMixerBlue; //Field offset: 0x168
	[Token(Token = "0x40002CB")]
	internal static readonly int Lift; //Field offset: 0x16C
	[Token(Token = "0x40002CC")]
	internal static readonly int InvGamma; //Field offset: 0x170
	[Token(Token = "0x40002CD")]
	internal static readonly int Gain; //Field offset: 0x174
	[Token(Token = "0x40002CE")]
	internal static readonly int Curves; //Field offset: 0x178
	[Token(Token = "0x40002CF")]
	internal static readonly int CustomToneCurve; //Field offset: 0x17C
	[Token(Token = "0x40002D0")]
	internal static readonly int ToeSegmentA; //Field offset: 0x180
	[Token(Token = "0x40002D1")]
	internal static readonly int ToeSegmentB; //Field offset: 0x184
	[Token(Token = "0x40002D2")]
	internal static readonly int MidSegmentA; //Field offset: 0x188
	[Token(Token = "0x40002D3")]
	internal static readonly int MidSegmentB; //Field offset: 0x18C
	[Token(Token = "0x40002D4")]
	internal static readonly int ShoSegmentA; //Field offset: 0x190
	[Token(Token = "0x40002D5")]
	internal static readonly int ShoSegmentB; //Field offset: 0x194
	[Token(Token = "0x40002D6")]
	internal static readonly int Vignette_Color; //Field offset: 0x198
	[Token(Token = "0x40002D7")]
	internal static readonly int Vignette_Center; //Field offset: 0x19C
	[Token(Token = "0x40002D8")]
	internal static readonly int Vignette_Settings; //Field offset: 0x1A0
	[Token(Token = "0x40002D9")]
	internal static readonly int Vignette_Mask; //Field offset: 0x1A4
	[Token(Token = "0x40002DA")]
	internal static readonly int Vignette_Opacity; //Field offset: 0x1A8
	[Token(Token = "0x40002DB")]
	internal static readonly int Vignette_Mode; //Field offset: 0x1AC
	[Token(Token = "0x40002DC")]
	internal static readonly int Grain_Params1; //Field offset: 0x1B0
	[Token(Token = "0x40002DD")]
	internal static readonly int Grain_Params2; //Field offset: 0x1B4
	[Token(Token = "0x40002DE")]
	internal static readonly int GrainTex; //Field offset: 0x1B8
	[Token(Token = "0x40002DF")]
	internal static readonly int Phase; //Field offset: 0x1BC
	[Token(Token = "0x40002E0")]
	internal static readonly int GrainNoiseParameters; //Field offset: 0x1C0
	[Token(Token = "0x40002E1")]
	internal static readonly int LumaInAlpha; //Field offset: 0x1C4
	[Token(Token = "0x40002E2")]
	internal static readonly int DitheringTex; //Field offset: 0x1C8
	[Token(Token = "0x40002E3")]
	internal static readonly int Dithering_Coords; //Field offset: 0x1CC
	[Token(Token = "0x40002E4")]
	internal static readonly int From; //Field offset: 0x1D0
	[Token(Token = "0x40002E5")]
	internal static readonly int To; //Field offset: 0x1D4
	[Token(Token = "0x40002E6")]
	internal static readonly int Interp; //Field offset: 0x1D8
	[Token(Token = "0x40002E7")]
	internal static readonly int TargetColor; //Field offset: 0x1DC
	[Token(Token = "0x40002E8")]
	internal static readonly int HalfResFinalCopy; //Field offset: 0x1E0
	[Token(Token = "0x40002E9")]
	internal static readonly int WaveformSource; //Field offset: 0x1E4
	[Token(Token = "0x40002EA")]
	internal static readonly int WaveformBuffer; //Field offset: 0x1E8
	[Token(Token = "0x40002EB")]
	internal static readonly int VectorscopeBuffer; //Field offset: 0x1EC
	[Token(Token = "0x40002EC")]
	internal static readonly int RenderViewportScaleFactor; //Field offset: 0x1F0
	[Token(Token = "0x40002ED")]
	internal static readonly int UVTransform; //Field offset: 0x1F4
	[Token(Token = "0x40002EE")]
	internal static readonly int DepthSlice; //Field offset: 0x1F8
	[Token(Token = "0x40002EF")]
	internal static readonly int UVScaleOffset; //Field offset: 0x1FC
	[Token(Token = "0x40002F0")]
	internal static readonly int PosScaleOffset; //Field offset: 0x200

	[Address(RVA = "0x1853C50", Offset = "0x1852E50", Length = "0x16F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x600024C")]
	private static ShaderIDs() { }

}

