namespace UnityEngineInternal.Input;

[NativeHeader("Modules/Input/Private/InputInternal.h")]
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
[Token(Token = "0x2000005")]
internal class NativeInputSystem
{
	[Token(Token = "0x400000B")]
	public static NativeUpdateCallback onUpdate; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	public static Action<NativeInputUpdateType> onBeforeUpdate; //Field offset: 0x8
	[Token(Token = "0x400000D")]
	public static Func<NativeInputUpdateType, Boolean> onShouldRunUpdate; //Field offset: 0x10
	[Token(Token = "0x400000E")]
	private static Action<Int32, String> s_OnDeviceDiscoveredCallback; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	internal static bool hasDeviceDiscoveredCallback
	{
		[Address(RVA = "0x19DC400", Offset = "0x19DB600", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000008")]
		internal set { } //Length: 51
	}

	[Address(RVA = "0x19DC3D0", Offset = "0x19DB5D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	private static NativeInputSystem() { }

	[Address(RVA = "0x19DC1B0", Offset = "0x19DB3B0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000004")]
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[Address(RVA = "0x19DC220", Offset = "0x19DB420", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000006")]
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[Address(RVA = "0x19DC2A0", Offset = "0x19DB4A0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000005")]
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[Address(RVA = "0x19DC400", Offset = "0x19DB600", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

	[Address(RVA = "0x19DC340", Offset = "0x19DB540", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000007")]
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

}

