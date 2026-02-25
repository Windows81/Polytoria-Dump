namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x2000361")]
public sealed class LifetimeServices
{
	[Token(Token = "0x4000E3D")]
	private static TimeSpan _leaseManagerPollTime; //Field offset: 0x0
	[Token(Token = "0x4000E3E")]
	private static TimeSpan _leaseTime; //Field offset: 0x8
	[Token(Token = "0x4000E3F")]
	private static TimeSpan _renewOnCallTime; //Field offset: 0x10
	[Token(Token = "0x4000E40")]
	private static TimeSpan _sponsorshipTimeout; //Field offset: 0x18
	[Token(Token = "0x4000E41")]
	private static LeaseManager _leaseManager; //Field offset: 0x20

	[Token(Token = "0x170002EC")]
	public static TimeSpan LeaseManagerPollTime
	{
		[Address(RVA = "0x13698F0", Offset = "0x1368AF0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE0")]
		 get { } //Length: 78
		[Address(RVA = "0x1369A30", Offset = "0x1368C30", Length = "0x7A")]
		[CalledBy(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LeaseManager), Member = "SetPollTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001AE1")]
		 set { } //Length: 122
	}

	[Token(Token = "0x170002ED")]
	public static TimeSpan LeaseTime
	{
		[Address(RVA = "0x1369940", Offset = "0x1368B40", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE2")]
		 get { } //Length: 79
		[Address(RVA = "0x1369AB0", Offset = "0x1368CB0", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE3")]
		 set { } //Length: 85
	}

	[Token(Token = "0x170002EE")]
	public static TimeSpan RenewOnCallTime
	{
		[Address(RVA = "0x1369990", Offset = "0x1368B90", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE4")]
		 get { } //Length: 79
		[Address(RVA = "0x1369B10", Offset = "0x1368D10", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE5")]
		 set { } //Length: 85
	}

	[Token(Token = "0x170002EF")]
	public static TimeSpan SponsorshipTimeout
	{
		[Address(RVA = "0x13699E0", Offset = "0x1368BE0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE6")]
		 get { } //Length: 79
		[Address(RVA = "0x1369B70", Offset = "0x1368D70", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001AE7")]
		 set { } //Length: 85
	}

	[Address(RVA = "0x1369780", Offset = "0x1368980", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001ADF")]
	private static LifetimeServices() { }

	[Address(RVA = "0x13698F0", Offset = "0x1368AF0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE0")]
	public static TimeSpan get_LeaseManagerPollTime() { }

	[Address(RVA = "0x1369940", Offset = "0x1368B40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE2")]
	public static TimeSpan get_LeaseTime() { }

	[Address(RVA = "0x1369990", Offset = "0x1368B90", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE4")]
	public static TimeSpan get_RenewOnCallTime() { }

	[Address(RVA = "0x13699E0", Offset = "0x1368BE0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE6")]
	public static TimeSpan get_SponsorshipTimeout() { }

	[Address(RVA = "0x1369A30", Offset = "0x1368C30", Length = "0x7A")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeaseManager), Member = "SetPollTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AE1")]
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	[Address(RVA = "0x1369AB0", Offset = "0x1368CB0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE3")]
	public static void set_LeaseTime(TimeSpan value) { }

	[Address(RVA = "0x1369B10", Offset = "0x1368D10", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE5")]
	public static void set_RenewOnCallTime(TimeSpan value) { }

	[Address(RVA = "0x1369B70", Offset = "0x1368D70", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001AE7")]
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	[Address(RVA = "0x1369710", Offset = "0x1368910", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AE8")]
	internal static void TrackLifetime(ServerIdentity identity) { }

}

