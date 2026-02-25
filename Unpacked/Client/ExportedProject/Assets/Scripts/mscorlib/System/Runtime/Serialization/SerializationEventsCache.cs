namespace System.Runtime.Serialization;

[Token(Token = "0x20003D1")]
internal static class SerializationEventsCache
{
	[CompilerGenerated]
	[Token(Token = "0x20003D2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000F22")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000F23")]
		public static Func<Type, SerializationEvents> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x1397CA0", Offset = "0x1396EA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CFB")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CFC")]
		public <>c() { }

		[Address(RVA = "0x1397A80", Offset = "0x1396C80", Length = "0x16E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SerializationEvents), Member = "GetMethodsWithAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CFD")]
		internal SerializationEvents <GetSerializationEventsForType>b__1_0(Type type) { }

	}

	[Token(Token = "0x4000F21")]
	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache; //Field offset: 0x0

	[Address(RVA = "0x13929B0", Offset = "0x1391BB0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001CFA")]
	private static SerializationEventsCache() { }

	[Address(RVA = "0x1392850", Offset = "0x1391A50", Length = "0x159")]
	[CalledBy(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationObjectManager), Member = "AddOnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "AddOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializingEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CF9")]
	internal static SerializationEvents GetSerializationEventsForType(Type t) { }

}

