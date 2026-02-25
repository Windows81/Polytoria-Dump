namespace System.Runtime.Serialization;

[Token(Token = "0x20003D0")]
internal sealed class SerializationEvents
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F1D")]
	private readonly List<MethodInfo> _onSerializingMethods; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F1E")]
	private readonly List<MethodInfo> _onSerializedMethods; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F1F")]
	private readonly List<MethodInfo> _onDeserializingMethods; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F20")]
	private readonly List<MethodInfo> _onDeserializedMethods; //Field offset: 0x28

	[Token(Token = "0x170003A2")]
	internal bool HasOnSerializingEvents
	{
		[Address(RVA = "0x5A28C0", Offset = "0x5A1AC0", Length = "0x13")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CF1")]
		internal get { } //Length: 19
	}

	[Address(RVA = "0x1392F90", Offset = "0x1392190", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationEvents), Member = "GetMethodsWithAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CEF")]
	internal SerializationEvents(Type t) { }

	[Address(RVA = "0x1392A40", Offset = "0x1391C40", Length = "0x1E5")]
	[CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializingEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "AddOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationObjectManager), Member = "AddOnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "AddOnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler)}, ReturnType = typeof(SerializationEventHandler))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDeserializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "AddOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler)}, ReturnType = typeof(SerializationEventHandler))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF8")]
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }

	[Address(RVA = "0x1392C30", Offset = "0x1391E30", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[Token(Token = "0x6001CF6")]
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	[Address(RVA = "0x1392C50", Offset = "0x1391E50", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[Token(Token = "0x6001CF5")]
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	[Address(RVA = "0x5A28C0", Offset = "0x5A1AC0", Length = "0x13")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CF1")]
	internal bool get_HasOnSerializingEvents() { }

	[Address(RVA = "0x1392C70", Offset = "0x1391E70", Length = "0x1E8")]
	[CalledBy(Type = typeof(SerializationEvents), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.Serialization.SerializationEventsCache+<>c", Member = "<GetSerializationEventsForType>b__1_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001CF0")]
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	[Address(RVA = "0x1392E60", Offset = "0x1392060", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF7")]
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	[Address(RVA = "0x1392EA0", Offset = "0x13920A0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF4")]
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	[Address(RVA = "0x1392EF0", Offset = "0x13920F0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF3")]
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	[Address(RVA = "0x1392F40", Offset = "0x1392140", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CF2")]
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

}

