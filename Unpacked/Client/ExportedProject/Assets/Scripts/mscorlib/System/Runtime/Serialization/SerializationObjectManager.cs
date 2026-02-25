namespace System.Runtime.Serialization;

[Token(Token = "0x20003D3")]
public sealed class SerializationObjectManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F24")]
	private readonly Dictionary<Object, Object> _objectSeenTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F25")]
	private readonly StreamingContext _context; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F26")]
	private SerializationEventHandler _onSerializedHandler; //Field offset: 0x28

	[Address(RVA = "0x1396460", Offset = "0x1395660", Length = "0x8C")]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISurrogateSelector), typeof(StreamingContext), typeof(InternalFE), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CFE")]
	public SerializationObjectManager(StreamingContext context) { }

	[Address(RVA = "0x13961D0", Offset = "0x13953D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D01")]
	private void AddOnSerialized(object obj) { }

	[Address(RVA = "0x1396270", Offset = "0x1395470", Length = "0x31")]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D00")]
	public void RaiseOnSerializedEvent() { }

	[Address(RVA = "0x13962B0", Offset = "0x13954B0", Length = "0x1A3")]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(ObjectWriter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CFF")]
	public void RegisterObject(object obj) { }

}

