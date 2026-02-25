namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x2000391")]
public sealed class LogicalCallContext : ISerializable, ICloneable
{
	[Token(Token = "0x2000392")]
	public struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E89")]
		private LogicalCallContext m_ctx; //Field offset: 0x0

		[Token(Token = "0x17000329")]
		public bool HasInfo
		{
			[Address(RVA = "0x13908D0", Offset = "0x138FAD0", Length = "0x77")]
			[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6001BA5")]
			 get { } //Length: 119
		}

		[Token(Token = "0x17000328")]
		public bool IsNull
		{
			[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
			[CallerCount(Count = 8)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BA4")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA3")]
		public Reader(LogicalCallContext ctx) { }

		[Address(RVA = "0x1390860", Offset = "0x138FA60", Length = "0x64")]
		[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6001BA6")]
		public LogicalCallContext Clone() { }

		[Address(RVA = "0x13908D0", Offset = "0x138FAD0", Length = "0x77")]
		[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BA5")]
		public bool get_HasInfo() { }

		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA4")]
		public bool get_IsNull() { }

	}

	[Token(Token = "0x4000E83")]
	private static Type s_callContextType; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E84")]
	private Hashtable m_Datastore; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E85")]
	private CallContextRemotingData m_RemotingData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E86")]
	private CallContextSecurityData m_SecurityData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E87")]
	private object m_HostContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E88")]
	private bool m_IsCorrelationMgr; //Field offset: 0x30

	[Token(Token = "0x17000327")]
	private Hashtable Datastore
	{
		[Address(RVA = "0x1383400", Offset = "0x1382600", Length = "0x69")]
		[CalledBy(Type = typeof(LogicalCallContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(LogicalCallContext), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001BA1")]
		private get { } //Length: 105
	}

	[Token(Token = "0x17000325")]
	public bool HasInfo
	{
		[Address(RVA = "0x1383470", Offset = "0x1382670", Length = "0x60")]
		[CalledBy(Type = typeof(Reader), Member = "IsDefaultFTContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
		[CalledBy(Type = typeof(ExecutionContext), Member = "IsDefaultFTContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B9F")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000326")]
	private bool HasUserData
	{
		[Address(RVA = "0x1381910", Offset = "0x1380B10", Length = "0x33")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA0")]
		private get { } //Length: 51
	}

	[Address(RVA = "0x1382C70", Offset = "0x1381E70", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001BA2")]
	private static LogicalCallContext() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B9A")]
	internal LogicalCallContext() { }

	[Address(RVA = "0x1382CF0", Offset = "0x1381EF0", Length = "0x707")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B9B")]
	internal LogicalCallContext(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1381950", Offset = "0x1380B50", Length = "0x79E")]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(Reader), Member = "Clone", ReturnType = typeof(LogicalCallContext))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6001B9D")]
	public override object Clone() { }

	[Address(RVA = "0x1383400", Offset = "0x1382600", Length = "0x69")]
	[CalledBy(Type = typeof(LogicalCallContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(LogicalCallContext), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogicalCallContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001BA1")]
	private Hashtable get_Datastore() { }

	[Address(RVA = "0x1383470", Offset = "0x1382670", Length = "0x60")]
	[CalledBy(Type = typeof(Reader), Member = "IsDefaultFTContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackCrawlMark&), typeof(CaptureOptions)}, ReturnType = typeof(ExecutionContext))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "IsDefaultFTContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001B9F")]
	public bool get_HasInfo() { }

	[Address(RVA = "0x1381910", Offset = "0x1380B10", Length = "0x33")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA0")]
	private bool get_HasUserData() { }

	[Address(RVA = "0x13820F0", Offset = "0x13812F0", Length = "0x86A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001B9C")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1382960", Offset = "0x1381B60", Length = "0x302")]
	[CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001B9E")]
	internal void Merge(LogicalCallContext lc) { }

}

