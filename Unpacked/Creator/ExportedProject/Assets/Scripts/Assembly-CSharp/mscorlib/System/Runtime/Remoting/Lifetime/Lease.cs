namespace System.Runtime.Remoting.Lifetime;

[Token(Token = "0x200035C")]
internal class Lease : MarshalByRefObject, ILease
{
	[Token(Token = "0x200035D")]
	private sealed class RenewalDelegate : MulticastDelegate
	{

		[Address(RVA = "0x309270", Offset = "0x308470", Length = "0x124")]
		[CallerCount(Count = 208)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD1")]
		public RenewalDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD3")]
		public override IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

		[Address(RVA = "0x396940", Offset = "0x395B40", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD4")]
		public override TimeSpan EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AD2")]
		public override TimeSpan Invoke(ILease lease) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E2C")]
	private DateTime _leaseExpireTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E2D")]
	private LeaseState _currentState; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E2E")]
	private TimeSpan _initialLeaseTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E2F")]
	private TimeSpan _renewOnCallTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E30")]
	private TimeSpan _sponsorshipTimeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E31")]
	private ArrayList _sponsors; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E32")]
	private Queue _renewingSponsors; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E33")]
	private RenewalDelegate _renewalDelegate; //Field offset: 0x50

	[Token(Token = "0x170002E9")]
	public override TimeSpan CurrentLeaseTime
	{
		[Address(RVA = "0x13696B0", Offset = "0x13688B0", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
		[Token(Token = "0x6001AC8")]
		 get { } //Length: 88
	}

	[Token(Token = "0x170002EA")]
	public override LeaseState CurrentState
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001AC9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002EB")]
	public override TimeSpan RenewOnCallTime
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001ACB")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x1369540", Offset = "0x1368740", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AC7")]
	public Lease() { }

	[Address(RVA = "0x1368810", Offset = "0x1367A10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001ACA")]
	public void Activate() { }

	[Address(RVA = "0x1368820", Offset = "0x1367A20", Length = "0x3A4")]
	[CalledBy(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001ACF")]
	private void CheckNextSponsor() { }

	[Address(RVA = "0x13696B0", Offset = "0x13688B0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6001AC8")]
	public override TimeSpan get_CurrentLeaseTime() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001AC9")]
	public override LeaseState get_CurrentState() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001ACB")]
	public override TimeSpan get_RenewOnCallTime() { }

	[Address(RVA = "0x1368BD0", Offset = "0x1367DD0", Length = "0x59C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Lease), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISponsor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001AD0")]
	private void ProcessSponsorResponse(object state, bool timedOut) { }

	[Address(RVA = "0x1369170", Offset = "0x1368370", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6001ACC")]
	public override TimeSpan Renew(TimeSpan renewalTime) { }

	[Address(RVA = "0x1369240", Offset = "0x1368440", Length = "0x14A")]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001ACD")]
	public override void Unregister(ISponsor obj) { }

	[Address(RVA = "0x1369390", Offset = "0x1368590", Length = "0x1A0")]
	[CalledBy(Type = typeof(LeaseManager), Member = "ManageLeases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Queue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lease), Member = "CheckNextSponsor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001ACE")]
	internal void UpdateState() { }

}

