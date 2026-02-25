namespace System;

[Token(Token = "0x20001A7")]
internal class DelegateSerializationHolder : ISerializable, IObjectReference
{
	[Token(Token = "0x20001A8")]
	private class DelegateEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000709")]
		private string type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400070A")]
		private string assembly; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400070B")]
		private object target; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400070C")]
		private string targetTypeAssembly; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400070D")]
		private string targetTypeName; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400070E")]
		private string methodName; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400070F")]
		public DelegateEntry delegateEntry; //Field offset: 0x40

		[Address(RVA = "0x14F22C0", Offset = "0x14F14C0", Length = "0x1FF")]
		[CalledBy(Type = typeof(Delegate), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DelegateSerializationHolder), Member = "GetDelegateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MulticastDelegate), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214040")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 12)]
		[Token(Token = "0x6000F4C")]
		public DelegateEntry(Delegate del, string targetLabel) { }

		[Address(RVA = "0x14F1F50", Offset = "0x14F1150", Length = "0x361")]
		[CalledBy(Type = typeof(DelegateSerializationHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214040")]
		[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A500")]
		[Calls(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000F4D")]
		public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000708")]
	private Delegate _delegate; //Field offset: 0x10

	[Address(RVA = "0x14F2730", Offset = "0x14F1930", Length = "0x23C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate[])}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(DelegateEntry), Member = "DeserializeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F48")]
	private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx) { }

	[Address(RVA = "0x14F24C0", Offset = "0x14F16C0", Length = "0x22C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DelegateEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F49")]
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	[Address(RVA = "0x14F26F0", Offset = "0x14F18F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F4A")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F4B")]
	public override object GetRealObject(StreamingContext context) { }

}

