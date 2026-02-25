//Type is in global namespace

[Token(Token = "0x2000005")]
public class LeanAudio
{
	[Token(Token = "0x4000008")]
	public static float MIN_FREQEUNCY_PERIOD; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	public static int PROCESSING_ITERATIONS_MAX; //Field offset: 0x4
	[Token(Token = "0x400000A")]
	public static Single[] generatedWaveDistances; //Field offset: 0x8
	[Token(Token = "0x400000B")]
	public static int generatedWaveDistancesCount; //Field offset: 0x10
	[Token(Token = "0x400000C")]
	private static Single[] longList; //Field offset: 0x18

	[Address(RVA = "0x2C3420", Offset = "0x2C2620", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600001E")]
	private static LeanAudio() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public LeanAudio() { }

	[Address(RVA = "0x2C40A0", Offset = "0x2C32A0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000012")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null) { }

	[Address(RVA = "0x2C3490", Offset = "0x2C2690", Length = "0x652")]
	[CalledBy(Type = typeof(LeanAudio), Member = "createAudioStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), typeof(LeanAudioOptions)}, ReturnType = typeof(LeanAudioStream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(PCMReaderCallback), typeof(PCMSetPositionCallback)}, ReturnType = typeof(AudioClip))]
	[Calls(Type = typeof(AudioClip), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000014")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options) { }

	[Address(RVA = "0x2C3AF0", Offset = "0x2C2CF0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanAudio), Member = "createAudioWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), typeof(LeanAudioOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LeanAudio), Member = "createAudioFromWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LeanAudioOptions)}, ReturnType = typeof(AudioClip))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null) { }

	[Address(RVA = "0x2C3BC0", Offset = "0x2C2DC0", Length = "0x4DC")]
	[CalledBy(Type = typeof(LeanAudio), Member = "createAudioStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), typeof(LeanAudioOptions)}, ReturnType = typeof(LeanAudioStream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnimationCurve), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options) { }

	[Address(RVA = "0x2C4160", Offset = "0x2C3360", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnimationCurve), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(AudioClip))]
	[Calls(Type = typeof(AudioClip), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000016")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	private static void OnAudioSetPosition(int newPosition) { }

	[Address(RVA = "0x2C4300", Offset = "0x2C3500", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public static LeanAudioOptions options() { }

	[Address(RVA = "0x2C46A0", Offset = "0x2C38A0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanAudio), Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000017")]
	public static AudioSource play(AudioClip audio, float volume) { }

	[Address(RVA = "0x2C4770", Offset = "0x2C3970", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanAudio), Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[Token(Token = "0x6000018")]
	public static AudioSource play(AudioClip audio) { }

	[Address(RVA = "0x2C4630", Offset = "0x2C3830", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanAudio), Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[Token(Token = "0x6000019")]
	public static AudioSource play(AudioClip audio, Vector3 pos) { }

	[Address(RVA = "0x2C4580", Offset = "0x2C3780", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanAudio), Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[Calls(Type = typeof(AudioSource), Member = "set_minDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001A")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume) { }

	[Address(RVA = "0x2C4450", Offset = "0x2C3650", Length = "0x125")]
	[CalledBy(Type = typeof(LeanAudio), Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(float)}, ReturnType = typeof(AudioSource))]
	[CalledBy(Type = typeof(LeanAudio), Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(AudioSource))]
	[CalledBy(Type = typeof(LeanAudio), Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[CalledBy(Type = typeof(LeanAudio), Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3), typeof(float)}, ReturnType = typeof(AudioSource))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[Calls(Type = typeof(AudioSource), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos) { }

	[Address(RVA = "0x2C4810", Offset = "0x2C3A10", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AudioClip), Member = "get_samples", ReturnType = typeof(int))]
	[Calls(Type = typeof(AudioClip), Member = "get_channels", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(AudioClip), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600001C")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1) { }

}

