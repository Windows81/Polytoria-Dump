namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000340")]
public static class RemotingConfiguration
{
	[Token(Token = "0x4000DD3")]
	private static string applicationID; //Field offset: 0x0
	[Token(Token = "0x4000DD4")]
	private static string applicationName; //Field offset: 0x8
	[Token(Token = "0x4000DD5")]
	private static string processGuid; //Field offset: 0x10
	[Token(Token = "0x4000DD6")]
	private static bool defaultConfigRead; //Field offset: 0x18
	[Token(Token = "0x4000DD7")]
	private static bool defaultDelayedConfigRead; //Field offset: 0x19
	[Token(Token = "0x4000DD8")]
	private static CustomErrorsModes _errorMode; //Field offset: 0x1C
	[Token(Token = "0x4000DD9")]
	private static Hashtable wellKnownClientEntries; //Field offset: 0x20
	[Token(Token = "0x4000DDA")]
	private static Hashtable activatedClientEntries; //Field offset: 0x28
	[Token(Token = "0x4000DDB")]
	private static Hashtable wellKnownServiceEntries; //Field offset: 0x30
	[Token(Token = "0x4000DDC")]
	private static Hashtable activatedServiceEntries; //Field offset: 0x38
	[Token(Token = "0x4000DDD")]
	private static Hashtable channelTemplates; //Field offset: 0x40
	[Token(Token = "0x4000DDE")]
	private static Hashtable clientProviderTemplates; //Field offset: 0x48
	[Token(Token = "0x4000DDF")]
	private static Hashtable serverProviderTemplates; //Field offset: 0x50

	[Token(Token = "0x170002CE")]
	public static string ApplicationName
	{
		[Address(RVA = "0x136E9C0", Offset = "0x136DBC0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60019F5")]
		 get { } //Length: 79
		[Address(RVA = "0x136EAF0", Offset = "0x136DCF0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60019F6")]
		 set { } //Length: 110
	}

	[Token(Token = "0x170002CF")]
	public static string ProcessId
	{
		[Address(RVA = "0x136EA10", Offset = "0x136DC10", Length = "0xDB")]
		[CalledBy(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60019F7")]
		 get { } //Length: 219
	}

	[Address(RVA = "0x136E6F0", Offset = "0x136D8F0", Length = "0x2CB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001A07")]
	private static RemotingConfiguration() { }

	[Address(RVA = "0x136C6B0", Offset = "0x136B8B0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001A05")]
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	[Address(RVA = "0x136E9C0", Offset = "0x136DBC0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60019F5")]
	public static string get_ApplicationName() { }

	[Address(RVA = "0x136EA10", Offset = "0x136DC10", Length = "0xDB")]
	[CalledBy(Type = typeof(CrossAppDomainData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "CreateMessageSink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60019F7")]
	public static string get_ProcessId() { }

	[Address(RVA = "0x136C740", Offset = "0x136B940", Length = "0x124")]
	[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019F9")]
	public static bool IsActivationAllowed(Type svrType) { }

	[Address(RVA = "0x136C870", Offset = "0x136BA70", Length = "0x177")]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019FA")]
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	[Address(RVA = "0x136C9F0", Offset = "0x136BBF0", Length = "0x177")]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019FB")]
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	[Address(RVA = "0x136CB70", Offset = "0x136BD70", Length = "0x33B")]
	[CalledBy(Type = typeof(ChannelServices), Member = "CreateClientChannelSinkChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(String&)}, ReturnType = typeof(IMessageSink))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "GetMachineConfigPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60019F8")]
	internal static void LoadDefaultDelayedChannels() { }

	[Address(RVA = "0x136CEB0", Offset = "0x136C0B0", Length = "0x282")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C520")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60019FC")]
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	[Address(RVA = "0x136D140", Offset = "0x136C340", Length = "0x120")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019FD")]
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	[Address(RVA = "0x136D2F0", Offset = "0x136C4F0", Length = "0x85D")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "OnEndParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SmallXmlParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChannelData), Member = "get_ClientProviders", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ProviderData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChannelData), Member = "get_ServerProviders", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001A03")]
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	[Address(RVA = "0x136D270", Offset = "0x136C470", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A00")]
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	[Address(RVA = "0x136DB50", Offset = "0x136CD50", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A01")]
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	[Address(RVA = "0x136DBD0", Offset = "0x136CDD0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A02")]
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	[Address(RVA = "0x136DC50", Offset = "0x136CE50", Length = "0x45E")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "OnEndParsing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SmallXmlParser)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivatedClientTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterActivatedServiceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivatedServiceTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownClientType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WellKnownClientTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingConfiguration), Member = "RegisterWellKnownServiceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WellKnownServiceTypeEntry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001A04")]
	internal static void RegisterTypes(ArrayList types) { }

	[Address(RVA = "0x136E0B0", Offset = "0x136D2B0", Length = "0x282")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020C520")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60019FE")]
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	[Address(RVA = "0x136E340", Offset = "0x136D540", Length = "0x178")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemotingServices), Member = "CreateWellKnownServerIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(WellKnownObjectMode)}, ReturnType = typeof(ServerIdentity))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019FF")]
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	[Address(RVA = "0x136EAF0", Offset = "0x136DCF0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60019F6")]
	public static void set_ApplicationName(string value) { }

	[Address(RVA = "0x136E4C0", Offset = "0x136D6C0", Length = "0x221")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A06")]
	internal static void SetCustomErrorsMode(string mode) { }

}

