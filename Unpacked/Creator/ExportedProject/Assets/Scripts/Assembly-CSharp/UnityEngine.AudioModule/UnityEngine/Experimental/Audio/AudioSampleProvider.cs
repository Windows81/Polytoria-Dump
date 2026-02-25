namespace UnityEngine.Experimental.Audio;

[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000B")]
public class AudioSampleProvider
{
	[Token(Token = "0x200000C")]
	internal sealed class SampleFramesHandler : MulticastDelegate
	{

		[Address(RVA = "0xA32F00", Offset = "0xA32100", Length = "0x125")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000052")]
		public SampleFramesHandler(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000053")]
		public override void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	private SampleFramesHandler sampleFramesAvailable; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000C")]
	private SampleFramesHandler sampleFramesOverflow; //Field offset: 0x18

	[Address(RVA = "0x1919670", Offset = "0x1918870", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000050")]
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[Address(RVA = "0x19196A0", Offset = "0x19188A0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000051")]
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

