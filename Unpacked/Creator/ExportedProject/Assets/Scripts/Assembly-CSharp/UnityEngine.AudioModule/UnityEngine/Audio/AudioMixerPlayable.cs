namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000F")]
public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000E")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x19195A0", Offset = "0x19187A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000058")]
	public override bool Equals(AudioMixerPlayable other) { }

	[Address(RVA = "0x1911580", Offset = "0x1910780", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public override PlayableHandle GetHandle() { }

}

