namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioListenerBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000009")]
public sealed class AudioListener : AudioBehaviour
{

	[Token(Token = "0x17000005")]
	public static float volume
	{
		[Address(RVA = "0x1919530", Offset = "0x1918730", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadAudioControls", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		 get { } //Length: 42
		[Address(RVA = "0x1919560", Offset = "0x1918760", Length = "0x3A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetMasterVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000029")]
		 set { } //Length: 58
	}

	[Address(RVA = "0x1919530", Offset = "0x1918730", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadAudioControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	public static float get_volume() { }

	[Address(RVA = "0x1919560", Offset = "0x1918760", Length = "0x3A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetMasterVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	public static void set_volume(float value) { }

}

