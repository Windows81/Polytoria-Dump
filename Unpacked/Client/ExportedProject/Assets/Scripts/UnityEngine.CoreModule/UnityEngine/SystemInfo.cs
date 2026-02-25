namespace UnityEngine;

[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[Token(Token = "0x200017F")]
public sealed class SystemInfo
{

	[Token(Token = "0x170001B5")]
	public static CopyTextureSupport copyTextureSupport
	{
		[Address(RVA = "0x1970300", Offset = "0x196F500", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001AC")]
	public static string deviceModel
	{
		[Address(RVA = "0x1970F90", Offset = "0x1970190", Length = "0x9")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "GetDeviceModel", ReturnType = typeof(string))]
		[Token(Token = "0x6000A96")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001AB")]
	public static string deviceName
	{
		[Address(RVA = "0x1970FA0", Offset = "0x19701A0", Length = "0x9")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "GetDeviceName", ReturnType = typeof(string))]
		[Token(Token = "0x6000A95")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001AD")]
	public static DeviceType deviceType
	{
		[Address(RVA = "0x1970510", Offset = "0x196F710", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A97")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001AA")]
	public static string deviceUniqueIdentifier
	{
		[Address(RVA = "0x1970FB0", Offset = "0x19701B0", Length = "0x9")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SystemInfo), Member = "GetDeviceUniqueIdentifier", ReturnType = typeof(string))]
		[Token(Token = "0x6000A94")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001AF")]
	public static string graphicsDeviceName
	{
		[Address(RVA = "0x1970FC0", Offset = "0x19701C0", Length = "0x9")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsDeviceName", ReturnType = typeof(string))]
		[Token(Token = "0x6000A99")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001B0")]
	public static GraphicsDeviceType graphicsDeviceType
	{
		[Address(RVA = "0x1970720", Offset = "0x196F920", Length = "0x2A")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001AE")]
	public static int graphicsMemorySize
	{
		[Address(RVA = "0x1970790", Offset = "0x196F990", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A98")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B2")]
	public static int graphicsShaderLevel
	{
		[Address(RVA = "0x19707C0", Offset = "0x196F9C0", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B1")]
	public static bool graphicsUVStartsAtTop
	{
		[Address(RVA = "0x19707F0", Offset = "0x196F9F0", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001BB")]
	public static long maxGraphicsBufferSize
	{
		[Address(RVA = "0x1970C00", Offset = "0x196FE00", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001BA")]
	internal static int maxRenderTextureSize
	{
		[Address(RVA = "0x1970820", Offset = "0x196FA20", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170001B9")]
	public static int maxTextureSize
	{
		[Address(RVA = "0x1970850", Offset = "0x196FA50", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A4")]
	public static string operatingSystem
	{
		[Address(RVA = "0x1970FD0", Offset = "0x19701D0", Length = "0x9")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SystemInfo), Member = "GetOperatingSystem", ReturnType = typeof(string))]
		[Token(Token = "0x6000A8E")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001A5")]
	public static OperatingSystemFamily operatingSystemFamily
	{
		[Address(RVA = "0x1970880", Offset = "0x196FA80", Length = "0x2A")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A8")]
	public static int processorCount
	{
		[Address(RVA = "0x19709D0", Offset = "0x196FBD0", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A92")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A7")]
	public static int processorFrequency
	{
		[Address(RVA = "0x1970A00", Offset = "0x196FC00", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A91")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A6")]
	public static string processorType
	{
		[Address(RVA = "0x1970FE0", Offset = "0x19701E0", Length = "0x9")]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "GetProcessorType", ReturnType = typeof(string))]
		[Token(Token = "0x6000A90")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001B7")]
	public static int supportedRenderTargetCount
	{
		[Address(RVA = "0x1970C30", Offset = "0x196FE30", Length = "0x2A")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B4")]
	public static bool supports3DRenderTextures
	{
		[Address(RVA = "0x1970C60", Offset = "0x196FE60", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B6")]
	public static bool supportsComputeShaders
	{
		[Address(RVA = "0x1970C90", Offset = "0x196FE90", Length = "0x2A")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B3")]
	public static bool supportsMotionVectors
	{
		[Address(RVA = "0x1970CC0", Offset = "0x196FEC0", Length = "0x2A")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A9")]
	public static int systemMemorySize
	{
		[Address(RVA = "0x19709A0", Offset = "0x196FBA0", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A93")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001BC")]
	public static bool usesLoadStoreActions
	{
		[Address(RVA = "0x1970F30", Offset = "0x1970130", Length = "0x2A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B8")]
	public static bool usesReversedZBuffer
	{
		[Address(RVA = "0x1970F60", Offset = "0x1970160", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA2")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1970300", Offset = "0x196F500", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9F")]
	public static CopyTextureSupport get_copyTextureSupport() { }

	[Address(RVA = "0x1970F90", Offset = "0x1970190", Length = "0x9")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "GetDeviceModel", ReturnType = typeof(string))]
	[Token(Token = "0x6000A96")]
	public static string get_deviceModel() { }

	[Address(RVA = "0x1970FA0", Offset = "0x19701A0", Length = "0x9")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "GetDeviceName", ReturnType = typeof(string))]
	[Token(Token = "0x6000A95")]
	public static string get_deviceName() { }

	[Address(RVA = "0x1970510", Offset = "0x196F710", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A97")]
	public static DeviceType get_deviceType() { }

	[Address(RVA = "0x1970FB0", Offset = "0x19701B0", Length = "0x9")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemInfo), Member = "GetDeviceUniqueIdentifier", ReturnType = typeof(string))]
	[Token(Token = "0x6000A94")]
	public static string get_deviceUniqueIdentifier() { }

	[Address(RVA = "0x1970FC0", Offset = "0x19701C0", Length = "0x9")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsDeviceName", ReturnType = typeof(string))]
	[Token(Token = "0x6000A99")]
	public static string get_graphicsDeviceName() { }

	[Address(RVA = "0x1970720", Offset = "0x196F920", Length = "0x2A")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9A")]
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	[Address(RVA = "0x1970790", Offset = "0x196F990", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A98")]
	public static int get_graphicsMemorySize() { }

	[Address(RVA = "0x19707C0", Offset = "0x196F9C0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9C")]
	public static int get_graphicsShaderLevel() { }

	[Address(RVA = "0x19707F0", Offset = "0x196F9F0", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9B")]
	public static bool get_graphicsUVStartsAtTop() { }

	[Address(RVA = "0x1970C00", Offset = "0x196FE00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA8")]
	public static long get_maxGraphicsBufferSize() { }

	[Address(RVA = "0x1970820", Offset = "0x196FA20", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_maxRenderTextureSize() { }

	[Address(RVA = "0x1970850", Offset = "0x196FA50", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA6")]
	public static int get_maxTextureSize() { }

	[Address(RVA = "0x1970FD0", Offset = "0x19701D0", Length = "0x9")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemInfo), Member = "GetOperatingSystem", ReturnType = typeof(string))]
	[Token(Token = "0x6000A8E")]
	public static string get_operatingSystem() { }

	[Address(RVA = "0x1970880", Offset = "0x196FA80", Length = "0x2A")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8F")]
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	[Address(RVA = "0x19709D0", Offset = "0x196FBD0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A92")]
	public static int get_processorCount() { }

	[Address(RVA = "0x1970A00", Offset = "0x196FC00", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A91")]
	public static int get_processorFrequency() { }

	[Address(RVA = "0x1970FE0", Offset = "0x19701E0", Length = "0x9")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "GetProcessorType", ReturnType = typeof(string))]
	[Token(Token = "0x6000A90")]
	public static string get_processorType() { }

	[Address(RVA = "0x1970C30", Offset = "0x196FE30", Length = "0x2A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA1")]
	public static int get_supportedRenderTargetCount() { }

	[Address(RVA = "0x1970C60", Offset = "0x196FE60", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9E")]
	public static bool get_supports3DRenderTextures() { }

	[Address(RVA = "0x1970C90", Offset = "0x196FE90", Length = "0x2A")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA0")]
	public static bool get_supportsComputeShaders() { }

	[Address(RVA = "0x1970CC0", Offset = "0x196FEC0", Length = "0x2A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9D")]
	public static bool get_supportsMotionVectors() { }

	[Address(RVA = "0x19709A0", Offset = "0x196FBA0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A93")]
	public static int get_systemMemorySize() { }

	[Address(RVA = "0x1970F30", Offset = "0x1970130", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA9")]
	public static bool get_usesLoadStoreActions() { }

	[Address(RVA = "0x1970F60", Offset = "0x1970160", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA2")]
	public static bool get_usesReversedZBuffer() { }

	[Address(RVA = "0x19702C0", Offset = "0x196F4C0", Length = "0x3E")]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	[Token(Token = "0x6000AC5")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[Address(RVA = "0x1970300", Offset = "0x196F500", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	[Token(Token = "0x6000ABB")]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[Address(RVA = "0x1970370", Offset = "0x196F570", Length = "0xA4")]
	[CalledBy(Type = typeof(SystemInfo), Member = "get_deviceModel", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("systeminfo::GetDeviceModel")]
	[Token(Token = "0x6000AB2")]
	private static string GetDeviceModel() { }

	[Address(RVA = "0x1970330", Offset = "0x196F530", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ACC")]
	private static void GetDeviceModel_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1970460", Offset = "0x196F660", Length = "0xA4")]
	[CalledBy(Type = typeof(SystemInfo), Member = "get_deviceName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("systeminfo::GetDeviceName")]
	[Token(Token = "0x6000AB1")]
	private static string GetDeviceName() { }

	[Address(RVA = "0x1970420", Offset = "0x196F620", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ACB")]
	private static void GetDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1970510", Offset = "0x196F710", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetDeviceType")]
	[Token(Token = "0x6000AB3")]
	private static DeviceType GetDeviceType() { }

	[Address(RVA = "0x1970580", Offset = "0x196F780", Length = "0xA4")]
	[CalledBy(Type = typeof(SystemInfo), Member = "get_deviceUniqueIdentifier", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	[Token(Token = "0x6000AB0")]
	private static string GetDeviceUniqueIdentifier() { }

	[Address(RVA = "0x1970540", Offset = "0x196F740", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ACA")]
	private static void GetDeviceUniqueIdentifier_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1970670", Offset = "0x196F870", Length = "0xA4")]
	[CalledBy(Type = typeof(SystemInfo), Member = "get_graphicsDeviceName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	[Token(Token = "0x6000AB5")]
	private static string GetGraphicsDeviceName() { }

	[Address(RVA = "0x1970630", Offset = "0x196F830", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ACD")]
	private static void GetGraphicsDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1970720", Offset = "0x196F920", Length = "0x2A")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	[Token(Token = "0x6000AB6")]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[Address(RVA = "0x1970750", Offset = "0x196F950", Length = "0x31")]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(DefaultFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDefaultColorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDefaultDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat), typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	[Token(Token = "0x6000AC6")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[Address(RVA = "0x1970790", Offset = "0x196F990", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
	[Token(Token = "0x6000AB4")]
	private static int GetGraphicsMemorySize() { }

	[Address(RVA = "0x19707C0", Offset = "0x196F9C0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	[Token(Token = "0x6000AB8")]
	private static int GetGraphicsShaderLevel() { }

	[Address(RVA = "0x19707F0", Offset = "0x196F9F0", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	[Token(Token = "0x6000AB7")]
	private static bool GetGraphicsUVStartsAtTop() { }

	[Address(RVA = "0x1970820", Offset = "0x196FA20", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	[Token(Token = "0x6000AC2")]
	private static int GetMaxRenderTextureSize() { }

	[Address(RVA = "0x1970850", Offset = "0x196FA50", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	[Token(Token = "0x6000AC1")]
	private static int GetMaxTextureSize() { }

	[Address(RVA = "0x19708F0", Offset = "0x196FAF0", Length = "0xA4")]
	[CalledBy(Type = typeof(SystemInfo), Member = "get_operatingSystem", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("systeminfo::GetOperatingSystem")]
	[Token(Token = "0x6000AAA")]
	private static string GetOperatingSystem() { }

	[Address(RVA = "0x19708B0", Offset = "0x196FAB0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AC8")]
	private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1970880", Offset = "0x196FA80", Length = "0x2A")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	[Token(Token = "0x6000AAB")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[Address(RVA = "0x19709A0", Offset = "0x196FBA0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	[Token(Token = "0x6000AAF")]
	private static int GetPhysicalMemoryMB() { }

	[Address(RVA = "0x19709D0", Offset = "0x196FBD0", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetProcessorCount")]
	[Token(Token = "0x6000AAE")]
	private static int GetProcessorCount() { }

	[Address(RVA = "0x1970A00", Offset = "0x196FC00", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetProcessorFrequencyMHz")]
	[Token(Token = "0x6000AAD")]
	private static int GetProcessorFrequencyMHz() { }

	[Address(RVA = "0x1970A70", Offset = "0x196FC70", Length = "0xA4")]
	[CalledBy(Type = typeof(SystemInfo), Member = "get_processorType", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("systeminfo::GetProcessorType")]
	[Token(Token = "0x6000AAC")]
	private static string GetProcessorType() { }

	[Address(RVA = "0x1970A30", Offset = "0x196FC30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AC9")]
	private static void GetProcessorType_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1970B20", Offset = "0x196FD20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	[Token(Token = "0x6000ABF")]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[Address(RVA = "0x1970B60", Offset = "0x196FD60", Length = "0x3E")]
	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.AmbientOcclusion", Member = "IsEnabledAndSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "IsRenderTextureFormatSupportedForLinearFiltering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetLutFormat", ReturnType = typeof(RenderTextureFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.AmbientOcclusion"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	[Token(Token = "0x6000AC4")]
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[Address(RVA = "0x1970BA0", Offset = "0x196FDA0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AA3")]
	private static bool IsValidEnumValue(Enum value) { }

	[Address(RVA = "0x1970C00", Offset = "0x196FE00", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	[Token(Token = "0x6000AC3")]
	private static long MaxGraphicsBufferSize() { }

	[Address(RVA = "0x1970C30", Offset = "0x196FE30", Length = "0x2A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	[Token(Token = "0x6000ABD")]
	private static int SupportedRenderTargetCount() { }

	[Address(RVA = "0x1970C60", Offset = "0x196FE60", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::Supports3DRenderTextures")]
	[Token(Token = "0x6000ABA")]
	private static bool Supports3DRenderTextures() { }

	[Address(RVA = "0x1970C90", Offset = "0x196FE90", Length = "0x2A")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	[Token(Token = "0x6000ABC")]
	private static bool SupportsComputeShaders() { }

	[Address(RVA = "0x1970CC0", Offset = "0x196FEC0", Length = "0x2A")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("SupportsMotionVectors")]
	[Token(Token = "0x6000AB9")]
	private static bool SupportsMotionVectors() { }

	[Address(RVA = "0x1970CF0", Offset = "0x196FEF0", Length = "0xFF")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureFormatUtilities", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AA4")]
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	[Address(RVA = "0x1970E30", Offset = "0x1970030", Length = "0xFF")]
	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetCurveTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGradingRenderer", Member = "GetCurveFormat", ReturnType = typeof(TextureFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.TextureFormatUtilities", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AA5")]
	public static bool SupportsTextureFormat(TextureFormat format) { }

	[Address(RVA = "0x1970DF0", Offset = "0x196FFF0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	[Token(Token = "0x6000AC0")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[Address(RVA = "0x1970F30", Offset = "0x1970130", Length = "0x2A")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	[Token(Token = "0x6000AC7")]
	private static bool UsesLoadStoreActions() { }

	[Address(RVA = "0x1970F60", Offset = "0x1970160", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	[Token(Token = "0x6000ABE")]
	private static bool UsesReversedZBuffer() { }

}

