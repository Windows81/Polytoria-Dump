namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000A")]
public sealed class AudioSource : AudioBehaviour
{

	[Token(Token = "0x17000009")]
	public AudioClip clip
	{
		[Address(RVA = "0x191A290", Offset = "0x1919490", Length = "0xD1")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000033")]
		 get { } //Length: 209
		[Address(RVA = "0x191A690", Offset = "0x1919890", Length = "0xBA")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000034")]
		 set { } //Length: 186
	}

	[Token(Token = "0x1700000B")]
	public bool isPlaying
	{
		[Address(RVA = "0x191A3B0", Offset = "0x19195B0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("IsPlayingScripting")]
		[Token(Token = "0x600003A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000C")]
	public bool loop
	{
		[Address(RVA = "0x191A7A0", Offset = "0x19199A0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "UserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000F")]
	public float maxDistance
	{
		[Address(RVA = "0x191A880", Offset = "0x1919A80", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_MaxDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003F")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000E")]
	public float minDistance
	{
		[Address(RVA = "0x191A960", Offset = "0x1919B60", Length = "0x86")]
		[CalledBy(Type = "LeanAudio", Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3), typeof(float)}, ReturnType = typeof(AudioSource))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003E")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000007")]
	public float pitch
	{
		[Address(RVA = "0x191A080", Offset = "0x1919280", Length = "0xAB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000030")]
		 set { } //Length: 171
	}

	[Token(Token = "0x1700000A")]
	public AudioResource resource
	{
		[Address(RVA = "0x191A470", Offset = "0x1919670", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000035")]
		 get { } //Length: 144
		[Address(RVA = "0x191A690", Offset = "0x1919890", Length = "0xBA")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		 set { } //Length: 186
	}

	[NativeProperty("SpatialBlendMix")]
	[Token(Token = "0x1700000D")]
	public float spatialBlend
	{
		[Address(RVA = "0x191AA90", Offset = "0x1919C90", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_PlayInWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "UserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600003D")]
		 set { } //Length: 134
	}

	[NativeProperty("SecPosition")]
	[Token(Token = "0x17000008")]
	public float time
	{
		[Address(RVA = "0x191A550", Offset = "0x1919750", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "get_Time", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000031")]
		 get { } //Length: 118
		[Address(RVA = "0x191AB70", Offset = "0x1919D70", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "UserCode_RpcJumpSound", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "InvokeUserCode_RpcJumpSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoJumpSound", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_Time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000032")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000006")]
	public float volume
	{
		[Address(RVA = "0x191A610", Offset = "0x1919810", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "get_Volume", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002E")]
		 get { } //Length: 118
		[Address(RVA = "0x191AC50", Offset = "0x1919E50", Length = "0xD8")]
		[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_Volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "LeanAudio", Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(float)}, ReturnType = typeof(AudioSource))]
		[CalledBy(Type = "LeanAudio", Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3), typeof(float)}, ReturnType = typeof(AudioSource))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x600002F")]
		 set { } //Length: 216
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public AudioSource() { }

	[Address(RVA = "0x191A290", Offset = "0x1919490", Length = "0xD1")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	public AudioClip get_clip() { }

	[Address(RVA = "0x191A3B0", Offset = "0x19195B0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsPlayingScripting")]
	[Token(Token = "0x600003A")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x191A370", Offset = "0x1919570", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x191A470", Offset = "0x1919670", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000035")]
	public AudioResource get_resource() { }

	[Address(RVA = "0x191A430", Offset = "0x1919630", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	private static IntPtr get_resource_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x191A550", Offset = "0x1919750", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "get_Time", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000031")]
	public float get_time() { }

	[Address(RVA = "0x191A510", Offset = "0x1919710", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	private static float get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x191A610", Offset = "0x1919810", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "get_Volume", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	public float get_volume() { }

	[Address(RVA = "0x191A5D0", Offset = "0x19197D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	private static float get_volume_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1919F90", Offset = "0x1919190", Length = "0x9D")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "UserCode_RpcJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "InvokeUserCode_RpcJumpSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<GetAudioClip>d__39", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<playC>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "LeanAudio", Member = "playClipAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3)}, ReturnType = typeof(AudioSource))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000037")]
	public void Play() { }

	[Address(RVA = "0x19197D0", Offset = "0x19189D0", Length = "0x39F")]
	[CalledBy(Type = "LTDescr", Member = "callOnCompletes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_timeScale", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600003B")]
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	[Address(RVA = "0x1919BC0", Offset = "0x1918DC0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	private static void PlayHelper(AudioSource source, ulong delay) { }

	[Address(RVA = "0x1919B70", Offset = "0x1918D70", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	private static void PlayHelper_Injected(IntPtr source, ulong delay) { }

	[Address(RVA = "0x1919DE0", Offset = "0x1918FE0", Length = "0x1A4")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoFootstep", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "PlayOneShot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "UserCode_RpcPlayOneShot__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "InvokeUserCode_RpcPlayOneShot__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	[Address(RVA = "0x1919CD0", Offset = "0x1918ED0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	[Address(RVA = "0x1919C70", Offset = "0x1918E70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	[Address(RVA = "0x191A690", Offset = "0x1919890", Length = "0xBA")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public void set_clip(AudioClip value) { }

	[Address(RVA = "0x191A7A0", Offset = "0x19199A0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "UserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	public void set_loop(bool value) { }

	[Address(RVA = "0x191A750", Offset = "0x1919950", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x191A880", Offset = "0x1919A80", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_MaxDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	public void set_maxDistance(float value) { }

	[Address(RVA = "0x191A830", Offset = "0x1919A30", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004F")]
	private static void set_maxDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x191A960", Offset = "0x1919B60", Length = "0x86")]
	[CalledBy(Type = "LeanAudio", Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3), typeof(float)}, ReturnType = typeof(AudioSource))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	public void set_minDistance(float value) { }

	[Address(RVA = "0x191A910", Offset = "0x1919B10", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	private static void set_minDistance_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x191A080", Offset = "0x1919280", Length = "0xAB")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public void set_pitch(float value) { }

	[Address(RVA = "0x191A690", Offset = "0x1919890", Length = "0xBA")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public void set_resource(AudioResource value) { }

	[Address(RVA = "0x191A9F0", Offset = "0x1919BF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	private static void set_resource_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x191AA90", Offset = "0x1919C90", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_PlayInWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "UserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	public void set_spatialBlend(float value) { }

	[Address(RVA = "0x191AA40", Offset = "0x1919C40", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	private static void set_spatialBlend_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x191AB70", Offset = "0x1919D70", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "UserCode_RpcJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "InvokeUserCode_RpcJumpSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_Time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	public void set_time(float value) { }

	[Address(RVA = "0x191AB20", Offset = "0x1919D20", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x191AC50", Offset = "0x1919E50", Length = "0xD8")]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "set_Volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LeanAudio", Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(float)}, ReturnType = typeof(AudioSource))]
	[CalledBy(Type = "LeanAudio", Member = "play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(Vector3), typeof(float)}, ReturnType = typeof(AudioSource))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600002F")]
	public void set_volume(float value) { }

	[Address(RVA = "0x191AC00", Offset = "0x1919E00", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x191A080", Offset = "0x1919280", Length = "0xAB")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	private static void SetPitch(AudioSource source, float pitch) { }

	[Address(RVA = "0x191A030", Offset = "0x1919230", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	[Address(RVA = "0x191A180", Offset = "0x1919380", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "UserCode_RpcJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "InvokeUserCode_RpcJumpSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound+<GetAudioClip>d__39", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "UserCode_RpcStop", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Sound", Member = "InvokeUserCode_RpcStop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public void Stop() { }

	[Address(RVA = "0x191A200", Offset = "0x1919400", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	private void Stop(bool stopOneShots) { }

	[Address(RVA = "0x191A130", Offset = "0x1919330", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

}

