namespace System.Diagnostics;

[Token(Token = "0x2000107")]
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ProcessStartInfo
{
	[Token(Token = "0x40004AC")]
	private static readonly String[] empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000497")]
	private string fileName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000498")]
	private string arguments; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000499")]
	private string directory; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400049A")]
	private string verb; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400049B")]
	private ProcessWindowStyle windowStyle; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400049C")]
	private bool errorDialog; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400049D")]
	private IntPtr errorDialogParentHandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400049E")]
	private bool useShellExecute; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400049F")]
	private string userName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004A0")]
	private string domain; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004A1")]
	private SecureString password; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004A2")]
	private string passwordInClearText; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004A3")]
	private bool loadUserProfile; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40004A4")]
	private bool redirectStandardInput; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x40004A5")]
	private bool redirectStandardOutput; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x40004A6")]
	private bool redirectStandardError; //Field offset: 0x6B
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40004A7")]
	private Encoding standardOutputEncoding; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004A8")]
	private Encoding standardErrorEncoding; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004A9")]
	private bool createNoWindow; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004AA")]
	private WeakReference weakParentProcess; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40004AB")]
	internal StringDictionary environmentVariables; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40004AD")]
	private Collection<String> _argumentList; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40004AE")]
	private IDictionary<String, String> environment; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40004AF")]
	private Encoding <StandardInputEncoding>k__BackingField; //Field offset: 0xA8

	[Token(Token = "0x170000F0")]
	public Collection<String> ArgumentList
	{
		[Address(RVA = "0x177FD10", Offset = "0x177EF10", Length = "0x86")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600064C")]
		 get { } //Length: 134
	}

	[DefaultValue(null)]
	[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[Token(Token = "0x170000F1")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Arguments
	{
		[Address(RVA = "0x177FDA0", Offset = "0x177EFA0", Length = "0x1E")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600064D")]
		 get { } //Length: 30
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600064E")]
		 set { } //Length: 13
	}

	[NotifyParentProperty(True)]
	[Token(Token = "0x170000FB")]
	public string Domain
	{
		[Address(RVA = "0x177FDC0", Offset = "0x177EFC0", Length = "0x1E")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo), typeof(ProcInfo&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000658")]
		 get { } //Length: 30
	}

	[DefaultValue(null)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
	[NotifyParentProperty(True)]
	[Token(Token = "0x170000F2")]
	public StringDictionary EnvironmentVariables
	{
		[Address(RVA = "0x177FDE0", Offset = "0x177EFE0", Length = "0x44C")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600064F")]
		 get { } //Length: 1100
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether to show an error dialog to the user if there is an error.")]
	[NotifyParentProperty(True)]
	[Token(Token = "0x170000FF")]
	public bool ErrorDialog
	{
		[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600065C")]
		 set { } //Length: 4
	}

	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The name of the application, document or URL to start.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[Token(Token = "0x170000FD")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string FileName
	{
		[Address(RVA = "0x1780230", Offset = "0x177F430", Length = "0x1E")]
		[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x600065A")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000100")]
	internal bool HaveEnvVars
	{
		[Address(RVA = "0x1780250", Offset = "0x177F450", Length = "0xC")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600065D")]
		internal get { } //Length: 12
	}

	[NotifyParentProperty(True)]
	[Token(Token = "0x170000FC")]
	public bool LoadUserProfile
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000659")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FA")]
	public SecureString Password
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000657")]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
	[NotifyParentProperty(True)]
	[Token(Token = "0x170000F5")]
	public bool RedirectStandardError
	{
		[Address(RVA = "0x1765890", Offset = "0x1764A90", Length = "0x5")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000652")]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
	[NotifyParentProperty(True)]
	[Token(Token = "0x170000F3")]
	public bool RedirectStandardInput
	{
		[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000650")]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
	[NotifyParentProperty(True)]
	[Token(Token = "0x170000F4")]
	public bool RedirectStandardOutput
	{
		[Address(RVA = "0x17658A0", Offset = "0x1764AA0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000651")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F6")]
	public Encoding StandardErrorEncoding
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000653")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000101")]
	public Encoding StandardInputEncoding
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600065E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000F7")]
	public Encoding StandardOutputEncoding
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000654")]
		 get { } //Length: 5
	}

	[NotifyParentProperty(True)]
	[Token(Token = "0x170000F9")]
	public string UserName
	{
		[Address(RVA = "0x1780260", Offset = "0x177F460", Length = "0x1E")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo), typeof(ProcInfo&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Token(Token = "0x6000656")]
		 get { } //Length: 30
	}

	[DefaultValue(True)]
	[MonitoringDescription("Whether to use the operating system shell to start the process.")]
	[NotifyParentProperty(True)]
	[Token(Token = "0x170000F8")]
	public bool UseShellExecute
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000655")]
		 get { } //Length: 5
	}

	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The initial working directory for the process.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[Token(Token = "0x170000FE")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string WorkingDirectory
	{
		[Address(RVA = "0x1780280", Offset = "0x177F480", Length = "0x1E")]
		[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600065B")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x177FB70", Offset = "0x177ED70", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600065F")]
	private static ProcessStartInfo() { }

	[Address(RVA = "0x177FC20", Offset = "0x177EE20", Length = "0x52")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "OS_Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600064B")]
	public ProcessStartInfo(string fileName, string arguments) { }

	[Address(RVA = "0x177FC80", Offset = "0x177EE80", Length = "0x81")]
	[CalledBy(Type = typeof(Process), Member = "get_StartInfo", ReturnType = typeof(ProcessStartInfo))]
	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000649")]
	internal ProcessStartInfo(Process parent) { }

	[Address(RVA = "0x177FBE0", Offset = "0x177EDE0", Length = "0x35")]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600064A")]
	public ProcessStartInfo(string fileName) { }

	[Address(RVA = "0x177FD10", Offset = "0x177EF10", Length = "0x86")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600064C")]
	public Collection<String> get_ArgumentList() { }

	[Address(RVA = "0x177FDA0", Offset = "0x177EFA0", Length = "0x1E")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600064D")]
	public string get_Arguments() { }

	[Address(RVA = "0x177FDC0", Offset = "0x177EFC0", Length = "0x1E")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo), typeof(ProcInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000658")]
	public string get_Domain() { }

	[Address(RVA = "0x177FDE0", Offset = "0x177EFE0", Length = "0x44C")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064F")]
	public StringDictionary get_EnvironmentVariables() { }

	[Address(RVA = "0x1780230", Offset = "0x177F430", Length = "0x1E")]
	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600065A")]
	public string get_FileName() { }

	[Address(RVA = "0x1780250", Offset = "0x177F450", Length = "0xC")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600065D")]
	internal bool get_HaveEnvVars() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000659")]
	public bool get_LoadUserProfile() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000657")]
	public SecureString get_Password() { }

	[Address(RVA = "0x1765890", Offset = "0x1764A90", Length = "0x5")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000652")]
	public bool get_RedirectStandardError() { }

	[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000650")]
	public bool get_RedirectStandardInput() { }

	[Address(RVA = "0x17658A0", Offset = "0x1764AA0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000651")]
	public bool get_RedirectStandardOutput() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000653")]
	public Encoding get_StandardErrorEncoding() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600065E")]
	public Encoding get_StandardInputEncoding() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000654")]
	public Encoding get_StandardOutputEncoding() { }

	[Address(RVA = "0x1780260", Offset = "0x177F460", Length = "0x1E")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "FillUserInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo), typeof(ProcInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000656")]
	public string get_UserName() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000655")]
	public bool get_UseShellExecute() { }

	[Address(RVA = "0x1780280", Offset = "0x177F480", Length = "0x1E")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600065B")]
	public string get_WorkingDirectory() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600064E")]
	public void set_Arguments(string value) { }

	[Address(RVA = "0x500BD0", Offset = "0x4FFDD0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600065C")]
	public void set_ErrorDialog(bool value) { }

}

