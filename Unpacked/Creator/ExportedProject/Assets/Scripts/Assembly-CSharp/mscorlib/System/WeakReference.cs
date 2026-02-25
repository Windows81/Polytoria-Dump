namespace System;

[ComVisible(True)]
[Token(Token = "0x20001DA")]
public class WeakReference : ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000947")]
	private bool isLongReference; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000948")]
	private GCHandle gcHandle; //Field offset: 0x18

	[Token(Token = "0x1700017C")]
	public override bool IsAlive
	{
		[Address(RVA = "0x151F6D0", Offset = "0x151E8D0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001068")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700017D")]
	public override object Target
	{
		[Address(RVA = "0x151F700", Offset = "0x151E900", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001069")]
		 get { } //Length: 57
		[Address(RVA = "0x151F740", Offset = "0x151E940", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600106A")]
		 set { } //Length: 95
	}

	[Token(Token = "0x1700017E")]
	public override bool TrackResurrection
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600106B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001064")]
	protected WeakReference() { }

	[Address(RVA = "0x151F520", Offset = "0x151E720", Length = "0x37")]
	[CalledBy(Type = typeof(ClientIdentity), Member = "set_ClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.Switch", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.Process"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "set_Credentials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.NetworkCredential"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequest"}, ReturnType = "PipelineEntry[]")]
	[CalledBy(Type = "System.Net.TimerThread", Member = "CreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Net.TimerThread+Queue")]
	[CalledBy(Type = "System.Net.TimerThread", Member = "GetOrCreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Net.TimerThread+Queue")]
	[CalledBy(Type = "System.Xml.XmlDocument", Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.XmlElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "System.Xml.Linq.XNamespace")]
	[CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = "System.Xml.Linq.XNamespace")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001065")]
	public WeakReference(object target) { }

	[Address(RVA = "0x151F560", Offset = "0x151E760", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001066")]
	public WeakReference(object target, bool trackResurrection) { }

	[Address(RVA = "0x151F5B0", Offset = "0x151E7B0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001067")]
	protected WeakReference(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x151F370", Offset = "0x151E570", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001063")]
	private void AllocateHandle(object target) { }

	[Address(RVA = "0x151F3A0", Offset = "0x151E5A0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600106C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x151F6D0", Offset = "0x151E8D0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001068")]
	public override bool get_IsAlive() { }

	[Address(RVA = "0x151F700", Offset = "0x151E900", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001069")]
	public override object get_Target() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106B")]
	public override bool get_TrackResurrection() { }

	[Address(RVA = "0x151F400", Offset = "0x151E600", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600106D")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x151F740", Offset = "0x151E940", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600106A")]
	public override void set_Target(object value) { }

}

