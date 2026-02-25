namespace System.Runtime.Remoting.Lifetime;

[Token(Token = "0x200035E")]
internal class LeaseManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E34")]
	private ArrayList _objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E35")]
	private Timer _timer; //Field offset: 0x18

	[Address(RVA = "0x13684F0", Offset = "0x13676F0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001ADA")]
	public LeaseManager() { }

	[Address(RVA = "0x1367D90", Offset = "0x1366F90", Length = "0x24D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001AD9")]
	public void ManageLeases(object state) { }

	[Address(RVA = "0x1367FE0", Offset = "0x13671E0", Length = "0xCB")]
	[CalledBy(Type = typeof(LifetimeServices), Member = "set_LeaseManagerPollTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AD5")]
	public void SetPollTime(TimeSpan timeSpan) { }

	[Address(RVA = "0x13680B0", Offset = "0x13672B0", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AD7")]
	public void StartManager() { }

	[Address(RVA = "0x1368230", Offset = "0x1367430", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Timer), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6001AD8")]
	public void StopManager() { }

	[Address(RVA = "0x1368270", Offset = "0x1367470", Length = "0x275")]
	[CalledBy(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILease)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LifetimeServices), Member = "TrackLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AD6")]
	public void TrackLifetime(ServerIdentity identity) { }

}

