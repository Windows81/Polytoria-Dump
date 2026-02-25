//Type is in global namespace

[Token(Token = "0x2000006")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000007")]
	internal enum LeanAudioWaveStyle
	{
		Sine = 0,
		Square = 1,
		Sawtooth = 2,
		Noise = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000D")]
	public LeanAudioWaveStyle waveStyle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000E")]
	public Vector3[] vibrato; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000F")]
	public Vector3[] modulation; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000010")]
	public int frequencyRate; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000011")]
	public float waveNoiseScale; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000012")]
	public float waveNoiseInfluence; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000013")]
	public bool useSetData; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000014")]
	public LeanAudioStream stream; //Field offset: 0x38

	[Address(RVA = "0x2C32A0", Offset = "0x2C24A0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	public LeanAudioOptions() { }

	[Address(RVA = "0x2C32C0", Offset = "0x2C24C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000020")]
	public LeanAudioOptions setFrequency(int frequencyRate) { }

	[Address(RVA = "0x2C32D0", Offset = "0x2C24D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000021")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato) { }

	[Address(RVA = "0x2C3310", Offset = "0x2C2510", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000025")]
	public LeanAudioOptions setWaveNoise() { }

	[Address(RVA = "0x2C32F0", Offset = "0x2C24F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000028")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence) { }

	[Address(RVA = "0x2C3300", Offset = "0x2C2500", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000027")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale) { }

	[Address(RVA = "0x2C3320", Offset = "0x2C2520", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000024")]
	public LeanAudioOptions setWaveSawtooth() { }

	[Address(RVA = "0x2C3330", Offset = "0x2C2530", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000022")]
	public LeanAudioOptions setWaveSine() { }

	[Address(RVA = "0x2C3340", Offset = "0x2C2540", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000023")]
	public LeanAudioOptions setWaveSquare() { }

	[Address(RVA = "0x2C3350", Offset = "0x2C2550", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000026")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style) { }

}

