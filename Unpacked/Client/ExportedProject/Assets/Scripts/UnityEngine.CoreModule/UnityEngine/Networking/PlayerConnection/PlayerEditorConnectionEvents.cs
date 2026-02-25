namespace UnityEngine.Networking.PlayerConnection;

[Token(Token = "0x200028A")]
internal class PlayerEditorConnectionEvents
{
	[Token(Token = "0x200028C")]
	internal class ConnectionChangeEvent : UnityEvent<Int32>
	{

		[Address(RVA = "0x19809B0", Offset = "0x197FBB0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D10")]
		public ConnectionChangeEvent() { }

	}

	[Token(Token = "0x200028B")]
	internal class MessageEvent : UnityEvent<MessageEventArgs>
	{

		[Address(RVA = "0x1985440", Offset = "0x1984640", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D0F")]
		public MessageEvent() { }

	}

	[Token(Token = "0x200028D")]
	internal class MessageTypeSubscribers
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40006BD")]
		private string m_messageTypeId; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006BE")]
		public int subscriberCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006BF")]
		public MessageEvent messageCallback; //Field offset: 0x20

		[Token(Token = "0x17000211")]
		public Guid MessageTypeId
		{
			[Address(RVA = "0x1985510", Offset = "0x1984710", Length = "0x36")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Token(Token = "0x6000D11")]
			 get { } //Length: 54
			[Address(RVA = "0x1985550", Offset = "0x1984750", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x6000D12")]
			 set { } //Length: 44
		}

		[Address(RVA = "0x1985480", Offset = "0x1984680", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000D13")]
		public MessageTypeSubscribers() { }

		[Address(RVA = "0x1985510", Offset = "0x1984710", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000D11")]
		public Guid get_MessageTypeId() { }

		[Address(RVA = "0x1985550", Offset = "0x1984750", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000D12")]
		public void set_MessageTypeId(Guid value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40006B9")]
	private List<MessageTypeSubscribers> m_MessageTypeSubscribers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006BA")]
	private Dictionary<Guid, MessageTypeSubscribers> m_SubscriberLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40006BB")]
	public ConnectionChangeEvent connectionEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40006BC")]
	public ConnectionChangeEvent disconnectionEvent; //Field offset: 0x28

	[Token(Token = "0x17000210")]
	public IReadOnlyList<MessageTypeSubscribers> messageTypeSubscribers
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D09")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1989300", Offset = "0x1988500", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000D0E")]
	public PlayerEditorConnectionEvents() { }

	[Address(RVA = "0x1988AE0", Offset = "0x1987CE0", Length = "0x272")]
	[CalledBy(Type = typeof(PlayerConnection), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "BuildLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000D0C")]
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	[Address(RVA = "0x1988D60", Offset = "0x1987F60", Length = "0x2E0")]
	[CalledBy(Type = typeof(PlayerConnection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "MessageCallbackInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(ulong), typeof(ulong), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "InvokeMessageIdSubscribers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "AddAndCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "UnregisterManagedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000D0A")]
	private void BuildLookup() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D09")]
	public IReadOnlyList<MessageTypeSubscribers> get_messageTypeSubscribers() { }

	[Address(RVA = "0x1989050", Offset = "0x1988250", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "BuildLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D0B")]
	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x19891D0", Offset = "0x19883D0", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "BuildLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Guid, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D0D")]
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

}

