namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000005")]
public sealed class AudioClip : AudioResource
{
	[Token(Token = "0x2000006")]
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000023")]
		public PCMReaderCallback(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000024")]
		public override void Invoke(Single[] data) { }

	}

	[Token(Token = "0x2000007")]
	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		public PCMSetPositionCallback(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000026")]
		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000009")]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000A")]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x20

	[Token(Token = "0x14000001")]
	private event PCMReaderCallback m_PCMReaderCallback
	{
		[Address(RVA = "0x1918FB0", Offset = "0x19181B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000014")]
		private add { } //Length: 158
		[Address(RVA = "0x19193F0", Offset = "0x19185F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000015")]
		private remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	private event PCMSetPositionCallback m_PCMSetPositionCallback
	{
		[Address(RVA = "0x1919050", Offset = "0x1918250", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000016")]
		private add { } //Length: 158
		[Address(RVA = "0x1919490", Offset = "0x1918690", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000017")]
		private remove { } //Length: 158
	}

	[NativeProperty("ChannelCount")]
	[Token(Token = "0x17000003")]
	public int channels
	{
		[Address(RVA = "0x1919130", Offset = "0x1918330", Length = "0x76")]
		[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000E")]
		 get { } //Length: 118
	}

	[NativeProperty("LengthSec")]
	[Token(Token = "0x17000001")]
	public float length
	{
		[Address(RVA = "0x19191F0", Offset = "0x19183F0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "get_Length", ReturnType = typeof(float))]
		[CalledBy(Type = "LeanAudio", Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000004")]
	public AudioDataLoadState loadState
	{
		[Address(RVA = "0x19192B0", Offset = "0x19184B0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
		[Token(Token = "0x600000F")]
		 get { } //Length: 118
	}

	[NativeProperty("SampleCount")]
	[Token(Token = "0x17000002")]
	public int samples
	{
		[Address(RVA = "0x1919370", Offset = "0x1918570", Length = "0x76")]
		[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000D")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x1918F40", Offset = "0x1918140", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	private AudioClip() { }

	[Address(RVA = "0x1918FB0", Offset = "0x19181B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000014")]
	private void add_m_PCMReaderCallback(PCMReaderCallback value) { }

	[Address(RVA = "0x1919050", Offset = "0x1918250", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000016")]
	private void add_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	[Address(RVA = "0x1917F10", Offset = "0x1917110", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	private static AudioClip Construct_Internal() { }

	[Address(RVA = "0x1917EE0", Offset = "0x19170E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001C")]
	private static IntPtr Construct_Internal_Injected() { }

	[Address(RVA = "0x19184F0", Offset = "0x19176F0", Length = "0x28")]
	[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = typeof(AudioClip))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(PCMReaderCallback), typeof(PCMSetPositionCallback)}, ReturnType = typeof(AudioClip))]
	[Token(Token = "0x6000012")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Address(RVA = "0x19181D0", Offset = "0x19173D0", Length = "0x31C")]
	[CalledBy(Type = "LeanAudio", Member = "createAudioFromWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "LeanAudioOptions"}, ReturnType = typeof(AudioClip))]
	[CalledBy(Type = typeof(AudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(AudioClip))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(AudioClip), Member = "CreateUserSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) { }

	[Address(RVA = "0x1917FE0", Offset = "0x19171E0", Length = "0x1E6")]
	[CalledBy(Type = typeof(AudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(PCMReaderCallback), typeof(PCMSetPositionCallback)}, ReturnType = typeof(AudioClip))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Address(RVA = "0x1917F70", Offset = "0x1917170", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	private static void CreateUserSound_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Address(RVA = "0x1919130", Offset = "0x1918330", Length = "0x76")]
	[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public int get_channels() { }

	[Address(RVA = "0x19190F0", Offset = "0x19182F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	private static int get_channels_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19191F0", Offset = "0x19183F0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "get_Length", ReturnType = typeof(float))]
	[CalledBy(Type = "LeanAudio", Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public float get_length() { }

	[Address(RVA = "0x19191B0", Offset = "0x19183B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	private static float get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19192B0", Offset = "0x19184B0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	[Token(Token = "0x600000F")]
	public AudioDataLoadState get_loadState() { }

	[Address(RVA = "0x1919270", Offset = "0x1918470", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	private static AudioDataLoadState get_loadState_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1919370", Offset = "0x1918570", Length = "0x76")]
	[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public int get_samples() { }

	[Address(RVA = "0x1919330", Offset = "0x1918530", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	private static int get_samples_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19187B0", Offset = "0x19179B0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	private static bool GetData(AudioClip clip, Span<Single> data, int samplesOffset) { }

	[Address(RVA = "0x1918580", Offset = "0x1917780", Length = "0x224")]
	[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AudioClip), Member = "GetName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000010")]
	public bool GetData(Single[] data, int offsetSamples) { }

	[Address(RVA = "0x1918520", Offset = "0x1917720", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	private static bool GetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset) { }

	[Address(RVA = "0x1918920", Offset = "0x1917B20", Length = "0x106")]
	[CalledBy(Type = typeof(AudioClip), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AudioClip), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	private string GetName() { }

	[Address(RVA = "0x19188D0", Offset = "0x1917AD0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1918A30", Offset = "0x1917C30", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000018")]
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	[Address(RVA = "0x1918A50", Offset = "0x1917C50", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000019")]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	[Address(RVA = "0x19193F0", Offset = "0x19185F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000015")]
	private void remove_m_PCMReaderCallback(PCMReaderCallback value) { }

	[Address(RVA = "0x1919490", Offset = "0x1918690", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000017")]
	private void remove_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	[Address(RVA = "0x1918AD0", Offset = "0x1917CD0", Length = "0x344")]
	[CalledBy(Type = "LeanAudio", Member = "createAudioFromWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "LeanAudioOptions"}, ReturnType = typeof(AudioClip))]
	[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = typeof(AudioClip))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AudioClip), Member = "GetName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000011")]
	public bool SetData(Single[] data, int offsetSamples) { }

	[Address(RVA = "0x1918E20", Offset = "0x1918020", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	private static bool SetData(AudioClip clip, ReadOnlySpan<Single> data, int samplesOffset) { }

	[Address(RVA = "0x1918A70", Offset = "0x1917C70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	private static bool SetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset) { }

}

